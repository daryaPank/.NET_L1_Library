#pragma checksum "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eb151ef6cac5474ff1c3712a6ccbc303e52aacd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eb151ef6cac5474ff1c3712a6ccbc303e52aacd", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessInterop.Data.BookDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Книги";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<h2 style=\"font-size:x-large; color:#dda0dd;\">Книги</h2>\r\n\r\n\r\n<div class=\"container\" style=\"border-radius: 5px\">\r\n            <div align=\"center\">\r\n                ");
#nullable restore
#line 14 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Добавить", "Create", "Book", null, new { @class = "btn btn-outline-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n</div>\r\n\r\n<div class=\"main\" style=\"display:flex; flex-direction:row; align-content:center; flex-wrap:wrap; padding:5px;\">\r\n");
#nullable restore
#line 19 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"width:150px; height:150px; margin:5px; border:2px solid #dda0dd; \">\r\n        <p style=\"text-align:center; margin:0px\">");
#nullable restore
#line 22 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"text-align: center; margin: 0px \">");
#nullable restore
#line 23 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
                                               Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"text-align: center; margin: 0px \">");
#nullable restore
#line 24 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
                                               Write(item.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div align=\"center\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Редактировать", "Update", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Удалить", "Delete", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\Darya\Desktop\универ\3 курс\ДОТНЕТ\Новая папка\Library\Views\Book\Index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessInterop.Data.BookDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591