#pragma checksum "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\Pages\PageWithParameter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2696e2f3db0956d63458a47823e65005a9a3301b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/page-params/{Type}/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/page-params/{Type}")]
    public partial class PageWithParameter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Page With Parameter</h3>\r\n");
            __builder.AddMarkupContent(1, "<h5>Parameter Values:</h5>\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Type: ");
#nullable restore
#line 6 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\Pages\PageWithParameter.razor"
__builder.AddContent(4, Type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Id: ");
#nullable restore
#line 7 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\Pages\PageWithParameter.razor"
__builder.AddContent(8, Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\Blazor\BlazorUnitTestsPoc\BlazorUnitTestsPoc\Pages\PageWithParameter.razor"
       
    [Parameter]
    public string Type { get; set; }

    [Parameter]
    public int? Id { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
