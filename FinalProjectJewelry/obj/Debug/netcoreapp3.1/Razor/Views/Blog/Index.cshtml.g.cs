#pragma checksum "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a81572a9cb9c8698877dc013d2b9b2036e64da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 3 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\_ViewImports.cshtml"
using FinalProjectJewelry.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\_ViewImports.cshtml"
using FinalProjectJewelry.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a81572a9cb9c8698877dc013d2b9b2036e64da", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58bef7bccc4ab23566a2685e990715faa40511bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""top-2"">
    <div class=""container d-flex tp"">
        <span>Home /</span> <h6>Blog</h6>
    </div>
</section>

<section>
    <div class=""container tp-2"">

        <h1>BLOGS</h1>
    </div>
</section>

<div id=""Blog"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
");
#nullable restore
#line 20 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                 foreach (var blog in Model.Blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""blog-left"">
                        <div class=""top"">
                            <div class=""sa row d-flex"">
                                <div class=""col-lg-2 d-flex bor row"">
                                    <div class=""time"">
                                        <h4>");
#nullable restore
#line 27 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                       Write(blog.Time.ToString("ddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <h1>");
#nullable restore
#line 28 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                       Write(blog.Time.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-lg-10 title\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6a81572a9cb9c8698877dc013d2b9b2036e64da5990", async() => {
                WriteLiteral(" <h3>");
#nullable restore
#line 32 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                                                                                         Write(blog.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                                                                   WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6a81572a9cb9c8698877dc013d2b9b2036e64da8927", async() => {
                WriteLiteral(" ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b6a81572a9cb9c8698877dc013d2b9b2036e64da9179", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1387, "~/assest/img/blog/", 1387, 18, true);
#nullable restore
#line 37 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1405, blog.Image, 1405, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"description\">\r\n                            <h6>\r\n                                ");
#nullable restore
#line 41 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                           Write(blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h6>\r\n\r\n\r\n                            <div class=\"bottom justify-content-between d-flex mt-5\">\r\n\r\n                                <div class=\"left\">\r\n                                    <h6>");
#nullable restore
#line 48 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                   Write(blog.AtohorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / <a");
            BeginWriteAttribute("href", " href=\"", 1839, "\"", 1846, 0);
            EndWriteAttribute();
            WriteLiteral(@">58 COMMENT(S)</a> </h6>
                                </div>
                                <div class=""right"">
                                    <button type=""button"" class=""btn btn-light"">POST COMMENT</button>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 56 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"               
                <div class=""last"">

                    <a href=""#"" class=""previous"">&laquo; Previous</a>
                    <a href=""#"" class=""next"">Next &raquo;</a>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""top"">
                    <h4><i class=""fa-solid fa-pen-to-square""></i>RECENT ARTICLES</h4>
                </div>
");
#nullable restore
#line 68 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                 foreach (var blog in Model.Blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"right-blog\">\r\n\r\n                        <div class=\"mideum\">\r\n                            <div class=\"top\">\r\n                                <h3> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6a81572a9cb9c8698877dc013d2b9b2036e64da15488", async() => {
#nullable restore
#line 74 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                                                                                     Write(blog.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                                                                                    WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                            </div>\r\n                            <div class=\"mid\">\r\n                                <h6>");
#nullable restore
#line 77 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                               Write(blog.AtohorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / <a");
            BeginWriteAttribute("href", " href=\"", 3119, "\"", 3126, 0);
            EndWriteAttribute();
            WriteLiteral(">58 COMMENT(S)</a> </h6>\r\n                            </div>\r\n                            <div class=\"bot\">\r\n                                <p>");
#nullable restore
#line 80 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                              Write(blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <hr>\r\n                    </div>\r\n");
#nullable restore
#line 85 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
