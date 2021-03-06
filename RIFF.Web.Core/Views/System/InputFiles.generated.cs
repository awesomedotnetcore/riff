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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/System/InputFiles.cshtml")]
    public partial class _Views_System_InputFiles_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_System_InputFiles_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\System\InputFiles.cshtml"
  
    ViewBag.Title = "Processed Input Files";
    Layout = "~/Views/Core/_RIFFPage.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"dx-fieldset\"");

WriteLiteral(" style=\"width: 300px;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"dx-field\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"dx-field-label\"");

WriteLiteral(">Received Date</div>\r\n        <div");

WriteLiteral(" class=\"dx-field-value\"");

WriteLiteral(" id=\"receiveddate\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" id=\"gridContainer\"");

WriteLiteral(" style=\"min-height:500px; width:1200px; margin: 0 auto\"");

WriteLiteral("></div>\r\n\r\n<h3>Submit File</h3>\r\n");

            
            #line 16 "..\..\Views\System\InputFiles.cshtml"
 using (Html.BeginForm("SubmitFile", "Process", FormMethod.Post, new { id = "uploadform", enctype = "multipart/form-data" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"dx-fieldset\"");

WriteLiteral(" style=\"width: 600px;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"dx-field\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"dx-field-label\"");

WriteLiteral(" style=\"width: 40%;\"");

WriteLiteral(">File Key:</div>\r\n            <div");

WriteLiteral(" class=\"dx-field-value\"");

WriteLiteral(" style=\"width: 60%;\"");

WriteLiteral("><div");

WriteLiteral(" id=\"uploadkey\"");

WriteLiteral("></div></div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"dx-field\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"dx-field-label\"");

WriteLiteral(" style=\"width: 40%;\"");

WriteLiteral(">Value Date (blank for auto):</div>\r\n            <div");

WriteLiteral(" class=\"dx-field-value\"");

WriteLiteral(" style=\"width: 60%;\"");

WriteLiteral("><div");

WriteLiteral(" id=\"valuedate\"");

WriteLiteral("></div></div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"dx-field\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"dx-field-label\"");

WriteLiteral(" style=\"width: 40%;\"");

WriteLiteral(">&nbsp;</div>\r\n            <div");

WriteLiteral(" class=\"dx-field-value\"");

WriteLiteral(" style=\"width: 60%;\"");

WriteLiteral("><div");

WriteLiteral(" id=\"uploadfile\"");

WriteLiteral("></div></div>\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"filekey\"");

WriteLiteral(" id=\"filekey\"");

WriteLiteral(" />\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"valueDate\"");

WriteLiteral(" id=\"valuedate_input\"");

WriteLiteral(" />\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"uploadbutton\"");

WriteLiteral("></div>\r\n");

            
            #line 35 "..\..\Views\System\InputFiles.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("RIFFPageScripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var getValueDate = function () {\r\n            return RIFFWebCore.Helpe" +
"rs.getYMD($(\'#valuedate\').dxDateBox(\'instance\').option(\"value\"));\r\n        }\r\n\r\n" +
"        var initializeGrid = function (data) {\r\n\r\n            $(\"#gridContainer\"" +
").dxDataGrid({\r\n                hoverStateEnabled: true,\r\n                dataSo" +
"urce: data,\r\n\r\n                columns: [\r\n                    { dataField: \'Upd" +
"ateDate\', caption: \'Date\', dataType: \'date\', format: \"dd/MM/yyyy\", sortIndex: 0," +
" sortOrder: \'desc\', width: \"75px\", alignment: \"center\" },\r\n                    {" +
" dataField: \'UpdateTime\', caption: \'Time\', dataType: \'date\', format: \"HH:mm:ss\"," +
" sortIndex: 1, sortOrder: \'desc\', width: \"75px\", allowFiltering: false, alignmen" +
"t: \"center\" },\r\n                    { dataField: \'FileKey\', caption: \'File Key\'," +
" width: \"300px\" },\r\n                    { dataField: \'FileName\', caption: \'File " +
"Name\', width: \"400px\" },\r\n                    { dataField: \'FileSize\', caption: " +
"\'File Size\', width: \"100px\", format: \"fixedPoint\" },\r\n                    { data" +
"Field: \'ModifiedTime\', caption: \'Created\', dataType: \'date\', format: \"dd/MM/yyyy" +
" HH:mm:ss\", width: \"150px\", allowFiltering: false, alignment: \"center\" },\r\n     " +
"               { dataField: \'UniqueKey\', visible: false },\r\n                    " +
"{\r\n                        dataField: \'Key\',\r\n                        caption: \'" +
"Download\',\r\n                        width: \"100px\",\r\n                        ali" +
"gnment: \"center\",\r\n                        cellTemplate: function (container, op" +
"tions) {\r\n                            $(\'<a />\').addClass(\'dx-link\')\r\n          " +
"                      .text(\'Download\')\r\n                                .attr(\'" +
"href\', \'");

            
            #line 65 "..\..\Views\System\InputFiles.cshtml"
                                          Write(Url.Action("GetInputFile", "System"));

            
            #line default
            #line hidden
WriteLiteral(@"?uniqueKey=' + options.data.UniqueKey)
                                .appendTo(container);
                        }
                    }
                ],
                columnChooser: { enabled: false },
                allowColumnReordering: false,
                sorting: { mode: 'single' },
                groupPanel: { visible: true, emptyPanelText: 'Drag a column header here to group grid records' },
                columnAutoWidth: false,
                pager: { visible: false },
                paging: { enabled: false },
                headerFilter: { visible: true },
                rowAlternationEnabled: true,
                //paging: { pageSize: 15 },
                scrolling: {
                    mode: 'virtual',
                    preloadEnabled: true
                },
                remoteOperations: false,
                loadPanel: {
                    enabled: false
                },
                filterRow: { visible: true },
                searchPanel: { visible: true },
                selection: { mode: 'single' }
            });
        }

        var refreshGrid = function()
        {
            RIFFWebCore.RIFFPage.populateGrid(""");

            
            #line 96 "..\..\Views\System\InputFiles.cshtml"
                                          Write(Url.Action("GetInputFiles", "System"));

            
            #line default
            #line hidden
WriteLiteral(@""", {
                receivedDate: RIFFWebCore.Helpers.getYMD($('#receiveddate').dxDateBox('instance').option(""value"")),
            }, initializeGrid);
        }

        var RFinitialize = function () {
            $('#uploadfile').dxFileUploader({ name: 'filedata', multiple: false });

            //$('#uploadkey').dxTextBox({ name: 'filekey', width: ""300px"" });
            $('#uploadkey').dxSelectBox({
                width: ""300px"",
                dataSource: [ ");

            
            #line 107 "..\..\Views\System\InputFiles.cshtml"
                         Write(Html.Raw(string.Join(",", RIFF.Web.Core.App_Start.RIFFStart.Config.GetInputFileKeys().Select(k => String.Format("'{0}'", k)))));

            
            #line default
            #line hidden
WriteLiteral(@"],
                value: null,
                onValueChanged: function (data) {
                    $('#filekey').val(data.value);
                }
            });

            $('#uploadbutton').dxButton({
                text: 'Submit', onClick: function () {
                    $('#valuedate_input').val(getValueDate());
                    //$('#filekey').val($('#uploadkey').dxTextBox('instance').option(""value""));
                    $('#uploadform').submit();
                }
            });
            $('#valuedate').dxDateBox({
                min: null,
                max: new Date(),
                displayFormat: 'yyyy-MM-dd',
                value: new Date(");

            
            #line 125 "..\..\Views\System\InputFiles.cshtml"
                            Write(RIFF.Core.RFDate.Today().Year);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 125 "..\..\Views\System\InputFiles.cshtml"
                                                              Write(RIFF.Core.RFDate.Today().Month);

            
            #line default
            #line hidden
WriteLiteral(" - 1, ");

            
            #line 125 "..\..\Views\System\InputFiles.cshtml"
                                                                                                     Write(RIFF.Core.RFDate.Today().Day);

            
            #line default
            #line hidden
WriteLiteral("),\r\n                width: \"300px\"\r\n            });\r\n\r\n            $(\'#receivedda" +
"te\').dxDateBox({\r\n                min: null,\r\n                max: new Date(),\r\n" +
"                displayFormat: \'yyyy-MM-dd\',\r\n                value: new Date(");

            
            #line 133 "..\..\Views\System\InputFiles.cshtml"
                            Write(RIFF.Core.RFDate.Today().Year);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 133 "..\..\Views\System\InputFiles.cshtml"
                                                              Write(RIFF.Core.RFDate.Today().Month);

            
            #line default
            #line hidden
WriteLiteral(" - 1, ");

            
            #line 133 "..\..\Views\System\InputFiles.cshtml"
                                                                                                     Write(RIFF.Core.RFDate.Today().Day);

            
            #line default
            #line hidden
WriteLiteral("),\r\n                onValueChanged: function (e) { refreshGrid(); }\r\n            " +
"});\r\n\r\n            ");

WriteLiteral("\r\n            refreshGrid();\r\n        };\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
