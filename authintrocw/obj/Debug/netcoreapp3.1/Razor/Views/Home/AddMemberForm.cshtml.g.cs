#pragma checksum "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7f0ec83ffbd8286187503233d4045b2338b5bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddMemberForm), @"mvc.1.0.view", @"/Views/Home/AddMemberForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7f0ec83ffbd8286187503233d4045b2338b5bb", @"/Views/Home/AddMemberForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1383f1261394f60fa64632d2f7be1e44649f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddMemberForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<authintrocw.Models.CustomerModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
  
    ViewData["Title"] = "Add Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Add Member</h1>\r\n");
#nullable restore
#line 6 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
 using (@Html.BeginForm("AddMember", "Home"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 10 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
   Write(Html.LabelFor(customer => customer.customerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
   Write(Html.TextBoxFor(customer => customer.customerFirstName, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
   Write(Html.LabelFor(customer => customer.customerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
   Write(Html.TextBoxFor(customer => customer.customerLastName, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
   Write(Html.LabelFor(customer => customer.customerProfile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
   Write(Html.TextBoxFor(customer => customer.customerProfile, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n  <button type=\"submit\" class=\"btn btn-primary\"> Submit </button>\r\n");
#nullable restore
#line 22 "C:\Users\kyancy\Code_School\auth\introduction\200914-auth-intro1-cw-Kevin-CodeCrew\authintrocw\Views\Home\AddMemberForm.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<authintrocw.Models.CustomerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591