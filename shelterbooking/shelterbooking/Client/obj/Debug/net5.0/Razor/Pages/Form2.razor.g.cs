#pragma checksum "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14082c9c870244ccdd25660d54641c731c727df6"
// <auto-generated/>
#pragma warning disable 1591
namespace shelterbooking.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using shelterbooking.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using shelterbooking.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
    public partial class Form2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                  prop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group ");
                __builder2.OpenElement(8, "div");
                __builder2.AddMarkupContent(9, "<label>Properties-cvr_kode :</label>\n            ");
                __builder2.OpenElement(10, "div");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateInputNumber_0(__builder2, 11, 12, 
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                           prop.cvr_kode

#line default
#line hidden
#nullable disable
                , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.cvr_kode = __value, prop.cvr_kode)), 14, () => prop.cvr_kode);
                __builder2.AddMarkupContent(15, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_1(__builder2, 16, 17, 
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.cvr_kode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group ");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "<label>Properties-cvr_navn :</label>\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                         prop.cvr_navn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.cvr_navn = __value, prop.cvr_navn))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prop.cvr_navn));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_2(__builder2, 29, 30, 
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.cvr_navn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group ");
                __builder2.OpenElement(34, "div");
                __builder2.AddMarkupContent(35, "<label>Properties-kommunekode :</label>\n            ");
                __builder2.OpenElement(36, "div");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateInputNumber_3(__builder2, 37, 38, 
#nullable restore
#line 27 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                           prop.kommunekode

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.kommunekode = __value, prop.kommunekode)), 40, () => prop.kommunekode);
                __builder2.AddMarkupContent(41, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_4(__builder2, 42, 43, 
#nullable restore
#line 28 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.kommunekode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group ");
                __builder2.OpenElement(47, "div");
                __builder2.AddMarkupContent(48, "<label>Properties-navn :</label>\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                         prop.navn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.navn = __value, prop.navn))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prop.navn));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_5(__builder2, 55, 56, 
#nullable restore
#line 37 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.navn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group ");
                __builder2.OpenElement(60, "div");
                __builder2.AddMarkupContent(61, "<label>Properties-beskrivels :</label>\n            ");
                __builder2.OpenElement(62, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                         prop.beskrivels

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.beskrivels = __value, prop.beskrivels))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prop.beskrivels));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_6(__builder2, 68, 69, 
#nullable restore
#line 46 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.beskrivels

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group ");
                __builder2.OpenElement(73, "div");
                __builder2.AddMarkupContent(74, "<label>Properties-lang_beskr :</label>\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                         prop.lang_beskr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.lang_beskr = __value, prop.lang_beskr))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prop.lang_beskr));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_7(__builder2, 81, 82, 
#nullable restore
#line 55 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.lang_beskr

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group ");
                __builder2.OpenElement(86, "div");
                __builder2.AddMarkupContent(87, "<label>Properties-antal_pl :</label>\n            ");
                __builder2.OpenElement(88, "div");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateInputNumber_8(__builder2, 89, 90, 
#nullable restore
#line 63 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                           prop.antal_pl

#line default
#line hidden
#nullable disable
                , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.antal_pl = __value, prop.antal_pl)), 92, () => prop.antal_pl);
                __builder2.AddMarkupContent(93, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_9(__builder2, 94, 95, 
#nullable restore
#line 64 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.antal_pl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group ");
                __builder2.OpenElement(99, "div");
                __builder2.AddMarkupContent(100, "<label>Properties-ansvar_org :</label>\n            ");
                __builder2.OpenElement(101, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(102);
                __builder2.AddAttribute(103, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                         prop.ansvar_org

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.ansvar_org = __value, prop.ansvar_org))));
                __builder2.AddAttribute(105, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prop.ansvar_org));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_10(__builder2, 107, 108, 
#nullable restore
#line 73 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.ansvar_org

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n    ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "form-group ");
                __builder2.OpenElement(112, "div");
                __builder2.AddMarkupContent(113, "<label>Properties-ansva_v :</label>\n            ");
                __builder2.OpenElement(114, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(115);
                __builder2.AddAttribute(116, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                         prop.ansva_v

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(117, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prop.ansva_v = __value, prop.ansva_v))));
                __builder2.AddAttribute(118, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prop.ansva_v));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\n                ");
                __Blazor.shelterbooking.Client.Pages.Form2.TypeInference.CreateValidationMessage_11(__builder2, 120, 121, 
#nullable restore
#line 82 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
                                          () => prop.ansva_v

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\n    ");
                __builder2.OpenElement(123, "button");
                __builder2.AddAttribute(124, "type", "submit");
                __builder2.AddAttribute(125, "class", "btn btn-success");
                __builder2.AddContent(126, 
#nullable restore
#line 87 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
         ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Form2.razor"
       
    [Parameter] public Properties prop { get; set; }
    [Parameter] public Shelter shel { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.shelterbooking.Client.Pages.Form2
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
