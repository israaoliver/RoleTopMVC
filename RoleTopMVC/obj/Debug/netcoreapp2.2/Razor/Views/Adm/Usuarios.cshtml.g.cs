#pragma checksum "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e077a8d92c3ec4e6de082104b12c439abe01d020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adm_Usuarios), @"mvc.1.0.view", @"/Views/Adm/Usuarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adm/Usuarios.cshtml", typeof(AspNetCore.Views_Adm_Usuarios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e077a8d92c3ec4e6de082104b12c439abe01d020", @"/Views/Adm/Usuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Adm_Usuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.AdmViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UsuariosBan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 58, true);
            WriteLiteral("\r\n<main class=\"flex geral\">\r\n    <div class=\"flex icon-2\">");
            EndContext();
            BeginContext(101, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e077a8d92c3ec4e6de082104b12c439abe01d0204203", async() => {
                BeginContext(144, 42, true);
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
            BeginContext(190, 226, true);
            WriteLiteral("</div>\r\n    <div class=\"flex cima \">\r\n            <h5>Usuarios</h5>\r\n    </div>\r\n    <section class=\"flex central-user-adm\">\r\n        <div class=\"flex user-container margin-user dentro\">\r\n            <div>\r\n                <p>");
            EndContext();
            BeginContext(417, 14, false);
#line 11 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
              Write(Model.Usuarios);

#line default
#line hidden
            EndContext();
            BeginContext(431, 169, true);
            WriteLiteral("</p>\r\n                <p>Usuário <br/> Registrados</p>\r\n            </div>\r\n            <i class=\"icon-1 fas fa-users fa-5x\"></i>\r\n            \r\n        </div>\r\n        ");
            EndContext();
            BeginContext(600, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e077a8d92c3ec4e6de082104b12c439abe01d0206585", async() => {
                BeginContext(649, 98, true);
                WriteLiteral("\r\n\r\n            <div class=\" flex user-container\">\r\n                <div>\r\n                    <p>");
                EndContext();
                BeginContext(748, 21, false);
#line 21 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                  Write(Model.UsuariosBanidos);

#line default
#line hidden
                EndContext();
                BeginContext(769, 204, true);
                WriteLiteral("</p>\r\n                    <p>Usuário <br> Banidos</p>\r\n                </div>\r\n                <i class=\"icon-3 fas fa-user-alt-slash fa-5x\"></i>\r\n                \r\n            </div>           \r\n        ");
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
            BeginContext(977, 534, true);
            WriteLiteral(@" 
    </section>
    <section>

            <table>
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>CPF/CNPJ</th>
                        <th>Celular</th>
                        <th>Email Cliente</th>
                        <th colspan=""1"">Bannir</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""9"">
                            <p>Usuarios atualizados em ");
            EndContext();
            BeginContext(1512, 12, false);
#line 44 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                                                  Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1524, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                     foreach (var users in @Model.ListaUsuario)
                    {
                        if (users.TipoUsuario == 1)
                        {

#line default
#line hidden
            BeginContext(1807, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1878, 10, false);
#line 54 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                               Write(users.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1888, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1932, 9, false);
#line 55 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                               Write(users.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(1941, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1985, 14, false);
#line 56 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                               Write(users.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(1999, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2043, 11, false);
#line 57 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                               Write(users.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2054, 57, true);
            WriteLiteral("</td>\r\n                                <td class=\"rec\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2111, "\'", 2173, 1);
#line 58 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
WriteAttributeValue("", 2118, Url.Action("Banir", "Adm", new {email = @users.Email}), 2118, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2174, 125, true);
            WriteLiteral("><i class=\"fas fa-ban\"></i></a></td>\r\n                            </tr>                                                    \r\n");
            EndContext();
#line 60 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Adm\Usuarios.cshtml"
                            
                        }
                    }

#line default
#line hidden
            BeginContext(2379, 79, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.AdmViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591