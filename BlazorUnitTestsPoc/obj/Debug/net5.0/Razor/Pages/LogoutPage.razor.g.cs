#pragma checksum "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\Pages\LogoutPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aba761b6af33faadfacd8bb3e7a7018e6127137"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUnitTestsPoc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using BlazorUnitTestsPoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\_Imports.razor"
using BlazorUnitTestsPoc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class LogoutPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Logout Page</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "id", "button-link");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\Pages\LogoutPage.razor"
                                                            NavigateToLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Logout");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\Pages\LogoutPage.razor"
       
    private void NavigateToLogin()
    {
        navigationManager.NavigateTo("login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
