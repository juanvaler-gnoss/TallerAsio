#pragma checksum "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4e35eefa977d341369882cfb886466ff473a3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Discover_DetailsRdf), @"mvc.1.0.view", @"/Views/Discover/DetailsRdf.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4e35eefa977d341369882cfb886466ff473a3d", @"/Views/Discover/DetailsRdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea611a92e380a82377bf0950bf072fffae47c15", @"/Views/_ViewImports.cshtml")]
    public class Views_Discover_DetailsRdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApiCargaWebInterface.ViewModels.DiscoverRdfViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
  
    ViewData["Title"] = "Discovery rdf";
    ViewData["BodyClass"] = "fichaRecurso detailsRdf";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col col-12 col-lg-12 col-contenido\">\r\n        <div class=\"wrapCol\">\r\n            <div class=\"header-resource\">\r\n                <div class=\"h1-container\">\r\n                    <h1>Rdf de ");
#nullable restore
#line 13 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                          Write(Context.Request.Query["itemId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <div class=\"contenido\">\r\n                <div class=\"grupo grupo-descripcion\">\r\n\r\n\r\n                    <div class=\"estado-tarea\">\r\n\r\n\r\n");
#nullable restore
#line 23 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                         foreach (var item in Model)
                        {
                            PintarItem(item);
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
 
    void PintarItem(ApiCargaWebInterface.ViewModels.DiscoverRdfViewModel pItem)
    {

#line default
#line hidden
#nullable disable
        WriteLiteral("        <table class=\"rdftable\">\r\n            <thead class=\"table-subject\">\r\n                <tr>\r\n");
#nullable restore
#line 42 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                     if (pItem.LoadedEntities.Contains(pItem.uriEntity))
                    {

#line default
#line hidden
#nullable disable
        WriteLiteral("                        <th colspan=\"2\"><span class=\"entityHeader\"");
        BeginWriteAttribute("id", " id=\"", 1261, "\"", 1282, 1);
#nullable restore
#line 44 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 1266, pItem.uriEntity, 1266, 16, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral("></span><span");
        BeginWriteAttribute("id", " id=\"", 1296, "\"", 1317, 1);
#nullable restore
#line 44 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 1301, pItem.uriEntity, 1301, 16, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">");
#nullable restore
#line 44 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                                                                                                       Write(pItem.uriEntity);

#line default
#line hidden
#nullable disable
        WriteLiteral("</span><a");
        BeginWriteAttribute("href", " href=\"", 1344, "\"", 1367, 1);
#nullable restore
#line 44 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 1351, pItem.uriEntity, 1351, 16, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(" target=\"_blank\"><span class=\"linkext\">&nbsp;&nbsp;&nbsp;&nbsp;</span></a></th>\r\n");
#nullable restore
#line 45 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
        WriteLiteral("                        <th colspan=\"2\"><span class=\"entityHeader\"");
        BeginWriteAttribute("id", " id=\"", 1587, "\"", 1608, 1);
#nullable restore
#line 48 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 1592, pItem.uriEntity, 1592, 16, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral("></span><span");
        BeginWriteAttribute("id", " id=\"", 1622, "\"", 1643, 1);
#nullable restore
#line 48 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 1627, pItem.uriEntity, 1627, 16, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">");
#nullable restore
#line 48 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                                                                                                       Write(pItem.uriEntity);

#line default
#line hidden
#nullable disable
        WriteLiteral("</span></th>\r\n");
#nullable restore
#line 49 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                    }

#line default
#line hidden
#nullable disable
        WriteLiteral("                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 54 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                 foreach (var stringProperty in pItem.stringPropertiesEntity)
                {
                    foreach (var valor in stringProperty.Value)
                    {
                        string propiedadAbreviada = stringProperty.Key;
                        if (propiedadAbreviada.Contains("/"))
                        {
                            propiedadAbreviada = propiedadAbreviada.Substring(propiedadAbreviada.LastIndexOf("/") + 1);
                        }

#line default
#line hidden
#nullable disable
        WriteLiteral("                        <tr>\r\n");
#nullable restore
#line 64 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                              
                                String title = "";
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                             if (pItem.communNamePropierties.ContainsKey(stringProperty.Key))
                            {
                                title = pItem.communNamePropierties[stringProperty.Key];
                            }

#line default
#line hidden
#nullable disable
        WriteLiteral("                            <td");
        BeginWriteAttribute("class", " class=\"", 2686, "\"", 2694, 0);
        EndWriteAttribute();
        BeginWriteAttribute("title", " title=\"", 2695, "\"", 2709, 1);
#nullable restore
#line 71 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 2703, title, 2703, 6, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">\r\n                                <b>");
#nullable restore
#line 72 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                              Write(propiedadAbreviada);

#line default
#line hidden
#nullable disable
        WriteLiteral("</b>\r\n                                <a");
        BeginWriteAttribute("href", " href=\"", 2807, "\"", 2833, 1);
#nullable restore
#line 73 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 2814, stringProperty.Key, 2814, 19, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(" target=\"_blank\"><span class=\"linkext\">&nbsp;&nbsp;&nbsp;&nbsp;</span></a>\r\n                            </td>\r\n\r\n");
#nullable restore
#line 76 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                             if (pItem.urisRdf.Contains(valor))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                 if (pItem.LoadedEntities.Contains(valor))
                                {

#line default
#line hidden
#nullable disable
        WriteLiteral("                                    <td>\r\n                                        <a");
        BeginWriteAttribute("href", " href=\"", 3238, "\"", 3252, 2);
        WriteAttributeValue("", 3245, "#", 3245, 1, true);
#nullable restore
#line 81 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 3246, valor, 3246, 6, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">\r\n                                            ");
#nullable restore
#line 82 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                       Write(valor);

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n                                        </a>\r\n                                        <a");
        BeginWriteAttribute("href", " href=\"", 3396, "\"", 3409, 1);
#nullable restore
#line 84 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 3403, valor, 3403, 6, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(" target=\"_blank\"><span class=\"linkext\">&nbsp;&nbsp;&nbsp;&nbsp;</span></a>\r\n                                    </td>\r\n");
#nullable restore
#line 86 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
        WriteLiteral("                                    <td>\r\n                                        <a");
        BeginWriteAttribute("href", " href=\"", 3721, "\"", 3735, 2);
        WriteAttributeValue("", 3728, "#", 3728, 1, true);
#nullable restore
#line 90 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 3729, valor, 3729, 6, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">\r\n                                            ");
#nullable restore
#line 91 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                       Write(valor);

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n                                        </a>\r\n                                    </td>\r\n");
#nullable restore
#line 94 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                 

                            }
                            else
                            {
                                if (stringProperty.Key == "http://www.w3.org/1999/02/22-rdf-syntax-ns#type")
                                {
                                    title = "";

                                    if (pItem.communNamePropierties.ContainsKey(stringProperty.Key))
                                    {
                                        title = pItem.communNamePropierties[stringProperty.Key];
                                    }

                                    string valorPropiedadAbreviada = valor;
                                    if (valorPropiedadAbreviada.Contains("/"))
                                    {
                                        valorPropiedadAbreviada = valorPropiedadAbreviada.Substring(valorPropiedadAbreviada.LastIndexOf("/") + 1);
                                    }

#line default
#line hidden
#nullable disable
        WriteLiteral("                                    <td");
        BeginWriteAttribute("title", " title=\"", 4911, "\"", 4925, 1);
#nullable restore
#line 113 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 4919, title, 4919, 6, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral("><b>");
#nullable restore
#line 113 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                                     Write(valorPropiedadAbreviada);

#line default
#line hidden
#nullable disable
        WriteLiteral("</b></td>\r\n");
#nullable restore
#line 114 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
        WriteLiteral("                                    <td><b>");
#nullable restore
#line 117 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                      Write(valor);

#line default
#line hidden
#nullable disable
        WriteLiteral("</b></td>\r\n");
#nullable restore
#line 118 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 123 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                 foreach (var entitiesProperty in pItem.entitiesPropertiesEntity)
                {
                    foreach (var valor in entitiesProperty.Value)
                    {
                        string propiedadAbreviada = entitiesProperty.Key;
                        if (propiedadAbreviada.Contains("/"))
                        {
                            propiedadAbreviada = propiedadAbreviada.Substring(propiedadAbreviada.LastIndexOf("/") + 1);
                        }
                        String title = "";

                        if (pItem.communNamePropierties.ContainsKey(entitiesProperty.Key))
                        {
                            title = pItem.communNamePropierties[entitiesProperty.Key];
                        }

#line default
#line hidden
#nullable disable
        WriteLiteral("                        <tr>\r\n                            <td");
        BeginWriteAttribute("class", " class=\"", 6122, "\"", 6130, 0);
        EndWriteAttribute();
        BeginWriteAttribute("title", " title=\"", 6131, "\"", 6145, 1);
#nullable restore
#line 141 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
WriteAttributeValue("", 6139, title, 6139, 6, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(">\r\n                                <b>");
#nullable restore
#line 142 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                              Write(propiedadAbreviada);

#line default
#line hidden
#nullable disable
        WriteLiteral("</b>\r\n                            </td>\r\n                            <td");
        BeginWriteAttribute("class", " class=\"", 6275, "\"", 6283, 0);
        EndWriteAttribute();
        WriteLiteral(">\r\n");
#nullable restore
#line 145 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                                  
                                    PintarItem(valor);
                                

#line default
#line hidden
#nullable disable
        WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 150 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
        WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 156 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Discover\DetailsRdf.cshtml"
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApiCargaWebInterface.ViewModels.DiscoverRdfViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
