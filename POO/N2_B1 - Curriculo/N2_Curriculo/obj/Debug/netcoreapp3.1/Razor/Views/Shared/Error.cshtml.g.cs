#pragma checksum "C:\Users\Lucas\Downloads\N2_B1 - Curriculo\N2_Curriculo\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bb04c48d828e1e64084f6d3f43eec192b93d046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Lucas\Downloads\N2_B1 - Curriculo\N2_Curriculo\Views\_ViewImports.cshtml"
using N2_Curriculo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Downloads\N2_B1 - Curriculo\N2_Curriculo\Views\_ViewImports.cshtml"
using N2_Curriculo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb04c48d828e1e64084f6d3f43eec192b93d046", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee761c2a725536a28f0d2343fca5630af5c2ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lucas\Downloads\N2_B1 - Curriculo\N2_Curriculo\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Erro";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"text-danger\">Um erro ocorreu durante o processamento da sua requisição. </h2>\r\n<br />\r\n<p>\r\n    <strong>Detalhes do erro: </strong> <code> ");
#nullable restore
#line 8 "C:\Users\Lucas\Downloads\N2_B1 - Curriculo\N2_Curriculo\Views\Shared\Error.cshtml"
                                          Write(Model.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </code>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
