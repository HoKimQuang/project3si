#pragma checksum "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "701e231c09d051bb9ce1196d38a86b315796981b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/_ViewImports.cshtml"
using TaskTranning;

#line default
#line hidden
#line 2 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/_ViewImports.cshtml"
using TaskTranning.Models;

#line default
#line hidden
#line 2 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
using TaskTranning.Resources;

#line default
#line hidden
#line 3 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
using TaskTranning.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701e231c09d051bb9ce1196d38a86b315796981b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5150a7bc51847e0bdcea41547885033983a2d189", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/create.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 6 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
  
    ViewBag.Title = Localizer.GetLocalizedHtmlString("lbl_TitleProduct");
    Layout = "_NavbarDataTable";

#line default
#line hidden
            BeginContext(314, 57, true);
            WriteLiteral("<div class=\"sectionContent\">\n    <h3 class=\"text-center\">");
            EndContext();
            BeginContext(372, 52, false);
#line 11 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
                       Write(Localizer.GetLocalizedHtmlString("lbl_TitleProduct"));

#line default
#line hidden
            EndContext();
            BeginContext(424, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 12 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
     if (ViewBag.Count == 0)
    {

#line default
#line hidden
            BeginContext(465, 30, true);
            WriteLiteral("        <p class=\"text-right\">");
            EndContext();
            BeginContext(496, 53, false);
#line 14 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
                         Write(CommonLocalizer.GetLocalizedHtmlString("lbl_NotData"));

#line default
#line hidden
            EndContext();
            BeginContext(549, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(552, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701e231c09d051bb9ce1196d38a86b315796981b7699", async() => {
                BeginContext(575, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "701e231c09d051bb9ce1196d38a86b315796981b7960", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(621, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 15 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(647, 30, true);
            WriteLiteral("        <p class=\"text-right\">");
            EndContext();
            BeginContext(678, 50, false);
#line 18 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
                         Write(CommonLocalizer.GetLocalizedHtmlString("lbl_Find"));

#line default
#line hidden
            EndContext();
            BeginContext(728, 15, true);
            WriteLiteral(": \n            ");
            EndContext();
            BeginContext(744, 13, false);
#line 19 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
       Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(757, 14, true);
            WriteLiteral(" \n            ");
            EndContext();
            BeginContext(773, 118, false);
#line 20 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
        Write(ViewBag.Count > 1 ? Localizer.GetLocalizedHtmlString("lbl_Products") : Localizer.GetLocalizedHtmlString("lbl_Product"));

#line default
#line hidden
            EndContext();
            BeginContext(892, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(905, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701e231c09d051bb9ce1196d38a86b315796981b11605", async() => {
                BeginContext(928, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "701e231c09d051bb9ce1196d38a86b315796981b11867", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(974, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 22 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(985, 120, true);
            WriteLiteral("    <table id=\"table_id\" class=\"table table-bordered\">\n        <thead class=\"text-center\">\n        <tr>\n            <th>");
            EndContext();
            BeginContext(1106, 60, false);
#line 26 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(CommonLocalizer.GetLocalizedHtmlString("lbl_NumericalOrder"));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1189, 51, false);
#line 27 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("lbl_ProductName"));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1263, 49, false);
#line 28 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("lbl_BrandName"));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1335, 52, false);
#line 29 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("lbl_CategoryName"));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1410, 49, false);
#line 30 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("lbl_ModelYear"));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1482, 49, false);
#line 31 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("lbl_ListPrice"));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1554, 47, false);
#line 32 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("lbl_Picture"));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1624, 52, false);
#line 33 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           Write(CommonLocalizer.GetLocalizedHtmlString("lbl_Action"));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 53, true);
            WriteLiteral("</th>\n        </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 37 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
           var i = 0;

#line default
#line hidden
            BeginContext(1752, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 38 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
         foreach (var item  in Model)
        {
            i += 1;

#line default
#line hidden
            BeginContext(1820, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(1858, 1, false);
#line 42 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1859, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1907, 46, false);
#line 44 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 65, true);
            WriteLiteral("\n                </td >\n                <td>\n                    ");
            EndContext();
            BeginContext(2019, 50, false);
#line 47 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Brand.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2134, 56, false);
#line 50 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(2190, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2255, 44, false);
#line 53 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2364, 44, false);
#line 56 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ListPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2408, 218, true);
            WriteLiteral(" VND\n                </td>\n                <td>\n                    <div id=\"notification\"></div>\n                    <button type=\"button\" class=\"btn\" data-toggle=\"modal-picture\" data-target=\"#edit-picture\" data-url=\"");
            EndContext();
            BeginContext(2627, 51, false);
#line 60 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
                                                                                                                   Write(Url.Action("EditProductImage", new {id = @item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(2678, 31, true);
            WriteLiteral("\">\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2709, "\"", 2766, 2);
            WriteAttributeValue("", 2715, "/images/", 2715, 8, true);
#line 61 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
WriteAttributeValue("", 2723, Html.DisplayFor(modelItem => item.Picture), 2723, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2767, 107, true);
            WriteLiteral(" width=\"30\"/>\n                    </button>\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2874, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701e231c09d051bb9ce1196d38a86b315796981b22064", async() => {
                BeginContext(2919, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "701e231c09d051bb9ce1196d38a86b315796981b22327", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2963, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2984, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701e231c09d051bb9ce1196d38a86b315796981b25480", async() => {
                BeginContext(3121, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(3146, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "701e231c09d051bb9ce1196d38a86b315796981b25879", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3187, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3040, "return", 3040, 6, true);
            AddHtmlAttributeValue(" ", 3046, "confirm(\'", 3047, 10, true);
#line 66 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
AddHtmlAttributeValue("", 3056, CommonLocalizer.GetLocalizedHtmlString("msg_QuestionDelete"), 3056, 61, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3117, "\')", 3117, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3212, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 71 "/home/local/3SI/quang.hk/Downloads/3S_Trainning-master/TaskTranning/Views/Product/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3263, 37, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ResourcesServices<CommonResource> CommonLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ResourcesServices<ProductResource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
