#pragma checksum "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fa6f4805b2da5f2b6c8d87591e41cfa936fe9032a3e77feea42f89e33dbf0533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\_ViewImports.cshtml"
using DemoWeb.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\_ViewImports.cshtml"
using DemoWeb.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using DemoWeb.Areas.Identity.Pages.Account

#nullable disable
    ;
#nullable restore
#line 1 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using DemoWeb.Areas.Identity.Pages.Account.Manage

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fa6f4805b2da5f2b6c8d87591e41cfa936fe9032a3e77feea42f89e33dbf0533", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1f1ed4909904ab4ec98c87d4e9fecd241aa04d86d69a51669b7f9193ce4d6918", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d2958147e7770146d06100a3088ad9706d8f5b7bdd7a392a791269008da434ad", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"42516b7868920b1cbf3994b1de1ef9cac38dcb8d3bf69c670977a8807b3b4de5", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
       string

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
            WriteAttributeValue("", 164, 
#nullable restore
#line 6 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
                             statusMessageClass

#line default
#line hidden
#nullable disable
            , 164, 19, false);
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            Write(
#nullable restore
#line 8 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
         Model

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "D:\workspace\VNUIS-INS3107\ins3107\DemoWeb\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
