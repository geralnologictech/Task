#pragma checksum "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\Componentes\Draggable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb998737a0b86a51b375a61013dec57f31cde4f"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskUltimate.App.Componentes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using TaskUltimate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Componentes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\Componentes\Draggable.razor"
using TaskUltimate.App.Data;

#line default
#line hidden
#nullable disable
    public partial class Draggable<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "draggable", "true");
            __builder.AddAttribute(2, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\Componentes\Draggable.razor"
                                     OnDragStart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 5 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\Componentes\Draggable.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\NoLogicTech\source\repos\TaskUltimate\TaskUltimate.App\Componentes\Draggable.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Zone { get; set; }

    [Parameter]
    public T Data { get; set; }

    void OnDragStart()
    {
        // Notify the DragAndDropService what the current Data and Zone are.
        DragAndDropService.StartDrag(Data, Zone);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DragAndDropService DragAndDropService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskUltimate.App.Services.ApiTarefa apiTarefa { get; set; }
    }
}
#pragma warning restore 1591
