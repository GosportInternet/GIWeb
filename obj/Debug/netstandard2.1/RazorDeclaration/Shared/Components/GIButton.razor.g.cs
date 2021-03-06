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
    public partial class GIButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIButton.razor"
       

    [Parameter]
    public string CustomClass { get; set; }
    [Parameter]
    public string BtnClass { get; set; } = "btn btn-";

    [Parameter]
    public string Shadow { get; set; }

    [Parameter]
    public string BackgroundColour { get; set; } = "#866fbd";

    [Parameter]
    public string Href { get; set; }
    [Parameter]
    public string BorderColor { get; set; } = "#866fbd";
    [Parameter]
    public string BorderWidth { get; set; } = "1px";
    [Parameter]
    public string Id { get; set; }
    [Parameter]
    public string ButtonText { get; set; }

    [Parameter]
    public string FontColour { get; set; } = "white";

    [Parameter]
    public EventCallback OnClickEvent { get; set; }

    [Parameter]
    public string Width { get; set; } = "100px";

    [Parameter]
    public string Padding { get; set; } = "0";

    [Parameter]
    public string Margin { get; set; } = "0";

    [Parameter]
    public ButtonColour Colour { get; set; } = ButtonColour.Purple;

    private async Task ButtonClick()
    {
        await OnClickEvent.InvokeAsync(null);
    }

    private string GetClass()
    {
        return BtnClass + GetColour();
    }

    private string GetColour()
    {
        switch (Colour)
        {
            case ButtonColour.Purple:
                return "maincolor";
                break;
            case ButtonColour.Blue:
                return "maincolor2";
                break;
            case ButtonColour.Green:
                return "maincolor3";
                break;
        }
        return "maincolor";
    }

    public enum ButtonColour
    {
        Blue,
        Purple,
        Green
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
