#pragma checksum "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5f4b0bef4cad7c618d266717e52bbc1e305fc22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adm_Historico), @"mvc.1.0.view", @"/Views/Adm/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adm/Historico.cshtml", typeof(AspNetCore.Views_Adm_Historico))]
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
#line 1 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5f4b0bef4cad7c618d266717e52bbc1e305fc22", @"/Views/Adm/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Adm_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 66, true);
            WriteLiteral("\r\n    <main class=\"flex geral\">\r\n        <div class=\"flex icon-2\">");
            EndContext();
            BeginContext(115, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5f4b0bef4cad7c618d266717e52bbc1e305fc223918", async() => {
                BeginContext(158, 42, true);
                WriteLiteral("<i class=\"back fas fa-backward fa-2x\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(204, 737, true);
            WriteLiteral(@"</div>
        <div class=""flex cima "">
            <h1>Historico Geral</h1>
        </div>

        <section>
            <table>
                <thead>
                    <tr>
                        <th>Nome do Evento</th>
                        <th>Data</th>
                        <th>Email CLiente</th>
                        <th>Serviços</th>
                        <th>Tipo</th>
                        <th>Quantidade</th>
                        <th>Pagamento</th>
                        <th>Status</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""8"">
                            <p>Eventos atualizados em ");
            EndContext();
            BeginContext(942, 12, false);
#line 26 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(954, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                     foreach (var e in Model.Eventos)
                    {

#line default
#line hidden
            BeginContext(1147, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1210, 12, false);
#line 34 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                           Write(e.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1222, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1262, 13, false);
#line 35 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                           Write(e.DiaDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1315, 15, false);
#line 36 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                           Write(e.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1330, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1370, 15, false);
#line 37 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                           Write(e.Servicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1385, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1425, 12, false);
#line 38 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                           Write(e.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1437, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1477, 12, false);
#line 39 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                           Write(e.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1489, 48, true);
            WriteLiteral("</td>\r\n                            <td>  </td>\r\n");
            EndContext();
#line 41 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                             if(e.Status == 0){

#line default
#line hidden
            BeginContext(1586, 51, true);
            WriteLiteral("                                <td>Pendente</td>\r\n");
            EndContext();
#line 43 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                            }

#line default
#line hidden
            BeginContext(1668, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 44 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                             if(e.Status == 1)
                            {

#line default
#line hidden
            BeginContext(1747, 51, true);
            WriteLiteral("                                <td>Aprovado</td>\r\n");
            EndContext();
#line 47 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                            }

#line default
#line hidden
            BeginContext(1829, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 48 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                             if(e.Status == 2){

#line default
#line hidden
            BeginContext(1878, 52, true);
            WriteLiteral("                                <td>Reprovado</td>\r\n");
            EndContext();
#line 50 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                            }

#line default
#line hidden
            BeginContext(1961, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 51 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                             if (e.Status == 3)
                            {

#line default
#line hidden
            BeginContext(2041, 50, true);
            WriteLiteral("                                <td>Apagado</td>\r\n");
            EndContext();
#line 54 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                            }

#line default
#line hidden
            BeginContext(2122, 51, true);
            WriteLiteral("                        </tr>                    \r\n");
            EndContext();
#line 56 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Historico.cshtml"
                    }

#line default
#line hidden
            BeginContext(2196, 79, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </section>\r\n    </main>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591