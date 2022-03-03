using BlazorUnitTestsPoc.Pages;
using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System.Linq;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace TestProject1
{
    public class Tests
    {
        private Bunit.TestContext testContext;
        private Mock<ILoginProcessor> loginProcessor;
        [SetUp]
        public void Setup()
        {
            testContext = new Bunit.TestContext();
            loginProcessor = new Mock<ILoginProcessor>();
        }

        [TearDown]
        public void TearDown()
        {
            testContext.Dispose();
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            
        }

        [Test]
        public void TestHomePageRender()
        {
            var component = testContext.RenderComponent<Index>();

            var expectedHtml = @"<h1>Hello, world!</h1>

<p>Welcome to your new app.</p>";

            component.MarkupMatches(expectedHtml);

            
        }

        [Test]
        public void TestCounter()
        {
            var context = new Bunit.TestContext();
            var cut = context.RenderComponent<Counter>();
            cut.Find("p").MarkupMatches("<p>Current count: 0</p>");

            var element = cut.Find("button");
            element.Click();

            cut.Find("p").MarkupMatches("<p>Current count: 1</p>");
        }

        [Test]
        public void NoEmailPasswordCondition()
        {
            //this will setup the ILoginProcessor dependency with the mocked loginProcessor in DI
            testContext.Services.AddScoped(x => loginProcessor.Object);

            var component = testContext.RenderComponent<LoginForm>();

            //this will verify whether text exists in login form component
            Assert.IsTrue(component.Markup.Contains("<h3>Login Form</h3>"));


            var buttons = component.FindAll("button");
            Assert.AreEqual(1, buttons.Count);

            var submit = buttons.FirstOrDefault(b => b.OuterHtml.Contains("Submit"));
            Assert.IsNotNull(submit); //this will ensure submit button is not null

            submit.Click(); //This will call the login method and check for the validations

            loginProcessor.Verify(l => l.Login(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void ProperEmailPasswordCondition()
        {
            testContext.Services.AddScoped(x => loginProcessor.Object);

            var component = testContext.RenderComponent<LoginForm>();

            var buttons = component.FindAll("button");
 
            var submit = buttons.FirstOrDefault(b => b.OuterHtml.Contains("Submit"));

            var email = component.Find("#email");
            email.Change("testemail");

            var password = component.Find("#password");
            password.Change("testpassword");

            loginProcessor.Setup(l => l.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(false);

            submit.Click();
            loginProcessor.Verify(l => l.Login(It.IsAny<string>(), It.IsAny<string>()), Times.Once);

            var alert = component.Find("div.alert");
            Assert.AreEqual("invalid credentials", alert.InnerHtml);

        }

        [Test]
        public void ButtonLinkTest()
        {
            var component = testContext.RenderComponent<LogoutPage>();
            var nav = testContext.Services.GetRequiredService<NavigationManager>();
            component.Find("button").Click();

            //Assert.Equal("https://localhost:44363/login", nav.Uri);
        }

        [Test]
        public void InitialRenderWithParameters()
        {
            var comp = testContext.RenderComponent<PageWithParameter>(parameters => parameters.Add(p => p.Type, "TestType").Add(p => p.Id, 101));

            var expectedHtml = @"<h3>Page With Parameter</h3>
<h5>Parameter Values:</h5>
<p>Type: TestType</p>
<p>Id: 101</p>";

            comp.MarkupMatches(expectedHtml);
        }

        [Test]
        public void InitialRenderWithoutOptionalId()
        {
            var comp = testContext.RenderComponent<PageWithParameter>(parameters => parameters
                    .Add(p => p.Type, "TestType"));

            var expectedHtml = @"<h3>Page With Parameter</h3>
<h5>Parameter Values:</h5>
<p>Type: TestType</p>
<p>Id: </p>";

            comp.MarkupMatches(expectedHtml);
        }
    }
}