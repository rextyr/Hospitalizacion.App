#pragma checksum "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\Signos\ListaSignos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49e4d58fde30d772f4a1ce61432cc16708e728b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hospitalizacion.App.FrontEnd.Pages.Signos.Pages_Signos_ListaSignos), @"mvc.1.0.razor-page", @"/Pages/Signos/ListaSignos.cshtml")]
namespace Hospitalizacion.App.FrontEnd.Pages.Signos
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
#line 1 "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\_ViewImports.cshtml"
using Hospitalizacion.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49e4d58fde30d772f4a1ce61432cc16708e728b", @"/Pages/Signos/ListaSignos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5de120e790778254a761ad29ee2faf478bdf72", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Signos_ListaSignos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Lista de Registros</h1>

<table class=""table"">
  <thead>
      <tr>
         <th scope=""col"">Registro del Signo</th> 
         <th scope=""col"">Tipo de Signo</th> 
         <th scope=""col"">Valor</th> 
         <th scope=""col"">Id de MascotaEnferma</th> 
      </tr>
  </thead>

");
#nullable restore
#line 17 "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\Signos\ListaSignos.cshtml"
   foreach (var signos in @Model.SignosVitalesl)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n          <td>");
#nullable restore
#line 20 "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\Signos\ListaSignos.cshtml"
         Write(signos.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 21 "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\Signos\ListaSignos.cshtml"
         Write(signos.Signo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 22 "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\Signos\ListaSignos.cshtml"
         Write(signos.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("/td>\r\n          <td>");
#nullable restore
#line 23 "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\Signos\ListaSignos.cshtml"
         Write(signos.MascotaEnfermaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td></td>\r\n      </tr>\r\n");
#nullable restore
#line 26 "C:\Prueba2\Hospitalizacion.App\Hospitalizacion.App.FrontEnd\Pages\Signos\ListaSignos.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospimascotas.App.Frontend.Pages.ListaSignosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hospimascotas.App.Frontend.Pages.ListaSignosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hospimascotas.App.Frontend.Pages.ListaSignosModel>)PageContext?.ViewData;
        public Hospimascotas.App.Frontend.Pages.ListaSignosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
