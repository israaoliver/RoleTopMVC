#pragma checksum "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f10e19b4e310f69653c9f4869627239073668664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Sucesso), @"mvc.1.0.view", @"/Views/Shared/Sucesso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Sucesso.cshtml", typeof(AspNetCore.Views_Shared_Sucesso))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10e19b4e310f69653c9f4869627239073668664", @"/Views/Shared/Sucesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Sucesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.PagamentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icones/Suc_cadastro.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icones/Suport.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 47, true);
            WriteLiteral("<main>\r\n    \r\n    <section class=\"flex conf\">\r\n");
            EndContext();
#line 5 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
     if("Cadastro".Equals(Model.NomeView))
    {

#line default
#line hidden
            BeginContext(147, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(155, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f10e19b4e310f69653c9f48696272390736686644312", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(196, 117, true);
            WriteLiteral("\r\n        <br>\r\n        <p>Obrigado!!!! <br> Você concluiu seu cadastro, <br> siga para o seu perfil.</p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 313, "\'", 351, 1);
#line 10 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
WriteAttributeValue("", 320, Url.Action("Index", "Usuario"), 320, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(352, 48, true);
            WriteLiteral("><button class=\"margin\">Continuar</button></a>\r\n");
            EndContext();
#line 11 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
    }

#line default
#line hidden
            BeginContext(407, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 12 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
     if("Pagar".Equals(Model.NomeView2))
    {

#line default
#line hidden
            BeginContext(456, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(464, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f10e19b4e310f69653c9f48696272390736686646578", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(505, 88, true);
            WriteLiteral("\r\n        <br>\r\n        <p>Obrigado!!!! <br> Você concluiu seu pagamento</p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 593, "\'", 631, 1);
#line 17 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
WriteAttributeValue("", 600, Url.Action("Index", "Usuario"), 600, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(632, 48, true);
            WriteLiteral("><button class=\"margin\">Continuar</button></a>\r\n");
            EndContext();
#line 18 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
    }

#line default
#line hidden
            BeginContext(687, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 19 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
     if("Suporte".Equals(Model.NomeView2))
    {

#line default
#line hidden
            BeginContext(738, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(746, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f10e19b4e310f69653c9f48696272390736686648816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 97, true);
            WriteLiteral("\r\n        <p>Sua mensagem foi enviada com sucesso! <br> Responderemos em até 48hr</p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 878, "\'", 916, 1);
#line 23 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
WriteAttributeValue("", 885, Url.Action("Index", "Usuario"), 885, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(917, 45, true);
            WriteLiteral("><button class=\"margin\">Voltar</button></a>\r\n");
            EndContext();
#line 24 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
    }

#line default
#line hidden
            BeginContext(969, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 25 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
     if("Cadastro".Equals(Model.NomeView2))
    {

#line default
#line hidden
            BeginContext(1021, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1029, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f10e19b4e310f69653c9f486962723907366866411061", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1070, 183, true);
            WriteLiteral("\r\n        <p>Voce conclui o cadastro do seu evento Obrigado! <br /><br />\r\n                    PAGAR AGORA OU MAIS TARDE\r\n        </p>\r\n        <div class=\"flex lado\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1253, "\'", 1293, 1);
#line 32 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
WriteAttributeValue("", 1260, Url.Action("Eventos", "Usuario"), 1260, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1294, 62, true);
            WriteLiteral("><button class=\"margin\">Continuar</button></a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", "  href=\'", 1356, "\'", 1428, 1);
#line 33 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
WriteAttributeValue("", 1364, Url.Action("Pagamento", "Usuario", new {id = @Model.Evento.Id}), 1364, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1429, 60, true);
            WriteLiteral("><button class=\"margin\">PAGAR</button></a>\r\n        </div>\r\n");
            EndContext();
#line 35 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
    }

#line default
#line hidden
            BeginContext(1496, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 36 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
     if("Informacao".Equals(Model.NomeView2))
    {

#line default
#line hidden
            BeginContext(1550, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1558, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f10e19b4e310f69653c9f486962723907366866413945", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1599, 13, true);
            WriteLiteral("\r\n        <p>");
            EndContext();
            BeginContext(1613, 14, false);
#line 39 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
      Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(1627, 29, true);
            WriteLiteral(" com sucesso!</p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1656, "\'", 1700, 1);
#line 40 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
WriteAttributeValue("", 1663, Url.Action("Informacoes", "Usuario"), 1663, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1701, 48, true);
            WriteLiteral("><button class=\"margin\">Continuar</button></a>\r\n");
            EndContext();
#line 41 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Shared\Sucesso.cshtml"
    }

#line default
#line hidden
            BeginContext(1756, 35, true);
            WriteLiteral("\r\n\r\n    </section>\r\n    \r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.PagamentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
