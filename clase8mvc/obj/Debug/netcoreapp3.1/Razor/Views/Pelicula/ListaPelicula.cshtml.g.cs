#pragma checksum "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase8mvc\Views\Pelicula\ListaPelicula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0b27fde6982ca579deba5f89e5e3ab855c03f4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pelicula_ListaPelicula), @"mvc.1.0.view", @"/Views/Pelicula/ListaPelicula.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase8mvc\Views\_ViewImports.cshtml"
using clase8mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase8mvc\Views\_ViewImports.cshtml"
using clase8mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0b27fde6982ca579deba5f89e5e3ab855c03f4b", @"/Views/Pelicula/ListaPelicula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d37f639433278064a9c960e1812b5a000171eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Pelicula_ListaPelicula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Listar todas las peliculas existentes</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase8mvc\Views\Pelicula\ListaPelicula.cshtml"
 foreach (PeliculaModel item in (IList<PeliculaModel>) ViewData["PeliculaNombre"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Nombre ");
#nullable restore
#line 9 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase8mvc\Views\Pelicula\ListaPelicula.cshtml"
          Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , fecha de lanzamiento: ");
#nullable restore
#line 9 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase8mvc\Views\Pelicula\ListaPelicula.cshtml"
                                               Write(item.relese);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n");
#nullable restore
#line 10 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase8mvc\Views\Pelicula\ListaPelicula.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591