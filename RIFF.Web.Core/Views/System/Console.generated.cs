﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using RIFF.Web.Core;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/System/Console.cshtml")]
    public partial class _Views_System_Console_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_System_Console_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\System\Console.cshtml"
  
    Layout = "~/Views/Core/_RIFFPage.cshtml";
    ViewBag.Title = "RIFF Console";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"console\"");

WriteLiteral("></div>\r\n\r\n");

DefineSection("RIFFPageScripts", () => {

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 160), Tuple.Create("\"", 220)
            
            #line 9 "..\..\Views\System\Console.cshtml"
, Tuple.Create(Tuple.Create("", 166), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Scripts/jquery.terminal-0.9.3.min.js")
            
            #line default
            #line hidden
, 166), false)
);

WriteLiteral("></script>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 242), Tuple.Create("\"", 294)
            
            #line 10 "..\..\Views\System\Console.cshtml"
, Tuple.Create(Tuple.Create("", 249), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Content/jquery.terminal.css")
            
            #line default
            #line hidden
, 249), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n\r\n        var terminal;\r\n\r\n        var RFinitialize = function () {\r\n        ");

WriteLiteral("\r\n\r\n            terminal = $(\'#console\').terminal(\'");

            
            #line 37 "..\..\Views\System\Console.cshtml"
                                          Write(Url.Action("ConsoleCommand", "System"));

            
            #line default
            #line hidden
WriteLiteral(@"', {
                greetings: '',
                name: 'riff_console',
                height: 650,
                processArguments: false,
                prompt: 'riff> ',
                onInit: function () {
                    terminal.exec('version', true);
                }
            });
        };
    </script>
");

});

        }
    }
}
#pragma warning restore 1591