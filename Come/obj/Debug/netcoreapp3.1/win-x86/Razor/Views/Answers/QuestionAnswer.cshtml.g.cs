#pragma checksum "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f90bc864cf0a7885137f7fb0a416491d489044"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers_QuestionAnswer), @"mvc.1.0.view", @"/Views/Answers/QuestionAnswer.cshtml")]
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
#line 1 "C:\Users\Yusuf\source\repos\Come\Come\Views\_ViewImports.cshtml"
using Come;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusuf\source\repos\Come\Come\Views\_ViewImports.cshtml"
using Come.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f90bc864cf0a7885137f7fb0a416491d489044", @"/Views/Answers/QuestionAnswer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87dd0c70c16a3b2831557e8796361f9463baba48", @"/Views/_ViewImports.cshtml")]
    public class Views_Answers_QuestionAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Come.Models.QuestionAnswer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
  
    ViewData["Title"] = "QuesAnswer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-12\">\r\n            <div");
            BeginWriteAttribute("style", " style=\"", 185, "\"", 193, 0);
            EndWriteAttribute();
            WriteLiteral("class=\"card mb-3 box-shadow\">\r\n\r\n                <h5 style=\"padding:25px;color:darkblue\">");
#nullable restore
#line 13 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                                                   Write(Html.DisplayFor(model => model.Question.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p style=\"padding-left:25px\">");
#nullable restore
#line 14 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                                        Write(Html.DisplayFor(model => model.Question.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <hr />\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\"> ");
#nullable restore
#line 17 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                                       Write(Html.DisplayFor(model => model.Question.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\"> ");
#nullable restore
#line 18 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                                     Write(Html.Raw(Model.Question.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <hr />\r\n                    <p>");
#nullable restore
#line 20 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                  Write(Html.DisplayFor(model => model.Question.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-9\">\r\n");
#nullable restore
#line 34 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
         foreach (var item in Model.Answers)
        {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-3 box-shadow\">\r\n\r\n                <h5 class=\"card-header\">");
#nullable restore
#line 39 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                                   Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">Cevap</h5>\r\n                    <p class=\"card-text\"> ");
#nullable restore
#line 43 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                                     Write(Html.Raw(item.AnswerBody));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                   <hr />\r\n                    <p>");
#nullable restore
#line 45 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
                  Write(item.AnswerDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
   
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""col-md-3"">
        <ul style=""list-style:none"">
            <li><b>Öne Çıkan Sorular</b></li>
            <hr />
            <li>Hayat</li>
            <hr />
            <li>İnsan</li>
            <hr />
            <li>Değer</li>
            <hr />
            <li>Zaman</li>



        </ul>
    </div>
</div>





");
#nullable restore
#line 74 "C:\Users\Yusuf\source\repos\Come\Come\Views\Answers\QuestionAnswer.cshtml"
Write(await Html.PartialAsync("../Shared/_AnswerCreate", Model.Answers1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Come.Models.QuestionAnswer> Html { get; private set; }
    }
}
#pragma warning restore 1591
