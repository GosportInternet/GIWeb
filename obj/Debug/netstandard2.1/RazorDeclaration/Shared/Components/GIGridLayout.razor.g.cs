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
    public partial class GIGridLayout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\George\Documents\GIWeb\Shared\Components\GIGridLayout.razor"
      

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public String CustomClass { get; set; }

    [Parameter]
    public string Width { get; set; } = "";

    [Parameter]
    public string Height { get; set; } = "";

    [Parameter]
    public Alignment Align { get; set; } = Alignment.Left;

    [Parameter]
    public bool Debug { get; set; } = false;

    private string GetAlignment()
    {
        switch (Align)
        {
            case Alignment.Left:
                return "float-left";
                break;
            case Alignment.Center:
                return "float-none";
                break;
            case Alignment.Right:
                return "float-right";
                break;
        }
        return "";
    }

    private string GetDebug()
    {
        if (Debug)
        {

            return "border-style:solid;border-width:1px;";
        }

        return "";
    }

    public enum Alignment
    {
        Center,
        Left,
        Right
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591