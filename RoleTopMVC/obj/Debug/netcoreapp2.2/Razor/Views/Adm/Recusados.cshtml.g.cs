#pragma checksum "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb35c425a9ca6f32b02bbcbf1b048d243c71a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adm_Recusados), @"mvc.1.0.view", @"/Views/Adm/Recusados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adm/Recusados.cshtml", typeof(AspNetCore.Views_Adm_Recusados))]
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
#line 1 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb35c425a9ca6f32b02bbcbf1b048d243c71a6a", @"/Views/Adm/Recusados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Adm_Recusados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pendentes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aprovados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recusados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 65, true);
            WriteLiteral("<main class=\"flex tabela tab\">\r\n        <div class=\"flex icon-2\">");
            EndContext();
            BeginContext(114, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb35c425a9ca6f32b02bbcbf1b048d243c71a6a4800", async() => {
                BeginContext(157, 42, true);
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
            BeginContext(203, 206, true);
            WriteLiteral("</div>\r\n        <div class=\"flex cima \">\r\n            <h1>DashBoard</h1>\r\n        </div>\r\n        <section class=\"flex central-container\">\r\n\r\n            <div class=\"flex event-container\">\r\n                ");
            EndContext();
            BeginContext(409, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb35c425a9ca6f32b02bbcbf1b048d243c71a6a6639", async() => {
                BeginContext(456, 172, true);
                WriteLiteral("\r\n                    <div class=\"flex pend-container\">\r\n                        <img src=\"../img/icones/Adm/copy.png\" alt=\"\">\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(632, 79, true);
            WriteLiteral("\r\n                <h2>Pendentes</h2>\r\n                <br>\r\n                <p>");
            EndContext();
            BeginContext(712, 22, false);
#line 17 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
              Write(Model.EventosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(734, 108, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"flex event-container\">\r\n                ");
            EndContext();
            BeginContext(842, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb35c425a9ca6f32b02bbcbf1b048d243c71a6a8937", async() => {
                BeginContext(889, 192, true);
                WriteLiteral("\r\n                    <div class=\"flex check-container\">\r\n                        <img src=\"../img/icones/Adm/check_box_black_192x192.png\" alt=\"\">\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1085, 79, true);
            WriteLiteral("\r\n                <h2>Aprovados</h2>\r\n                <br>\r\n                <p>");
            EndContext();
            BeginContext(1165, 22, false);
#line 28 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
              Write(Model.EventosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 108, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"flex event-container\">\r\n                ");
            EndContext();
            BeginContext(1295, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb35c425a9ca6f32b02bbcbf1b048d243c71a6a11259", async() => {
                BeginContext(1342, 175, true);
                WriteLiteral("\r\n                    <div class=\"flex black-container\">\r\n                        <img src=\"../img/icones/Adm/recuse.png\" alt=\"\">\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1521, 79, true);
            WriteLiteral("\r\n                <h2>Recusados</h2>\r\n                <br>\r\n                <p>");
            EndContext();
            BeginContext(1601, 23, false);
#line 39 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
              Write(Model.EventosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 721, true);
            WriteLiteral(@"
                </p>
            </div>
        </section>
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
                        <th colspan=""2"">Readimitir</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""8"">
                            <p>Eventos atualizados em ");
            EndContext();
            BeginContext(2346, 12, false);
#line 61 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(2358, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 66 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                     foreach (var e in Model.Eventos)
                    {
                        if ((e.Status == 2))
                        {

#line default
#line hidden
            BeginContext(2624, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2695, 12, false);
#line 71 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                               Write(e.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2707, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2751, 13, false);
#line 72 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                               Write(e.DiaDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2764, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2808, 15, false);
#line 73 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                               Write(e.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2823, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2867, 15, false);
#line 74 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                               Write(e.Servicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2882, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2926, 12, false);
#line 75 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                               Write(e.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2938, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2982, 12, false);
#line 76 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                               Write(e.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(2994, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 77 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                                 if (e.Pago)
                                {

#line default
#line hidden
            BeginContext(3082, 69, true);
            WriteLiteral("                                    <td class=\"aprovado\">Pagou</td>\r\n");
            EndContext();
#line 80 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3259, 72, true);
            WriteLiteral("                                    <td class=\"pendente\">Pendente</td>\r\n");
            EndContext();
#line 84 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                                }

#line default
#line hidden
            BeginContext(3366, 51, true);
            WriteLiteral("                                <td class=\"read\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3417, "\'", 3474, 1);
#line 85 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
WriteAttributeValue("", 3424, Url.Action("Readimitir", "Adm", new {id = @e.Id}), 3424, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3475, 75, true);
            WriteLiteral("><i class=\"fas fa-reply\"></i></a></td>\r\n                            </tr>\r\n");
            EndContext();
#line 87 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Adm\Recusados.cshtml"
                            
                        }
                    }

#line default
#line hidden
            BeginContext(3630, 79, true);
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
