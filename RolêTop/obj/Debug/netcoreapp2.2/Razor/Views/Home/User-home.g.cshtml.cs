#pragma checksum "C:\Users\44346823858\Documents\Sprint4-Senai\RolêTop\Views\Home\User-home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed31b9fa7f658099952818a406cba2b0d4bf3ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User_home), @"mvc.1.0.view", @"/Views/Home/User-home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/User-home.cshtml", typeof(AspNetCore.Views_Home_User_home))]
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
#line 1 "C:\Users\44346823858\Documents\Sprint4-Senai\RolêTop\Views\_ViewImports.cshtml"
using RolêTop;

#line default
#line hidden
#line 2 "C:\Users\44346823858\Documents\Sprint4-Senai\RolêTop\Views\_ViewImports.cshtml"
using RolêTop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed31b9fa7f658099952818a406cba2b0d4bf3ed", @"/Views/Home/User-home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d771df0a618397fa5cd51c5f4267a2c2941ae965", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User_home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(38, 556, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ed31b9fa7f658099952818a406cba2b0d4bf3ed3374", async() => {
                BeginContext(44, 543, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Home-Usuario</title>
    <link href=""2-Imagens/logo do RolêTop.ico"" rel=""icon"" type=""image/x-icon"" />
    <link href=""https://fonts.googleapis.com/css?family=Carter+One|Itim|Limelight|Roboto&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/User-home.css"">
    <script src=""https://kit.fontawesome.com/349a64cb04.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(594, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(596, 2845, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ed31b9fa7f658099952818a406cba2b0d4bf3ed5125", async() => {
                BeginContext(602, 2832, true);
                WriteLiteral(@"
    <header>
        
            <div class=""flex container-header"">
                <div id=""logo"">
                    <a href=""index.html""><img src=""2-Imagens/logo do RolêTop.png"" title=""Logo RolêTop""></a>
                </div>
                <div class=""flex user"">
                    <p>Daniel da silva neto</p>
                    <img src=""1-Icones/PNGs-Prontos/usuario.png"" >
                </div>
            </div>
        </header>
        <section>
                <div class=""flex home-container"">
                        <i class=""icon fas fa-home fa-2x""></i>
                        <h1>Home</h1>
                </div>
            <main>
                <div class=""flex main-container"">
                    <a href=""User-informacoes.html""><div class=""flex main-cent info""><h2>Veja aqui suas <br> informações.</h2></div></a>
                    <a href=""User-cadastrar.html""><div class=""flex main-cent cadastrar""><h2>Cadastre Novos Eventos</h2></div></a>
                    <a hr");
                WriteLiteral(@"ef=""User-Eventos.html""><div class=""flex margin main-cent evento""><h2>Veja aqui seus eventos <br> cadastrados.</h2></div></a>
                    <a href=""User-suporte.html""><div class=""flex margin main-cent suport""><h2>Tem Alguma Duvida? <br> ou Problema? <br> Contate-nos diretamente.</h2></div></a>
                    
                </div>          
            </main>
        </section>
        
        <footer>
                <div class=""flex footer-container"">
                
                    <img class=""footer-logo"" src=""2-Imagens/logo do RolêTop.png"" alt=""Logo do RoleTop"">
                    <div class=""end"">
                            <address>
                                    Avenida de Limeira, 539 - Campos Elíseos - SP
                                    <br />
                                    roletop@email.com
                                    <br />
                                    11 1234 6789
                                </address>
                    </");
                WriteLiteral(@"div>
                    <div class="" flex social"">
                        <div class=""flex foot"">
                            <p>Facebook:</p><br>
                            <i class=""social-icon fab fa-facebook-square fa-2x""></i>
                        </div>
                        <div class=""flex foot"">
                            <p>Instagram:</p> <br>
                            <i class=""social-icon fab fa-instagram fa-2x""></i>
                        </div>
                        <div class=""flex foot"">
                            <p>Acesso a Deficiente:</p>
                            <i class="" social-icon fab fa-accessible-icon fa-2x""></i>
                        </div>
                    </div>
                </div>
            </footer>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3441, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
