#pragma checksum "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d007b74ec78d668a4c6d5dbde1f3bdbfd92545"
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
#nullable restore
#line 1 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class GIModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "animate__animated" + " modal" + " " + (
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                                     transitionClass

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                                                      backdropClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "id", "exampleModalCenter");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.AddAttribute(5, "aria-labelledby", "exampleModalCenterTitle");
            __builder.AddAttribute(6, "aria-hidden", "true");
            __builder.AddAttribute(7, "style", 
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                                                                                                                                                                                              modalStyle

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(10, "role", "document");
            __builder.AddAttribute(11, "style", "max-width:" + (
#nullable restore
#line 4 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                                                                                      PreferredWidth

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddAttribute(18, "id", "exampleModalCenterTitle");
            __builder.AddContent(19, 
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                                                                      Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "close");
            __builder.AddAttribute(24, "data-dismiss", "modal");
            __builder.AddAttribute(25, "aria-label", "Close");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                                                                                                      HideModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-body");
            __builder.AddContent(31, 
#nullable restore
#line 13 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                 ModalContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
             if (ShowFooter)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-footer");
            __builder.AddContent(34, 
#nullable restore
#line 18 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
                     ModalFooter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\George\Documents\GIWeb\Shared\Components\GIModal.razor"
      

    [Parameter]
    public RenderFragment ModalContent { get; set; }
    [Parameter]
    public bool ShowFooter { get; set; }

    [Parameter]
    public bool Transition { get; set; } = false;
    [Parameter]
    public RenderFragment ModalFooter { get; set; }

    [Parameter]
    public string Title { get; set; } = "";
    [Parameter]
    public bool Backdrop { get; set; }

    [Parameter]
    public string PreferredWidth { get; set; } = "1250px";

    private string backdropClass { get; set; } = "";
    private string transitionClass { get; set; } = "";

    private bool showModal { get; set; } = false;
    private string modalStyle = "display:none;";
    public void ShowModal()
    {
        modalStyle = "display: block; padding-right: 15px; width:100%;";

        if (Backdrop)
        {
            backdropClass = "modal-backdrop";
        }

        if (Transition)
        {
            transitionClass = "animate__fadeIn";
        }
        Console.WriteLine("ShowModal");
        StateHasChanged();
    }

    public void HideModal()
    {
        if (Transition)
        {
            transitionClass = "animate__fadeOut";
            closeAfterAnimate();
        }
        else
        {
            modalStyle = "display:none;";
        }
        Console.WriteLine("HideModal");
        StateHasChanged();
    }

    private int fadeTime { get; set; } = 3;
    private void closeAfterAnimate()
    {
        CancellationTokenSource source = new CancellationTokenSource();

        var t = Task.Run(async delegate
        {
            Console.WriteLine("Starting delay before close");
            await Task.Delay(400, source.Token);
            modalStyle = "display:none;";
            transitionClass = "animate__fadeIn";
            StateHasChanged();
            Console.WriteLine("Has closed");
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
