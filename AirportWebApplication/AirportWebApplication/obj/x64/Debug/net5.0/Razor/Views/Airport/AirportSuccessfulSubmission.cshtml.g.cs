#pragma checksum "C:\Users\Viliyan Ivanov\Documents\exercises-2021\Viliyan\FinalProject\AirportWebApplication\AirportWebApplication\Views\Airport\AirportSuccessfulSubmission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd14020c18849354a6d813de2ca3e3eab14a8b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Airport_AirportSuccessfulSubmission), @"mvc.1.0.view", @"/Views/Airport/AirportSuccessfulSubmission.cshtml")]
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
#line 1 "C:\Users\Viliyan Ivanov\Documents\exercises-2021\Viliyan\FinalProject\AirportWebApplication\AirportWebApplication\Views\_ViewImports.cshtml"
using AirportWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viliyan Ivanov\Documents\exercises-2021\Viliyan\FinalProject\AirportWebApplication\AirportWebApplication\Views\_ViewImports.cshtml"
using AirportWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd14020c18849354a6d813de2ca3e3eab14a8b1", @"/Views/Airport/AirportSuccessfulSubmission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608218b0529e19dd3ef6c1ccc24ef2e60c92f81e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Airport_AirportSuccessfulSubmission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd14020c18849354a6d813de2ca3e3eab14a8b13615", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300|Montserrat' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css'>
    <link rel=""stylesheet"" href=""/css/SuccessfulSubmission.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd14020c18849354a6d813de2ca3e3eab14a8b14891", async() => {
                WriteLiteral(@"
    <!-- partial:index.partial.html -->
    <div class=""background""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""modalbox success col-sm-8 col-md-6 col-lg-5 center animate"">
                <div class=""icon"">
                    <span class=""glyphicon glyphicon-ok""></span>
                </div>
                <!--/.icon-->
                <h1>Success!</h1>
                <p>
                    You've successfuly created
                    <br>an airport.
                </p>
                <button type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 925, "\"", 978, 3);
                WriteAttributeValue("", 935, "location.href=\'", 935, 15, true);
#nullable restore
#line 25 "C:\Users\Viliyan Ivanov\Documents\exercises-2021\Viliyan\FinalProject\AirportWebApplication\AirportWebApplication\Views\Airport\AirportSuccessfulSubmission.cshtml"
WriteAttributeValue("", 950, Url.Action("Index","Home"), 950, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 977, "\'", 977, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"redo btn\">Ok</button>\n            </div>\n            <!--/.success-->\n        </div>\n    </div>\n    <!--/.container-->\n    <!-- partial -->\n    <script src=\'//cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js\'></script>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591