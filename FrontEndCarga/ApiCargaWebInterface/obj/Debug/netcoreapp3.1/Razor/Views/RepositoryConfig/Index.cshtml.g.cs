#pragma checksum "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c164e55f9761c095a22357bc196f03c6fa07c8ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RepositoryConfig_Index), @"mvc.1.0.view", @"/Views/RepositoryConfig/Index.cshtml")]
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
#line 1 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\_ViewImports.cshtml"
using ApiCargaWebInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\_ViewImports.cshtml"
using ApiCargaWebInterface.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c164e55f9761c095a22357bc196f03c6fa07c8ed", @"/Views/RepositoryConfig/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea611a92e380a82377bf0950bf072fffae47c15", @"/Views/_ViewImports.cshtml")]
    public class Views_RepositoryConfig_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiCargaWebInterface.ViewModels.RepositoryConfigViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
  
    ViewData["Title"] = "Repositorios";
    ViewData["BodyClass"] = "listado";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col col-12 col-lg-12 col-contenido"">
        <div class=""wrapCol"">
            <div class=""acciones-listado"">
                <div class=""wrap"">

                </div>
            </div>
            <div class=""resource-list compacView"">
                <div class=""wrap"">
                    <h1>Repositorios</h1>
");
#nullable restore
#line 19 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <article class=\"resource resource-ficharepositorio\">\r\n                            <div class=\"wrap\">\r\n                                <h2>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 807, "\"", 874, 1);
#nullable restore
#line 24 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
WriteAttributeValue("", 814, Url.Action("Details", new {  id=item.RepositoryConfigID  }), 814, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
                                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h2>\r\n                                <div class=\"desc\">\r\n                                    <p class=\"tipo\">");
#nullable restore
#line 27 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 28 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.OauthToken));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </article>\r\n");
#nullable restore
#line 32 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1394, "\"", 1422, 1);
#nullable restore
#line 35 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\Index.cshtml"
WriteAttributeValue("", 1401, Url.Action("Create"), 1401, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-mas-recursos\">\r\n                <i class=\"material-icons add\">add</i>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiCargaWebInterface.ViewModels.RepositoryConfigViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
