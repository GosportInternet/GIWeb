#pragma checksum "C:\Users\George\Documents\GIWeb\Pages\PasswordReset.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa1637b21d22be1ecc5c2e9cce891fcb28ff2f13"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using GIWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using GIWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\George\Documents\GIWeb\Pages\PasswordReset.razor"
using GIWeb.Shared.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/resetpassword")]
    public partial class PasswordReset : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridRow>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(4);
                __builder2.AddAttribute(5, "Width", "3");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(7);
                __builder2.AddAttribute(8, "CustomClass", "text-center");
                __builder2.AddAttribute(9, "Width", "6");
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(11);
                    __builder3.AddAttribute(12, "Placeholder", "Email address.");
                    __builder3.AddAttribute(13, "CustomClass", "mb-1");
                    __builder3.AddComponentReferenceCapture(14, (__value) => {
#nullable restore
#line 9 "C:\Users\George\Documents\GIWeb\Pages\PasswordReset.razor"
                           Email = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIButton>(16);
                    __builder3.AddAttribute(17, "ButtonText", "Reset");
                    __builder3.AddAttribute(18, "CustomClass", "mt-2 mb-2");
                    __builder3.AddAttribute(19, "Width", "150px;");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.AddMarkupContent(21, "<div><a href=\"/login\" style=\"width:150px;\" class=\"woocommerce-Button btn btn-maincolor3 mt-2\" role=\"button\"><span>Back</span></a></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(23);
                __builder2.AddAttribute(24, "Width", "3");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n<div style=\"height:100px;\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\George\Documents\GIWeb\Pages\PasswordReset.razor"
       

    GIInput Firstname, Surname, Email, ComfirmEmail, Password, ComfirmPassword;
    GiCheckbox TermsOfService;

    public void AttemptRegister()
    {
        Console.WriteLine("Attempting to signin with credienials: Email= " + Email.GetValue() + " - Password= " + Password.GetValue());
    }

    public void ButtonClick()
    {
        Console.WriteLine("DONG!!");
    }

    public void PrintOnChange(string text)
    {
        Console.WriteLine(text.ToString());
    }

    //protected override async Task OnInitializedAsync()
    //{

    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
