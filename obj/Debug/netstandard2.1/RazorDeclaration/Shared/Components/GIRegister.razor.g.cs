// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class GIRegister : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\George\Documents\GIWeb\Shared\Components\GIRegister.razor"
       

    GIInput Firstname, Surname, Email, ComfirmEmail, Password, ComfirmPassword;
    GiCheckbox TermsOfService;

    protected override async Task OnInitializedAsync()
    {

    }

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
