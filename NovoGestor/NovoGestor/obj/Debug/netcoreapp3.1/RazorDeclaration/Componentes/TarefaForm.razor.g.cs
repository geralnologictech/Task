// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NovoGestor.Componentes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor.Componentes;

#line default
#line hidden
#nullable disable
    public partial class TarefaForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
      
    [Parameter]
    public Tarefa tarefa { get; set; }

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    public bool selecionado = false;

    private void Selecionar(MouseEventArgs mouseEventArgs)
    {
        if (!selecionado)
        {
            selecionado = true;
        }
        else
        {
            selecionado = false;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NovoGestor.Services.ApiService apiService { get; set; }
    }
}
#pragma warning restore 1591
