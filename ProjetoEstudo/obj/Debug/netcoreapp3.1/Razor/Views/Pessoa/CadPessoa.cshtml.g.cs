#pragma checksum "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d77d5d35bc1c7e1f2472bef5b02a99b5c4f8a9bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_CadPessoa), @"mvc.1.0.view", @"/Views/Pessoa/CadPessoa.cshtml")]
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
#line 1 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\_ViewImports.cshtml"
using ProjetoEstudo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\_ViewImports.cshtml"
using ProjetoEstudo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d77d5d35bc1c7e1f2472bef5b02a99b5c4f8a9bd", @"/Views/Pessoa/CadPessoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf79571be9bdd18ff022a3b07fc4fa6fe460cf0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_CadPessoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoEstudo.Models.Pessoa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inserir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Cadastrar Usuário"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
  
    ViewData["Title"] = "Cadastro de Pessoa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2> Cadastro  de Pessoa</h2>\r\n</div>\r\n\r\n");
#nullable restore
#line 15 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horinzontal\">\r\n\r\n        <rh />\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 23 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
       Write(Html.LabelFor(model => Model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n                <input type=\"text\" class=\"form-control\" name=\"Nome\" placeholder=\"Seu nome\" required>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
       Write(Html.LabelFor(model => Model.Sobrenome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n                <input type=\"text\" class=\"form-control\" name=\"Sobrenome\" placeholder=\"Seu sobrenome\" required>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 40 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
       Write(Html.LabelFor(model => Model.DataNasc, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 43 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
           Write(Html.EditorFor(model => model.DataNasc, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d77d5d35bc1c7e1f2472bef5b02a99b5c4f8a9bd7329", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 53 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
         switch (ViewData["Mensagem"])
        {
            case "Sucesso":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-primary\" role=\"alert\"> <div class=\"text-center\"><h6>Cadastro realizado com sucesso!</h6></div></div> ");
#nullable restore
#line 56 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
                                                                                                                                             ;
                break;
            case "Falha":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\" role=\"alert\"> <div class=\"text-center\"><h6>O usuário já existe!</h6></div></div>");
#nullable restore
#line 59 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"
                                                                                                                                ;
                break;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\SistemasGitHub\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\CadPessoa.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoEstudo.Models.Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
