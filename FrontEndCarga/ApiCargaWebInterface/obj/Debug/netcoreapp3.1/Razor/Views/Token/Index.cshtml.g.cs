#pragma checksum "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e1b92eb8bf8172290c3751baed307d93c54bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Token_Index), @"mvc.1.0.view", @"/Views/Token/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e1b92eb8bf8172290c3751baed307d93c54bf1", @"/Views/Token/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea611a92e380a82377bf0950bf072fffae47c15", @"/Views/_ViewImports.cshtml")]
    public class Views_Token_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApiCargaWebInterface.ViewModels.GetTokenViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetToken", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
  

        ViewData["Title"] = "get token";

        ViewData["BodyClass"] = "formulario";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col col-12 col-lg-12 col-contenido\">\r\n        <div class=\"wrapCol\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96e1b92eb8bf8172290c3751baed307d93c54bf15072", async() => {
                WriteLiteral("\r\n                <div class=\"fieldset fieldset01\">\r\n                    <fieldset class=\"mediumLabels\">\r\n                        <h1>Obtener token</h1>\r\n                        <div class=\"fieldsetContent\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96e1b92eb8bf8172290c3751baed307d93c54bf15579", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 16 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label for=""token_Type"" class=""control-label""> Elige el tipo de token</label>
                                <select for=""token_Type"" id=""token_Type"" name=""token_Type"" class=""form-control"">
");
#nullable restore
#line 20 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
                                     foreach (var option in Model.TokenOptions)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96e1b92eb8bf8172290c3751baed307d93c54bf17982", async() => {
#nullable restore
#line 22 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
                                                               Write(option.Value);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
                                           WriteLiteral(option.Key);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""fieldset actionButtons fieldset03"">
                                <fieldset>
                                    <p>
                                        <input class=""submit principal"" type=""submit"" value=""obtener token"">
                                    </p>
                                </fieldset>
                            </div>
");
#nullable restore
#line 33 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
                             if (!string.IsNullOrEmpty(Model.Token))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"text text-info\" style=\"word-wrap: break-word;\">\r\n                                    ");
#nullable restore
#line 36 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
                               Write(Model.Token);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </p>\r\n");
#nullable restore
#line 38 "C:\Hercules\AutoGeneradorUris\UrisFactoryGit\GnossDeustoBackend\FrontEndCarga\ApiCargaWebInterface\Views\Token\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </fieldset>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApiCargaWebInterface.ViewModels.GetTokenViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591