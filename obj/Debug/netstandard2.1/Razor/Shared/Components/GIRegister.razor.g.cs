#pragma checksum "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "418aa68f50dcaa845a5cd2b762e05439d4cdd963"
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
#line 1 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using GIWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using GIWeb.Shared;

#line default
#line hidden
#nullable disable
    public partial class GIRegister : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridRow>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(6);
                __builder2.AddAttribute(7, "Width", "3");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(9);
                __builder2.AddAttribute(10, "CustomClass", "text-center");
                __builder2.AddAttribute(11, "Width", "6");
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(14);
                    __builder3.AddAttribute(15, "Id", "login_firstname");
                    __builder3.AddAttribute(16, "Placeholder", "First Name");
                    __builder3.AddAttribute(17, "BottomMargin", "3");
                    __builder3.AddAttribute(18, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "LabelText", "First Name");
                    __builder3.AddAttribute(20, "LabelClass", "float-left");
                    __builder3.AddAttribute(21, "TopMargin", "1");
                    __builder3.AddComponentReferenceCapture(22, (__value) => {
#nullable restore
#line 6 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                Firstname = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(24);
                    __builder3.AddAttribute(25, "Id", "login_surname");
                    __builder3.AddAttribute(26, "Placeholder", "Surname");
                    __builder3.AddAttribute(27, "BottomMargin", "3");
                    __builder3.AddAttribute(28, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "LabelText", "Surname");
                    __builder3.AddAttribute(30, "TopMargin", "1");
                    __builder3.AddAttribute(31, "LabelClass", "float-left");
                    __builder3.AddComponentReferenceCapture(32, (__value) => {
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                               Surname = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(34);
                    __builder3.AddAttribute(35, "Id", "login_email");
                    __builder3.AddAttribute(36, "Placeholder", "Email address");
                    __builder3.AddAttribute(37, "BottomMargin", "3");
                    __builder3.AddAttribute(38, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "LabelText", "Email");
                    __builder3.AddAttribute(40, "TopMargin", "1");
                    __builder3.AddAttribute(41, "LabelClass", "float-left");
                    __builder3.AddComponentReferenceCapture(42, (__value) => {
#nullable restore
#line 8 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                             Email = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(44);
                    __builder3.AddAttribute(45, "Id", "login_comfirmemail");
                    __builder3.AddAttribute(46, "Placeholder", "Re-enter email");
                    __builder3.AddAttribute(47, "BottomMargin", "3");
                    __builder3.AddAttribute(48, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "LabelText", "Comfirm Email");
                    __builder3.AddAttribute(50, "TopMargin", "1");
                    __builder3.AddAttribute(51, "LabelClass", "float-left");
                    __builder3.AddComponentReferenceCapture(52, (__value) => {
#nullable restore
#line 9 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                   ComfirmEmail = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(54);
                    __builder3.AddAttribute(55, "Id", "login_password");
                    __builder3.AddAttribute(56, "IsAPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Placeholder", "Password");
                    __builder3.AddAttribute(58, "BottomMargin", "3");
                    __builder3.AddAttribute(59, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                                                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "LabelText", "Password");
                    __builder3.AddAttribute(61, "TopMargin", "1");
                    __builder3.AddAttribute(62, "LabelClass", "float-left");
                    __builder3.AddComponentReferenceCapture(63, (__value) => {
#nullable restore
#line 10 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                Password = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(65);
                    __builder3.AddAttribute(66, "Id", "login_comfirmpassword");
                    __builder3.AddAttribute(67, "IsAPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "Placeholder", "Re-enter password");
                    __builder3.AddAttribute(69, "BottomMargin", "3");
                    __builder3.AddAttribute(70, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                                                                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "LabelText", "Comfirm Password");
                    __builder3.AddAttribute(72, "TopMargin", "1");
                    __builder3.AddAttribute(73, "LabelClass", "float-left");
                    __builder3.AddComponentReferenceCapture(74, (__value) => {
#nullable restore
#line 11 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
                                                       ComfirmPassword = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.AddMarkupContent(76, "<small class>By clicking \"Sign Up\" below, you agree to the <a href=\"/terms_of_use.html\">Terms of Service</a> and <a href=\"/terms_of_use.html\">Privacy Policy</a>.</small>\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIButton>(77);
                    __builder3.AddAttribute(78, "ButtonText", "Create Account");
                    __builder3.AddAttribute(79, "Width", "150px;");
                    __builder3.AddAttribute(80, "CustomClass", "float-right mt-4");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(83);
                __builder2.AddAttribute(84, "Width", "3");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIRegister.razor"
       

    GIInput Firstname, Surname, Email, ComfirmEmail, Password, ComfirmPassword;
    GiCheckbox TermsOfService;

    public void AttemptRegister()
    {
        Console.WriteLine("Firstname: " + Firstname.GetValue() + " - " + "Surname: " + Surname.GetValue() + " - " + "Email: " + Email.GetValue() + " - " + "Comfirm Email: " + ComfirmEmail.GetValue() + " - " + "Password: " + Password.GetValue() + "Comfirm Password: " + ComfirmPassword.GetValue());
        RegisterAccountRequest request = new RegisterAccountRequest();

        if (Email.GetValue() == ComfirmPassword.GetValue())
        {
            if (Password.GetValue() == ComfirmPassword.GetValue())
            {

                request.Firstname = Firstname.GetValue();
                request.Surname = Surname.GetValue();
                request.Email = Email.GetValue();
                request.Password = Password.GetValue();

                // Send request to API
            }
        }
    }

    public void ButtonClick()
    {
        Console.WriteLine("DONG!!");
    }

    public void PrintOnChange(string text)
    {
        Console.WriteLine(text.ToString());
    }

    public class RegisterAccountRequest
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
