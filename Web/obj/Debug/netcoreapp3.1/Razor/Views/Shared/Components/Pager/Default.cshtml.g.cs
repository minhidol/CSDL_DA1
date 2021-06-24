#pragma checksum "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdbb79a97e5de4834ff8a501981dc2f632523571"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
#line 1 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbb79a97e5de4834ff8a501981dc2f632523571", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.DTO.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?pageIndex={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageIndex")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 31 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 968, 1);
#nullable restore
#line 34 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 936, urlTemplate.Replace("{0}", "1"), 936, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1070, "\"", 1136, 1);
#nullable restore
#line 37 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1077, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1077, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 39 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 45 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 47 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1575, "\"", 1602, 2);
            WriteAttributeValue("", 1583, "Trang", 1583, 5, true);
#nullable restore
#line 50 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1588, i.ToString(), 1589, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1603, "\"", 1651, 1);
#nullable restore
#line 50 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1610, urlTemplate.Replace("{0}", i.ToString()), 1610, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1821, "\"", 1856, 1);
#nullable restore
#line 56 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1829, Model.PageCount.ToString(), 1829, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1857, "\"", 1923, 1);
#nullable restore
#line 56 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1864, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1864, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2025, "\"", 2087, 1);
#nullable restore
#line 59 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2032, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2032, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 61 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 63 "C:\Users\minhn\Documents\CSDLNC\Web\Web\Views\Shared\Components\Pager\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.DTO.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
