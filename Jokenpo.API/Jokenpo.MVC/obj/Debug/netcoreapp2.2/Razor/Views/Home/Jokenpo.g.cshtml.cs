#pragma checksum "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b9f6f417e9729df275012a005285fb95ad5386e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Jokenpo), @"mvc.1.0.view", @"/Views/Home/Jokenpo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Jokenpo.cshtml", typeof(AspNetCore.Views_Home_Jokenpo))]
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
#line 1 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\_ViewImports.cshtml"
using Jokenpo.MVC;

#line default
#line hidden
#line 2 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\_ViewImports.cshtml"
using Jokenpo.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b9f6f417e9729df275012a005285fb95ad5386e", @"/Views/Home/Jokenpo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fcdf66fd9cb757dbd443b9a7766790e3fd8da6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Jokenpo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Jokenpo.Model.Jogo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/alchemists-86x98.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/logo-sharks--sm.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Jokenpo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    var divClass = "icobox__icon icobox__icon--border icobox__icon--lg icobox__icon--circle";
    var encerrarJogo = (bool)ViewBag.EncerrarJogo;
    var divClassGreen = "icobox__icon icobox__icon--filled icobox__icon--lg icobox__icon--circle";
    var display = encerrarJogo ? "none" : "";
    var vencedor = (string)ViewBag.Vencedor;

