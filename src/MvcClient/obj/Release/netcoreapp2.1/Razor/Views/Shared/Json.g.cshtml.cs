#pragma checksum "C:\Users\janss\Documents\school\Jaar 2\3\8_AspNetIdentity\src\MvcClient\Views\Shared\Json.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5eacd24ba881198d43afcb809e28370188055c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Json), @"mvc.1.0.view", @"/Views/Shared/Json.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Json.cshtml", typeof(AspNetCore.Views_Shared_Json))]
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
#line 1 "C:\Users\janss\Documents\school\Jaar 2\3\8_AspNetIdentity\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5eacd24ba881198d43afcb809e28370188055c", @"/Views/Shared/Json.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85b62b0638c1fde9125c8ffd754efc24f227a99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Json : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<h1>API Response</h1>\n<pre>");
            EndContext();
            BeginContext(28, 12, false);
#line 2 "C:\Users\janss\Documents\school\Jaar 2\3\8_AspNetIdentity\src\MvcClient\Views\Shared\Json.cshtml"
Write(ViewBag.Json);

#line default
#line hidden
            EndContext();
            BeginContext(40, 6, true);
            WriteLiteral("</pre>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
