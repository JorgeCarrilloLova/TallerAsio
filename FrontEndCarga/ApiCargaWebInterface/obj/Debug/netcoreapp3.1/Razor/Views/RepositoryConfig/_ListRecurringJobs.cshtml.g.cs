#pragma checksum "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac959c422041a6a5582bff527aa523702be5d424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RepositoryConfig__ListRecurringJobs), @"mvc.1.0.view", @"/Views/RepositoryConfig/_ListRecurringJobs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac959c422041a6a5582bff527aa523702be5d424", @"/Views/RepositoryConfig/_ListRecurringJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea611a92e380a82377bf0950bf072fffae47c15", @"/Views/_ViewImports.cshtml")]
    public class Views_RepositoryConfig__ListRecurringJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiCargaWebInterface.ViewModels.RecurringJobViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
 if (Model != null && Model.Count() > 0)
{
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""items tabla"">
        <div class=""cabecera"">
            <div class=""columna"">
                <p>Nombre</p>
            </div>
            <div class=""columna"">
                <p>Proxima ejecución</p>
            </div>
            <div class=""columna"">
                <p>Expresión cron</p>
            </div>
            <div class=""columna acciones"">
                <p>Acciones</p>
            </div>
        </div>
");
#nullable restore
#line 21 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
         foreach (var recurringJob in Model)
        {
            string idModal = $"modalEliminar{i}";
            string target = $"#{idModal}";
            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"fila\">\r\n                <div class=\"columna principal\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 864, "\"", 943, 1);
#nullable restore
#line 28 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
WriteAttributeValue("", 871, Url.Action("DetailsRecurringJob", "Job",new { name = recurringJob.Id }), 871, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <p>");
#nullable restore
#line 29 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
                      Write(recurringJob.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </a>\r\n                </div>\r\n                <div class=\"columna\">\r\n                    <p>");
#nullable restore
#line 33 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
                  Write(recurringJob.NextExecution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"columna\">\r\n                    <p>");
#nullable restore
#line 36 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
                  Write(recurringJob.Cron);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"columna acciones\">\r\n                    <ul>\r\n");
            WriteLiteral("                        <li>\r\n                            <a href=\"javascript: void(0);\" class=\"borrar\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 51 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
                                                                                                      Write(target);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <i class=""material-icons"">delete</i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""modal fade top-modal eliminar""");
            BeginWriteAttribute("id", " id=\"", 2350, "\"", 2363, 1);
#nullable restore
#line 58 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
WriteAttributeValue("", 2355, idModal, 2355, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2392, "\"", 2410, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">Eliminar</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">×</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            <div style=""display: block;"" id=""despAccionRec"">
                                <div style=""display: block;"" class=""stateShowForm"" id=""panels"">
                                    <div class=""loading"" id=""loading"" style=""display: none;"">
                                        <p>Cargando formulario, un momento por favor</p>
                                    </div>
                                    <div id=""menssage");
            WriteLiteral(@"s"" style=""display: none;"">
                                        <div class=""ok""></div>
                                        <div class=""ko""></div>
                                    </div>
                                    <div class=""box form activeForm"" id=""action"" style=""display: block;"">
                                        <div>
                                            <fieldset>
                                                <legend>¿Está seguro que quiere eliminar la tarea recurrente?</legend>
                                                <div id=""eliminar"">
                                                    <p>
                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4149, "\"", 4231, 1);
#nullable restore
#line 83 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
WriteAttributeValue("", 4156, Url.Action("Delete", "Job", new {  id=recurringJob.Id, job="recurring"  }), 4156, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><input type=\"text\" class=\"button btn-principal\" value=\"Eliminar\"></a>\r\n");
            WriteLiteral(@"                                                        <input type=""button"" value=""Cancelar"" data-dismiss=""modal"">
                                                    </p>
                                                </div>
                                            </fieldset>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 97 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 100 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\RepositoryConfig\_ListRecurringJobs.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiCargaWebInterface.ViewModels.RecurringJobViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591