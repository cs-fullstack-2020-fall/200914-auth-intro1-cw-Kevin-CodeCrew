#pragma checksum "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b14b48230c344b7a8647d5e135fa03ace7bc51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListMembers), @"mvc.1.0.view", @"/Views/Home/ListMembers.cshtml")]
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
#line 1 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\_ViewImports.cshtml"
using authintrocw;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\_ViewImports.cshtml"
using authintrocw.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b14b48230c344b7a8647d5e135fa03ace7bc51", @"/Views/Home/ListMembers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1383f1261394f60fa64632d2f7be1e44649f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListMembers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<authintrocw.Data.ApplicationDbContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMemberForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
  
    ViewData["Title"] = "List Customers";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <h1>View All</h1>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n            <th scope=\"col\">ID</th>\r\n            <th scope=\"col\">Name</th>\r\n            <th scope=\"col\">Profile</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
         foreach (CustomerModel customer in @Model.customers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scrope=\"row\">");
#nullable restore
#line 19 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
                            Write(customer.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b14b48230c344b7a8647d5e135fa03ace7bc515398", async() => {
#nullable restore
#line 20 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
                                                                                                              Write(customer.customerFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
                                                                                                                                          Write(customer.customerLastName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
                                                                                         WriteLiteral(customer.id);

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
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
               Write(customer.customerProfile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\ListMembers.cshtml"
        }            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<authintrocw.Data.ApplicationDbContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
