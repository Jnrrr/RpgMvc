#pragma checksum "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c7cb92197b82453ed6b575d0b883eeabc741b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Create), @"mvc.1.0.view", @"/Views/Personagens/Create.cshtml")]
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
#line 1 "C:\Users\Junior\Desktop\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Junior\Desktop\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c7cb92197b82453ed6b575d0b883eeabc741b4", @"/Views/Personagens/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
  
    ViewBag.Title = "Novo Personagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 10 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Configura????o para exibir mensagem de erro -->\r\n");
#nullable restore
#line 12 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Criar um Novo Personagem</h2>\r\n");
#nullable restore
#line 19 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Classe, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                \r\n                ");
#nullable restore
#line 35 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Classe , Html.GetEnumSelectList(typeof(RpgMvc.Models.Enums.ClasseEnum)), 
                    "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n            </div>\r\n        </div>  \r\n        \r\n         <div class=\"form-group\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.PontosVida, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 44 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.PontosVida, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n         </div>\r\n         <div class=\"form-group\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Forca, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Forca, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n         </div>\r\n         <div class=\"form-group\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Inteligencia, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 56 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Inteligencia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n         </div>\r\n         <div class=\"form-group\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Defesa, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 62 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Defesa, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
            </div>
         </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-6"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 72 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 74 "C:\Users\Junior\Desktop\RpgMvc\Views\Personagens\Create.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
