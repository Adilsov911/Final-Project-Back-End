#pragma checksum "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e016a1a2d781b966d838070ef9593d3bd7d7c15f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
#nullable restore
#line 5 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\_ViewImports.cshtml"
using FinalProjectJewelry.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\_ViewImports.cshtml"
using FinalProjectJewelry.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\_ViewImports.cshtml"
using FinalProjectJewelry.Areas.Manage.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e016a1a2d781b966d838070ef9593d3bd7d7c15f", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50681fea8f402bbfec5eb466686a4651f8e21dc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
   AppUser appUser = null;
    if (User.Identity.IsAuthenticated)
    {
        appUser = await _userManager.FindByNameAsync(User.Identity.Name);

    }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""top-2"">
    <div class=""container d-flex tp"">
        <span>Home /</span> <h6>Blog Detail</h6>
    </div>
</section>

<section>
    <div class=""container tp-2"">

        <h1>BLOGS DETAIL</h1>
    </div>
</section>

<div id=""Blog"">
    <div class=""container"">
        <div class=""row mt-5"">
            <div class=""col-lg-3"">
                <div class=""top"">
                    <h4><i class=""fa-solid fa-pen-to-square""></i>RECENT ARTICLES</h4>
                </div>

                <div class=""right-blog"">
                    <div class=""mideum"">
                        <div class=""top"">
                            <h3> <a");
            BeginWriteAttribute("href", " href=\"", 943, "\"", 950, 0);
            EndWriteAttribute();
            WriteLiteral("> Sample Blog Post With Left Slidebar</a></h3>\r\n                        </div>\r\n                        <div class=\"mid\">\r\n                            <h6>JIN ALKAID / <a");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1128, 0);
            EndWriteAttribute();
            WriteLiteral(@">58 COMMENT(S)</a> </h6>
                        </div>
                        <div class=""bot"">
                            <p>Shoe street style leather tote oversized sweatshirt A.P.C. Prada Saffiano crop slipper denim shorts spearmint. Braid skirt round sunglasses seam...</p>
                        </div>
                    </div>
                    <hr>
                </div>
                <div class=""right-blog"">

                    <div class=""mideum"">
                        <div class=""top"">
                            <h3> <a");
            BeginWriteAttribute("href", " href=\"", 1688, "\"", 1695, 0);
            EndWriteAttribute();
            WriteLiteral("> Sample Blog Post With Left Slidebar</a></h3>\r\n                        </div>\r\n                        <div class=\"mid\">\r\n                            <h6>JIN ALKAID / <a");
            BeginWriteAttribute("href", " href=\"", 1866, "\"", 1873, 0);
            EndWriteAttribute();
            WriteLiteral(@">58 COMMENT(S)</a> </h6>
                        </div>
                        <div class=""bot"">
                            <p>Shoe street style leather tote oversized sweatshirt A.P.C. Prada Saffiano crop slipper denim shorts spearmint. Braid skirt round sunglasses seam...</p>
                        </div>
                    </div>
                    <hr>
                </div>
                <div class=""right-blog"">

                    <div class=""mideum"">
                        <div class=""top"">
                            <h3> <a");
            BeginWriteAttribute("href", " href=\"", 2433, "\"", 2440, 0);
            EndWriteAttribute();
            WriteLiteral("> Sample Blog Post With Left Slidebar</a></h3>\r\n                        </div>\r\n                        <div class=\"mid\">\r\n                            <h6>JIN ALKAID / <a");
            BeginWriteAttribute("href", " href=\"", 2611, "\"", 2618, 0);
            EndWriteAttribute();
            WriteLiteral(@">58 COMMENT(S)</a> </h6>
                        </div>
                        <div class=""bot"">
                            <p>Shoe street style leather tote oversized sweatshirt A.P.C. Prada Saffiano crop slipper denim shorts spearmint. Braid skirt round sunglasses seam...</p>
                        </div>
                    </div>
                    <hr>
                </div>



            </div>
            <div class=""col-lg-9"">

                <div class=""blog-left"">
                    <div class=""top"">
                        <div class=""sa row d-flex"">
                            <div class=""col-lg-2 d-flex bor row"">
                                <div class=""time"">
                                    <h4>");
#nullable restore
#line 90 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                   Write(Model.Blog.Time.ToString("ddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h1>");
#nullable restore
#line 91 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                   Write(Model.Blog.Time.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-10 title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3656, "\"", 3663, 0);
            EndWriteAttribute();
            WriteLiteral("> <h3>");
#nullable restore
#line 95 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                           Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <a href=\"blog-detail.html\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e016a1a2d781b966d838070ef9593d3bd7d7c15f12235", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3895, "~/assest/img/blog/", 3895, 18, true);
#nullable restore
#line 100 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 3913, Model.Blog.Image, 3913, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"description\">\r\n                        <h6>\r\n                            ");
#nullable restore
#line 104 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                       Write(Model.Blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h6>\r\n\r\n\r\n                        <div class=\"bottom justify-content-between d-flex mt-5\">\r\n\r\n                            <div class=\"left\">\r\n                                <h6>");
#nullable restore
#line 111 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                               Write(Model.Blog.AtohorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / <a");
            BeginWriteAttribute("href", " href=\"", 4333, "\"", 4340, 0);
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
#line 119 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                 if (appUser != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""LeaveC text-center"">
                    <div class=""title"">
                        <h6>LEAVE A COMMENT</h6>
                        <img src=""https://cdn.shopify.com/s/files/1/0908/7252/t/4/assets/home_line.png?v=178078056696408182271627441368""");
            BeginWriteAttribute("alt", " alt=\"", 5008, "\"", 5014, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"mid\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e016a1a2d781b966d838070ef9593d3bd7d7c15f16002", async() => {
                WriteLiteral(@"
                            <div class=""d-flex flex-row align-items-start"">
                                <textarea class=""form-control ml-1 shadow-none textarea"" name=""Message""></textarea>
                                <input type=""hidden"" name=""BlogId""");
                BeginWriteAttribute("value", " value=\"", 5468, "\"", 5490, 1);
#nullable restore
#line 132 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 5476, Model.Blog.Id, 5476, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                            <div class=""mt-2 text-right"">
                                <button class=""btn btn-primary btn-sm shadow-none"" type=""submit"">Post comment</button>

                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                                                             WriteLiteral(Model.Blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 142 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"Comment\">\r\n                    <h5>COMMENTS(58)</h5>\r\n\r\n");
#nullable restore
#line 146 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                     if (Model.Comments != null)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                         foreach (var comment in Model.Comments)
                        {

                            if (comment.AppUser.UserName == User.Identity.Name)
                            { 
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"coment\">\r\n                                    <div class=\"com\">\r\n                                        <div class=\"Author d-flex justify-content-between mt-5\">\r\n                                            <p>");
#nullable restore
#line 158 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                          Write(comment.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ON ");
#nullable restore
#line 158 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                                                       Write(comment.Date.ToString("dddd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e016a1a2d781b966d838070ef9593d3bd7d7c15f21745", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                                                            WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </div>\r\n                                        <p>\r\n\r\n                                            ");
#nullable restore
#line 164 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                       Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 168 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <div class=\"coment\">\r\n                                    <div class=\"com\">\r\n                                        <div class=\"Author d-flex justify-content-between mt-5\">\r\n                                            <p>");
#nullable restore
#line 174 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                          Write(comment.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ON ");
#nullable restore
#line 174 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                                                       Write(comment.Date.ToString("dddd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <button type=\"button\" class=\"btn btn-light\">Reply</button>\r\n\r\n                                        </div>\r\n                                        <p>\r\n\r\n                                            ");
#nullable restore
#line 180 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                                       Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 184 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                            }


                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Blog\Detail.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""Pagination"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">...</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">23</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">Next >></a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
