#pragma checksum "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca609dc267105131f09e963b59c109b030eab10"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Shared.Components
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
    public partial class GILogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridLayout>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridRow>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(4);
                    __builder3.AddAttribute(5, "Width", "3");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(6, "\r\n        ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(7);
                    __builder3.AddAttribute(8, "CustomClass", "text-center");
                    __builder3.AddAttribute(9, "Width", "6");
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<GIWeb.Shared.Components.GIInput>(11);
                        __builder4.AddAttribute(12, "Id", "i1");
                        __builder4.AddAttribute(13, "Placeholder", "Email");
                        __builder4.AddAttribute(14, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GIWeb.Shared.Components.GIInput.Alignment>(
#nullable restore
#line 6 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                                     GIInput.Alignment.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "BottomMargin", "3");
                        __builder4.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 6 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                           Email = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n            ");
                        __builder4.OpenComponent<GIWeb.Shared.Components.GIInput>(18);
                        __builder4.AddAttribute(19, "Id", "i2");
                        __builder4.AddAttribute(20, "Placeholder", "Password");
                        __builder4.AddAttribute(21, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GIWeb.Shared.Components.GIInput.Alignment>(
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                                           GIInput.Alignment.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddComponentReferenceCapture(22, (__value) => {
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                           Password = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n            ");
                        __builder4.OpenElement(24, "div");
                        __builder4.AddMarkupContent(25, "<a href=\"/resetpassword\" target=\"_blank\" class=\"float-left ml-1 mt-3\">Forgot password?</a>\r\n                ");
                        __builder4.OpenComponent<GIWeb.Shared.Components.GIButton>(26);
                        __builder4.AddAttribute(27, "ButtonText", "Sign in");
                        __builder4.AddAttribute(28, "OnClickEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                              AttemptSignIn

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(29, "Width", "150px");
                        __builder4.AddAttribute(30, "Colour", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GIWeb.Shared.Components.GIButton.ButtonColour>(
#nullable restore
#line 10 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                                                                   GIButton.ButtonColour.Green

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "CustomClass", "mr-1 float-right");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n        ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(33);
                    __builder3.AddAttribute(34, "Width", "3");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.AddMarkupContent(36, "<div style=\"margin-left: 25%; margin-right:25%;\"><hr></div>\r\n    ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridRow>(37);
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(39);
                    __builder3.AddAttribute(40, "Width", "3");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n        ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(42);
                    __builder3.AddAttribute(43, "CustomClass", "text-center");
                    __builder3.AddAttribute(44, "Width", "6");
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(46, "<label class=\"float-left mt-4 ml-1\">Don\'t have an account?</label>\r\n            ");
                        __builder4.AddMarkupContent(47, "<a href=\"/register\" style=\"width:150px;\" class=\"woocommerce-Button btn btn-maincolor float-right mr-1 mt-1\" role=\"button\"><span>Create Account</span></a>");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n        ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(49);
                    __builder3.AddAttribute(50, "Width", "3");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
       

    GIInput Email, Password;

    public void AttemptSignIn()
    {

        Console.WriteLine("Attempting to signin with credienials: Email= " + Email.GetValue() + " - Password= " + Password.GetValue());

        LoginRequest request = new LoginRequest();

        if (Email.GetValue() != null && Email.GetValue().ToString().Contains("@"))
        {
            request.Email = Email.GetValue();
            request.Password = Password.GetValue();

            // Send login request
        }
    }

    //protected override async Task OnInitializedAsync()
    //{

    //}

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
