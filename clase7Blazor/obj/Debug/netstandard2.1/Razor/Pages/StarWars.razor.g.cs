#pragma checksum "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\StarWars.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2162be357e0acdd48c52fc0b7474f6eb4134bdb"
// <auto-generated/>
#pragma warning disable 1591
namespace clase7Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using clase7Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using clase7Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/starwar")]
    public partial class StarWars : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\StarWars.razor"
                 formulario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\StarWars.razor"
                                      recibirInfo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __Blazor.clase7Blazor.Pages.StarWars.TypeInference.CreateInputNumber_0(__builder2, 5, 6, "id", 7, "ingrese el id", 8, 
#nullable restore
#line 4 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\StarWars.razor"
                             formulario.id

#line default
#line hidden
#nullable disable
                , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formulario.id = __value, formulario.id)), 10, () => formulario.id);
                __builder2.AddMarkupContent(11, "\r\n    <input type=\"submit\" value=\"buscar!!!\">\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\StarWars.razor"
      
    public FormStar formulario = new FormStar();

    public async  void recibirInfo()
    {
        HttpClient http = new HttpClient();
        var resultado = await http.GetFromJsonAsync<Object>("https://swapi.dev/api/people/" + formulario.id + "/");

        Console.WriteLine(resultado);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.clase7Blazor.Pages.StarWars
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
