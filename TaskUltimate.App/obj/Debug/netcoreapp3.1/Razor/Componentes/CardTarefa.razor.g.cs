#pragma checksum "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81b40b50f8cdf0467f7621084e1bdba5162c29f8"
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
#line 1 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Componentes;

#line default
#line hidden
#nullable disable
    public partial class CardTarefa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .inserir {
        box-shadow: 0 0 0 0;
        border: 0 none;
        outline: 0;
        background-color: rgba(43, 45, 66, .2);
        border-radius: 3px;
    }

    .filho {
        padding-right: 20px;
    }

    .draggable {
        border: 1px solid #ccc;
        border-radius: 5px;
        margin: 1rem;
        padding: 1rem;
        display: inline-block;
        cursor: move;
    }
</style>

");
            __builder.OpenComponent<TaskUltimate.App.Shared.DropTarget<Tarefa>>(1);
            __builder.AddAttribute(2, "Drop", new System.Action<Tarefa>(
#nullable restore
#line 26 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                               async (data) => await OnDrop(data)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "drop-target");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __Blazor.TaskUltimate.App.Componentes.CardTarefa.TypeInference.CreateDraggable_0(__builder2, 8, 9, 
#nullable restore
#line 29 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                          tarefa

#line default
#line hidden
#nullable disable
                , 10, (__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n            ");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "draggable");
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "table");
                    __builder3.AddMarkupContent(17, "\r\n                    ");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "row");
                    __builder3.AddMarkupContent(20, "\r\n                        ");
                    __builder3.OpenElement(21, "div");
                    __builder3.AddAttribute(22, "class", "col-auto");
                    __builder3.AddMarkupContent(23, "\r\n                            ");
                    __builder3.AddMarkupContent(24, "<label for=\"tarefaNome\">Nome:</label>\r\n                            ");
                    __builder3.OpenElement(25, "input");
                    __builder3.AddAttribute(26, "type", "text");
                    __builder3.AddAttribute(27, "id", "tarefaNome");
                    __builder3.AddAttribute(28, "class", "inserir");
                    __builder3.AddAttribute(29, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                                                                            async () => { await Atualizar(); }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                       tarefa.TarefaNome

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tarefa.TarefaNome = __value, tarefa.TarefaNome));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                    ");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "row");
                    __builder3.AddMarkupContent(37, "\r\n                        ");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "col-auto");
                    __builder3.AddMarkupContent(40, "\r\n                            ");
                    __builder3.AddMarkupContent(41, "<label for=\"dataLimite\">Entregar:</label>\r\n                            ");
                    __builder3.OpenElement(42, "input");
                    __builder3.AddAttribute(43, "id", "dataLimite");
                    __builder3.AddAttribute(44, "type", "date");
                    __builder3.AddAttribute(45, "class", "inserir");
                    __builder3.AddAttribute(46, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                                                                                  async () => { await Atualizar(); }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                       tarefa.TarefaDatalimite

#line default
#line hidden
#nullable disable
                    , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(48, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tarefa.TarefaDatalimite = __value, tarefa.TarefaDatalimite, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n\r\n                        ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-auto");
                    __builder3.AddMarkupContent(53, "\r\n                            ");
                    __builder3.AddMarkupContent(54, "<label for=\"tarefaEstado\">Feito:</label>\r\n                            ");
                    __builder3.OpenElement(55, "input");
                    __builder3.AddAttribute(56, "id", "tarefaEstado");
                    __builder3.AddAttribute(57, "type", "checkbox");
                    __builder3.AddAttribute(58, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                                                                    async () => { await Atualizar(); }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                             tarefa.TarefaEstado

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tarefa.TarefaEstado = __value, tarefa.TarefaEstado));
                    __builder3.SetUpdatesAttributeName("checked");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n\r\n                        ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "col-auto");
                    __builder3.AddMarkupContent(65, "\r\n                            ");
                    __builder3.AddMarkupContent(66, "<label for=\"utilizadorIdatribuido\">Resposnsavel:</label>\r\n                            ");
                    __builder3.OpenElement(67, "input");
                    __builder3.AddAttribute(68, "id", "utilizadorIdatribuido");
                    __builder3.AddAttribute(69, "type", "number");
                    __builder3.AddAttribute(70, "class", "inserir");
                    __builder3.AddAttribute(71, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                                                                                                    async () => { await Atualizar(); }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                                    tarefa.UtilizadorIdatribuido

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(73, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tarefa.UtilizadorIdatribuido = __value, tarefa.UtilizadorIdatribuido, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n\r\n                        ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-auto");
                    __builder3.AddMarkupContent(78, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(79);
                    __builder3.AddAttribute(80, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                  () =>Alterar()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(81, "Text", "Alterar");
                    __builder3.AddAttribute(82, "Style", "background-color: #DE8A02; ");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                    __builder3.AddAttribute(85, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                  () => Confirmar()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(86, "Text", "Deletar");
                    __builder3.AddAttribute(87, "Style", "background-color:darkred;");
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(89, "\r\n                                Deletar\r\n                                ");
                        __builder4.AddMarkupContent(90, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash"" viewBox=""0 0 16 16"">
                                    <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z""></path>
                                    <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z""></path>
                                </svg>
                            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(92);
                    __builder3.AddAttribute(93, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                  () => AdicionarFilho()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(94, "Text", "Adicionar filho");
                    __builder3.AddAttribute(95, "Style", "background-color:darkred;");
                    __builder3.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(97, "\r\n                                ");
                        __builder4.AddMarkupContent(98, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-plus-square"" viewBox=""0 0 16 16"">
                                    <path d=""M14 1a1 1 0 0 1 1 1v12a1 1 0 0 1-1 1H2a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h12zM2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z""></path>
                                    <path d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z""></path>
                                </svg>
                            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(100);
                    __builder3.AddAttribute(101, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                  () => MostrarFilho()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(102, "Text", "Mostrar Filho");
                    __builder3.AddAttribute(103, "Style", "background-color:darkred;");
                    __builder3.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(105, "\r\n");
#nullable restore
#line 72 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                 if (renderFilho)
                                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(106, "                                    ");
                        __builder4.AddMarkupContent(107, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-chevron-down"" viewBox=""0 0 16 16"">
                                        <path fill-rule=""evenodd"" d=""M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z""></path>
                                    </svg>
");
#nullable restore
#line 77 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(108, "                                    ");
                        __builder4.AddMarkupContent(109, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-chevron-up"" viewBox=""0 0 16 16"">
                                        <path fill-rule=""evenodd"" d=""M7.646 4.646a.5.5 0 0 1 .708 0l6 6a.5.5 0 0 1-.708.708L8 5.707l-5.646 5.647a.5.5 0 0 1-.708-.708l6-6z""></path>
                                    </svg>
");
#nullable restore
#line 83 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(110, "                            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\r\n        ");
                }
                );
                __builder2.AddMarkupContent(116, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(118, "\r\n\r\n");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "container filho");
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 94 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
     if (tarefa.TarefaTemfilho & renderFilho)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
         foreach (Tarefa elemento in filhos)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "            ");
            __builder.OpenComponent<TaskUltimate.App.Componentes.CardTarefa>(123);
            __builder.AddAttribute(124, "tarefa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TaskUltimate.Models.Tarefa>(
#nullable restore
#line 98 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                elemento

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n");
#nullable restore
#line 99 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
       
    [Parameter]
    public Tarefa tarefa { get; set; } = new Tarefa();
    public Tarefa filho { get; set; } = new Tarefa();
    public List<Tarefa> filhos { get; set; } = new List<Tarefa>();
    private bool renderFilho { get; set; }

    public async Task Alterar()
    {
        await dialogService.OpenAsync<FormTarefa>("Modificar Tarefa", new Dictionary<string, object> { { "tarefa", tarefa }, { "Sub", true } }, new DialogOptions() { Style = "min-height:auto;min-width:auto;width:auto" });
        StateHasChanged();
    }
    public async Task Confirmar()
    {
        var result = await dialogService.OpenAsync("Simple Dialog", ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(126, "div");
            __builder2.AddMarkupContent(127, "\r\n        ");
            __builder2.AddMarkupContent(128, "<p Style=\"margin-bottom: 1rem\">Confirm?</p>\r\n        ");
            __builder2.OpenElement(129, "div");
            __builder2.AddAttribute(130, "class", "row");
            __builder2.AddMarkupContent(131, "\r\n            ");
            __builder2.OpenElement(132, "div");
            __builder2.AddAttribute(133, "class", "col-md-12");
            __builder2.AddMarkupContent(134, "\r\n                ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(135);
            __builder2.AddAttribute(136, "Text", "Ok");
            __builder2.AddAttribute(137, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                               async () => { await Deletar();ds.Close(true); }

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(138, "Style", "margin-bottom: 10px; width: 150px");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(139, "\r\n                ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(140);
            __builder2.AddAttribute(141, "Text", "Cancel");
            __builder2.AddAttribute(142, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                   () => ds.Close(false)

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(143, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 123 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
                                                                                       ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(144, "Style", "margin-bottom: 10px; width: 150px");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(145, "\r\n            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(146, "\r\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(147, "\r\n    ");
            __builder2.CloseElement();
        }
#nullable restore
#line 126 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Componentes\CardTarefa.razor"
          , new DialogOptions() { Style = "min-height:auto;min-width:auto;width:auto" });
  StateHasChanged();
}

public async Task Deletar()
{
  await apiTarefa.Delete(tarefa.TarefaId);
  StateHasChanged();
}

private async Task Atualizar()
{
  await apiTarefa.PutAsync(tarefa.TarefaId, tarefa);
  StateHasChanged();
}

private async Task AdicionarFilho()
{
  filho.UtilizadorIdatribuido = tarefa.UtilizadorIdatribuido;
  await dialogService.OpenAsync<FormTarefa>("Adicionar Filho", new Dictionary<string, object> { { "tarefa", filho }, { "Parente", tarefa }, { "Descendente", true } }, new DialogOptions() { Style = "min-height:auto;min-width:auto;width:auto" });
  StateHasChanged();
}

protected override async Task OnInitializedAsync()
{
  if (tarefa.TarefaTemfilho)
      filhos = await apiService.apiTarefa.GetFilho(tarefa.TarefaId);
}

private void MostrarFilho()
{
  if (renderFilho)
      renderFilho = false;
  else
      renderFilho = true;
}

public async Task OnDrop(Tarefa data)
{
  data.ProjetoId = tarefa.ProjetoId;
  await apiService.apiTarefa.InsertAsync(data.TarefaId, tarefa.TarefaPosicao, data);
  // Important: Invoke StateHasChanged() to update the page
  StateHasChanged();
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskUltimate.App.Services.Apiservice apiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskUltimate.App.Services.ApiTarefa apiTarefa { get; set; }
    }
}
namespace __Blazor.TaskUltimate.App.Componentes.CardTarefa
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDraggable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::TaskUltimate.App.Componentes.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
