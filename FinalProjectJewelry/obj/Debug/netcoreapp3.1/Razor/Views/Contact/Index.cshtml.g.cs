#pragma checksum "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80aa0327060bb5e8475f61c5c594114cd3a6dd54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80aa0327060bb5e8475f61c5c594114cd3a6dd54", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50681fea8f402bbfec5eb466686a4651f8e21dc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Contact\Index.cshtml"
  
    Dictionary<string, string> settings = await layoutservices.GetSettingAsync();
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""top-2"">
    <div class=""container d-flex tp"">
        <span>Home /</span> <h6>Contact</h6>
    </div>
</section>
<section>
    <div class=""container tp-2"">

        <h1>CONTACT</h1>
    </div>
</section>
<section id=""Contact"">
    <div class=""container d-flex"">
        <div class=""leftside col-lg-6 col-4"">
            <h3>DROP US A LINE</h3>
            <div class=""INPUTS"">
                <h6>Your Name <span>*</span></h6>
                <input type=""name"">
            </div>
            <div class=""INPUTS"">
                <h6>Your Email <span>*</span></h6>
                <input type=""email"" id=""email"" name=""email"">
            </div>
            <div class=""INPUTS"">
                <h6>Your Message </h6>
                <textarea name=""message"">
                    </textarea>
            </div>
            <button type=""button"" class=""btn"">SUMBUIT CONTACT</button>
        </div>
        <div class=""rightside col-lg-6 col-8"">
            <div class=""TOP"">

 ");
            WriteLiteral("               <h6><i class=\"fa-solid fa-house\"></i> CONTACT INFORMATION</h6>\r\n                <h5>OFFICE ADDRESS</h5>\r\n                <P>\r\n                    ");
#nullable restore
#line 43 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Contact\Index.cshtml"
               Write(settings.First(s => s.Key == "Location").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    +84 0123456xx\r\n                </P>\r\n                <P><i class=\"fa-solid fa-envelope\"></i>");
#nullable restore
#line 46 "C:\Users\adils\source\repos\FinalProjectJewelry\FinalProjectJewelry\Views\Contact\Index.cshtml"
                                                  Write(settings.First(s => s.Key == "Mail").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</P>
            </div>
            <div class=""ico"">
                <h2>FOLLOW US ON</h2>
                <i class=""fa-brands fa-facebook""></i><i class=""fa-brands fa-twitter""></i><i class=""fa-brands fa-linkedin""></i><i class=""fa-brands fa-pinterest""></i>
            </div>
        </div>


    </div>

</section>

<section id=""Map"">
    <div class=""divv w-100 col-1"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48632.527184898754!2d49.84860777854917!3d40.374879314687604!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d1f85d9b639%3A0xeda9cb854d1b6add!2sBaku%20Marriott%20Hotel%20Boulevard!5e0!3m2!1sen!2s!4v1673737181381!5m2!1sen!2s"" width=""1903"" height=""600"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2266, "\"", 2284, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILayoutServices layoutservices { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
