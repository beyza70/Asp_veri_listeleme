#pragma checksum "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d91a2f8dc1d83a22973094a512190cfcea1265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d91a2f8dc1d83a22973094a512190cfcea1265", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h4>Beyzanur KALE</h4>
<h4>181312020</h4>

<h1>----------------------Market Ürünlerini Fiyata Göre Listeleme---------------------</h1> 

<h3>Fiyata Göre Listelemek İçin Fiyat Butonuna Basınız.</h3>
<link href=""//cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
<div class=""row"">
    <div class=""col-lg-12"">
        <table id=""myTable"" class=""display"">
            <thead>
                <tr>
                    <th>  Id  </th>
                    <th>  katagori  </th>
                    <th>  urunAdi  </th>
                    <th>  Fiyat  </th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml"
                       Write(item.katagori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml"
                       Write(item.urunAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml"
                       Write(item.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Av.Mustafa KALE\source\repos\ornek\ornek\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<script src=""//cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"" type=""text/javascript""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#myTable').DataTable();
    });
</script>
");
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