#line default
#line hidden
            BeginContext(421, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(425, 10668, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9f6f417e9729df275012a005285fb95ad5386e6157", async() => {
                BeginContext(462, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(469, 31, false);
#line 13 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.Jogador2));

#line default
#line hidden
                EndContext();
                BeginContext(500, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(507, 31, false);
#line 14 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.Jogador1));

#line default
#line hidden
                EndContext();
                BeginContext(538, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(545, 45, false);
#line 15 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.Jogadas, Model.Jogadas));

#line default
#line hidden
                EndContext();
                BeginContext(590, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(597, 37, false);
#line 16 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.JogadaJogador2));

#line default
#line hidden
                EndContext();
                BeginContext(634, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(641, 37, false);
#line 17 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.JogadaJogador1));

#line default
#line hidden
                EndContext();
                BeginContext(678, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(685, 32, false);
#line 18 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.Resultado));

#line default
#line hidden
                EndContext();
                BeginContext(717, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(726, 61, false);
#line 20 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.VitoriaJogador1, Model.VitoriaJogador1));

#line default
#line hidden
                EndContext();
                BeginContext(787, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(794, 61, false);
#line 21 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.VitoriaJogador2, Model.VitoriaJogador2));

#line default
#line hidden
                EndContext();
                BeginContext(855, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(862, 29, false);
#line 22 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.Status));

#line default
#line hidden
                EndContext();
                BeginContext(891, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(898, 53, false);
#line 23 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
Write(Html.HiddenFor(p => p.RodadaAtual, Model.RodadaAtual));

#line default
#line hidden
                EndContext();
                BeginContext(951, 40, true);
                WriteLiteral("\r\n    <div class=\"site-wrapper clearfix\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 991, "\"", 1018, 4);
                WriteAttributeValue("", 999, "display", 999, 7, true);
                WriteAttributeValue(" ", 1006, ":", 1007, 2, true);
#line 24 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue(" ", 1008, display, 1009, 8, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1017, "", 1018, 1, true);
                EndWriteAttribute();
                BeginContext(1019, 923, true);
                WriteLiteral(@">
        <div class=""site-overlay""></div>
        <div class=""site-content"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <aside class=""widget card widget--sidebar widget-game-result"">
                            <div class=""widget__title card__header"">
                                <h4>Partida</h4>
                            </div>
                            <div class=""widget__content card__content"">

                                <div class=""widget-game-result__section"">
                                    <div class=""widget-game-result__section-inner"">

                                        <header class=""widget-game-result__header widget-game-result__header--alt widget-game-result__header--alt-compact mb-4"">
                                            <time class=""widget-game-result__date""");
                EndContext();
                BeginWriteAttribute("datetime", " datetime=\"", 1942, "\"", 1986, 1);
#line 40 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue("", 1953, DateTime.Now.ToShortDateString(), 1953, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1987, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1989, 12, false);
#line 40 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                                                           Write(DateTime.Now);

#line default
#line hidden
                EndContext();
                BeginContext(2001, 353, true);
                WriteLiteral(@"</time>
                                        </header>

                                        <header class=""widget-game-result__header"">
                                            <h3 class=""widget-game-result__title"">Campeonato de JoKenPo</h3>
                                            <h3 class=""widget-game-result__title"">Rodada Atual: ");
                EndContext();
                BeginContext(2355, 35, false);
#line 45 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                           Write(Html.DisplayFor(p => p.RodadaAtual));

#line default
#line hidden
                EndContext();
                BeginContext(2390, 100, true);
                WriteLiteral("</h3>\r\n                                            <h3 class=\"widget-game-result__title\">Resultado: ");
                EndContext();
                BeginContext(2491, 33, false);
#line 46 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                        Write(Html.DisplayFor(p => p.Resultado));

#line default
#line hidden
                EndContext();
                BeginContext(2524, 98, true);
                WriteLiteral("</h3>\r\n                                            <h3 class=\"widget-game-result__title\">Rodadas: ");
                EndContext();
                BeginContext(2623, 31, false);
#line 47 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                      Write(Html.DisplayFor(p => p.Jogadas));

#line default
#line hidden
                EndContext();
                BeginContext(2654, 418, true);
                WriteLiteral(@"</h3>
                                        </header>

                                        <div class=""widget-game-result__main"">

                                            <div class=""widget-game-result__team widget-game-result__team--first"">
                                                <figure class=""widget-game-result__team-logo"">
                                                    <a href=""#"">");
                EndContext();
                BeginContext(3072, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b9f6f417e9729df275012a005285fb95ad5386e15366", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3120, 252, true);
                WriteLiteral("</a>\r\n                                                </figure>\r\n                                                <div class=\"widget-game-result__team-info\">\r\n                                                    <h5 class=\"widget-game-result__team-name\">");
                EndContext();
                BeginContext(3373, 32, false);
#line 57 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                         Write(Html.DisplayFor(p => p.Jogador1));

#line default
#line hidden
                EndContext();
                BeginContext(3405, 434, true);
                WriteLiteral(@"</h5>
                                                </div>
                                            </div>
                                            <div class=""widget-game-result__score-wrap"">
                                                <div class=""widget-game-result__score"">
                                                    <span class=""widget-game-result__score-result widget-game-result__score-result--winner"">");
                EndContext();
                BeginContext(3840, 39, false);
#line 62 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                                                                       Write(Html.DisplayFor(p => p.VitoriaJogador1));

#line default
#line hidden
                EndContext();
                BeginContext(3879, 149, true);
                WriteLiteral("</span> <span class=\"widget-game-result__score-dash\">-</span> <span class=\"widget-game-result__score-result widget-game-result__score-result--loser\">");
                EndContext();
                BeginContext(4029, 39, false);
#line 62 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                                                                                                                                                                                                                                                                    Write(Html.DisplayFor(p => p.VitoriaJogador2));

#line default
#line hidden
                EndContext();
                BeginContext(4068, 396, true);
                WriteLiteral(@"</span>
                                                </div>
                                            </div>

                                            <div class=""widget-game-result__team widget-game-result__team--second"">
                                                <figure class=""widget-game-result__team-logo"">
                                                    <a href=""#"">");
                EndContext();
                BeginContext(4464, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b9f6f417e9729df275012a005285fb95ad5386e19638", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4511, 252, true);
                WriteLiteral("</a>\r\n                                                </figure>\r\n                                                <div class=\"widget-game-result__team-info\">\r\n                                                    <h5 class=\"widget-game-result__team-name\">");
                EndContext();
                BeginContext(4764, 32, false);
#line 71 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                         Write(Html.DisplayFor(p => p.Jogador2));

#line default
#line hidden
                EndContext();
                BeginContext(4796, 560, true);
                WriteLiteral(@"</h5>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""widget-game-result__section"">
                                    <header class=""widget-game-result__subheader card__subheader card__subheader--sm card__subheader--nomargins"">
                                        <h5 class=""widget-game-result__subtitle"">Jogada do ");
                EndContext();
                BeginContext(5357, 32, false);
#line 79 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                      Write(Html.DisplayFor(p => p.Jogador1));

#line default
#line hidden
                EndContext();
                BeginContext(5389, 501, true);
                WriteLiteral(@"</h5>
                                    </header>
                                    <div class=""clear""></div>
                                    <div class=""row widget-game-result__section-inner"">
                                        <div class=""clear""></div>
                                        <div class=""col-md-4"">
                                            <div class=""icobox icobox--center"">
                                                <button id=""btnPapel"" type=""submit""");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5890, "\"", 5907, 1);
#line 86 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue("", 5898, divClass, 5898, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5908, 749, true);
                WriteLiteral(@" value=""Papel"" name=""resposta"">
                                                    <i class=""fa fa-hand-paper""></i>
                                                </button>
                                                <div class=""icobox__content"">
                                                    <h4 class=""icobox__title icobox__title--lg"">Papel</h4>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-md-4"">
                                            <div class=""icobox icobox--center"">
                                                <button id=""btnPedra"" type=""submit""");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6657, "\"", 6674, 1);
#line 96 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue("", 6665, divClass, 6665, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6675, 750, true);
                WriteLiteral(@" value=""Pedra"" name=""resposta"">
                                                    <i class=""fa fa-hand-rock""></i>
                                                </button>
                                                <div class=""icobox__content"">
                                                    <h4 class=""icobox__title icobox__title--lg"">Pedra</h4>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-md-4"">
                                            <div class=""icobox icobox--center"">
                                                <button id=""btnTesoura"" type=""submit""");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7425, "\"", 7442, 1);
#line 106 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue("", 7433, divClass, 7433, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7443, 925, true);
                WriteLiteral(@" value=""Tesoura"" name=""resposta"">
                                                    <i class=""fa fa-hand-scissors""></i>
                                                </button>
                                                <div class=""icobox__content"">
                                                    <h4 class=""icobox__title icobox__title--lg"">Tesoura</h4>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""widget-game-result__section"">
                                    <header class=""widget-game-result__subheader card__subheader card__subheader--sm card__subheader--nomargins"">
                                        <h5 class=""widget-game-result__subtitle"">Jogada do ");
                EndContext();
                BeginContext(8369, 32, false);
#line 118 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                                      Write(Html.DisplayFor(p => p.Jogador2));

#line default
#line hidden
                EndContext();
                BeginContext(8401, 470, true);
                WriteLiteral(@"</h5>
                                    </header>
                                    <div class=""clear""></div>
                                    <div class=""row widget-game-result__section-inner"">
                                        <div class=""clear""></div>
                                        <div class=""col-md-4"">
                                            <div class=""icobox icobox--center"">
                                                <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 8871, "\"", 8888, 1);
#line 125 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue("", 8879, divClass, 8879, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8889, 700, true);
                WriteLiteral(@" id=""btnPapel2"">
                                                    <i class=""fa fa-hand-paper""></i>
                                                </div>
                                                <div class=""icobox__content"">
                                                    <h4 class=""icobox__title icobox__title--lg"">Papel</h4>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-md-4"">
                                            <div class=""icobox icobox--center"">
                                                <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 9589, "\"", 9606, 1);
#line 135 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue("", 9597, divClass, 9597, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9607, 699, true);
                WriteLiteral(@" id=""btnPedra2"">
                                                    <i class=""fa fa-hand-rock""></i>
                                                </div>
                                                <div class=""icobox__content"">
                                                    <h4 class=""icobox__title icobox__title--lg"">Pedra</h4>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-md-4"">
                                            <div class=""icobox icobox--center"">
                                                <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 10306, "\"", 10323, 1);
#line 145 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
WriteAttributeValue("", 10314, divClass, 10314, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10324, 762, true);
                WriteLiteral(@" id=""btnTesoura2"">
                                                    <i class=""fa fa-hand-scissors""></i>
                                                </div>
                                                <div class=""icobox__content"">
                                                    <h4 class=""icobox__title icobox__title--lg"">Tesoura</h4>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                    </div>
                    </aside>

                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11093, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 164 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
 if (encerrarJogo)
{

#line default
#line hidden
            BeginContext(11118, 953, true);
            WriteLiteral(@"    <div class=""site-wrapper clearfix"">
        <div class=""site-overlay""></div>
        <div class=""site-content"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""twitch-stream-wrapper"">
                            <a href=""#"" class=""twitch-stream   card"">
                                <div class=""twitch-stream__overlay twitch-stream__overlay--bg3 effect-duotone effect-duotone--base""><div class=""effect-duotone__layer""><div class=""effect-duotone__layer-inner""></div></div></div>
                                <figure class=""twitch-stream__img "">
                                    <img src=""assets/images/esports/samples/twitch-streamer-4.png"" alt="""">
                                </figure>
                                <div class=""twitch-stream__body"">
                                    <h5 class=""twitch-stream__title"">");
            EndContext();
            BeginContext(12072, 8, false);
#line 179 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                Write(vencedor);

#line default
#line hidden
            EndContext();
            BeginContext(12080, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 180 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                     if (vencedor != "Empate")
                                    {

#line default
#line hidden
            BeginContext(12190, 81, true);
            WriteLiteral("                                        <div class=\"twitch-stream__info\">Jogador ");
            EndContext();
            BeginContext(12272, 8, false);
#line 182 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                                                            Write(vencedor);

#line default
#line hidden
            EndContext();
            BeginContext(12280, 27, true);
            WriteLiteral("  ganhou a partida!</div>\r\n");
            EndContext();
#line 183 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"
                                    }

#line default
#line hidden
            BeginContext(12346, 206, true);
            WriteLiteral("                                </div>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 192 "C:\Users\paulo.campez\source\repos\JokenpoAPI\Jokenpo.API\Jokenpo.MVC\Views\Home\Jokenpo.cshtml"

}

#line default
#line hidden
            BeginContext(12557, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9f6f417e9729df275012a005285fb95ad5386e35961", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12599, 2071, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function ($) {
        var jogada1 = $(""#JogadaJogador1"").val();
        var tesoura = $(""#btnTesoura"");
        var pedra = $(""#btnPedra"");
        var papel = $(""#btnPapel"");

        if (jogada1 != null) {
            if (jogada1 == ""Papel"") {
                papel.removeClass(""icobox__icon icobox__icon--border icobox__icon--lg icobox__icon--circle"").addClass(""icobox__icon icobox__icon--filled icobox__icon--lg icobox__icon--circle"");
            }
            else if (jogada1 == ""Tesoura"") {
                tesoura.removeClass(""icobox__icon icobox__icon--border icobox__icon--lg icobox__icon--circle"").addClass(""icobox__icon icobox__icon--filled icobox__icon--lg icobox__icon--circle"");
            }
            else if (jogada1 == ""Pedra"") {
                pedra.removeClass(""icobox__icon icobox__icon--border icobox__icon--lg icobox__icon--circle"").addClass(""icobox__icon icobox__icon--filled icobox__icon--lg icobox__icon--circle"");
     ");
            WriteLiteral(@"       }
        }

        //computador
        var jogada2 = $(""#JogadaJogador2"").val();
        var tesoura1 = $(""#btnTesoura2"");
        var pedra1 = $(""#btnPedra2"");
        var papel1 = $(""#btnPapel2"");

        if (jogada2 != null) {
            if (jogada2 == ""Papel"") {
                papel1.removeClass(""icobox__icon icobox__icon--border icobox__icon--lg icobox__icon--circle"").addClass(""icobox__icon icobox__icon--filled icobox__icon--lg icobox__icon--circle"");
            }
            else if (jogada2 == ""Tesoura"") {
                tesoura1.removeClass(""icobox__icon icobox__icon--border icobox__icon--lg icobox__icon--circle"").addClass(""icobox__icon icobox__icon--filled icobox__icon--lg icobox__icon--circle"");
            }
            else if (jogada2 == ""Pedra"") {
                pedra1.removeClass(""icobox__icon icobox__icon--border icobox__icon--lg icobox__icon--circle"").addClass(""icobox__icon icobox__icon--filled icobox__icon--lg icobox__icon--circle"");
            }
        }");
            WriteLiteral("\r\n    })\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Jokenpo.Model.Jogo> Html { get; private set; }
    }
}
#pragma warning restore 1591
