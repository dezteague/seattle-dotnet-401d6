#pragma checksum "C:\Users\amand\Source\Repos\seattle-dotnet-401d6\Class34\Demo\BlogPostCMS\BlogPostCMS\Views\Shared\Components\TopArticles\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0272aca9dcef7fd1ad53868dfb15cdf09008315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopArticles_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopArticles/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopArticles/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopArticles_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0272aca9dcef7fd1ad53868dfb15cdf09008315", @"/Views/Shared/Components/TopArticles/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopArticles_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogPostCMS.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 89, true);
            WriteLiteral("\r\n\r\n<div style=\"background-color: green;\">\r\n    <h1>Top 3 Articles In the Database</h1>\r\n");
            EndContext();
#line 6 "C:\Users\amand\Source\Repos\seattle-dotnet-401d6\Class34\Demo\BlogPostCMS\BlogPostCMS\Views\Shared\Components\TopArticles\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(168, 12, true);
            WriteLiteral("        <h3>");
            EndContext();
            BeginContext(181, 7, false);
#line 8 "C:\Users\amand\Source\Repos\seattle-dotnet-401d6\Class34\Demo\BlogPostCMS\BlogPostCMS\Views\Shared\Components\TopArticles\Default.cshtml"
       Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(188, 2, true);
            WriteLiteral(". ");
            EndContext();
            BeginContext(191, 10, false);
#line 8 "C:\Users\amand\Source\Repos\seattle-dotnet-401d6\Class34\Demo\BlogPostCMS\BlogPostCMS\Views\Shared\Components\TopArticles\Default.cshtml"
                 Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(201, 18, true);
            WriteLiteral("</h3>\r\n        <p>");
            EndContext();
            BeginContext(220, 16, false);
#line 9 "C:\Users\amand\Source\Repos\seattle-dotnet-401d6\Class34\Demo\BlogPostCMS\BlogPostCMS\Views\Shared\Components\TopArticles\Default.cshtml"
      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(236, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\amand\Source\Repos\seattle-dotnet-401d6\Class34\Demo\BlogPostCMS\BlogPostCMS\Views\Shared\Components\TopArticles\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(249, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogPostCMS.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591