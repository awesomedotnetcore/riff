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

namespace RIFF.Web.Core.App_Code
{
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class RazorHelpers : System.Web.WebPages.HelperPage
    {

#line 6 "..\..\App_Code\RazorHelpers.cshtml"
public static System.Web.WebPages.HelperResult TabsBase(string extraStyle = null)
    {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 7 "..\..\App_Code\RazorHelpers.cshtml"
     


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"tabsbase noprint\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 152), Tuple.Create("\"", 189)

#line 8 "..\..\App_Code\RazorHelpers.cshtml"
, Tuple.Create(Tuple.Create("", 160), Tuple.Create<System.Object, System.Int32>(extraStyle ?? String.Empty

#line default
#line hidden
, 160), false)
);

WriteLiteralTo(__razor_helper_writer, ">&nbsp;</div>\r\n");


#line 9 "..\..\App_Code\RazorHelpers.cshtml"


#line default
#line hidden
});

#line 9 "..\..\App_Code\RazorHelpers.cshtml"
}
#line default
#line hidden

#line 11 "..\..\App_Code\RazorHelpers.cshtml"
public static System.Web.WebPages.HelperResult JustText(string text)
    {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 12 "..\..\App_Code\RazorHelpers.cshtml"
     


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "text\r\n");


#line 14 "..\..\App_Code\RazorHelpers.cshtml"
    

#line default
#line hidden
});

#line 14 "..\..\App_Code\RazorHelpers.cshtml"
}
#line default
#line hidden

#line 16 "..\..\App_Code\RazorHelpers.cshtml"
public static System.Web.WebPages.HelperResult JavascriptArray(IEnumerable<object> l)
    {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 17 "..\..\App_Code\RazorHelpers.cshtml"
     


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, " [\r\n");


#line 19 "..\..\App_Code\RazorHelpers.cshtml"
if(l != null)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, " ");


#line 21 "..\..\App_Code\RazorHelpers.cshtml"
WriteTo(__razor_helper_writer, new HtmlString(string.Join(",", l.Select(i => String.Format("'{0}'", i)))));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 22 "..\..\App_Code\RazorHelpers.cshtml"
}


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ]\r\n");


#line 24 "..\..\App_Code\RazorHelpers.cshtml"
    

#line default
#line hidden
});

#line 24 "..\..\App_Code\RazorHelpers.cshtml"
}
#line default
#line hidden

        #line 26 "..\..\App_Code\RazorHelpers.cshtml"
            
    public static string SanitizeID(string id)
    {
        return id.Replace(" ", "").Replace("(", "").Replace(")", "").Replace(".", "").Replace(",", "").ToLower();
    }

        #line default
        #line hidden
        
    }
}
#pragma warning restore 1591
