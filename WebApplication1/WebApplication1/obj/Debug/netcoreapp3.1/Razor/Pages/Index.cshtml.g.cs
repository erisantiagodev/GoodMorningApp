#pragma checksum "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b59745ea23cdaaeb4adafe7b217bdde3594bbf6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApplication1.Pages
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
#line 1 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b59745ea23cdaaeb4adafe7b217bdde3594bbf6e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
  
	ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b59745ea23cdaaeb4adafe7b217bdde3594bbf6e3112", async() => {
                WriteLiteral(@"

	<div class=""text-center"" style=""color:white"">

		<p>
			Beaverton
		</p>

		<p>
			<SCRIPT LANGUAGE=""Javascript"">

				// Array of day names
				var dayNames = new Array(""Sunday"", ""Monday"", ""Tuesday"", ""Wednesday"",
					""Thursday"", ""Friday"", ""Saturday"");

				// Array of month Names
				var monthNames = new Array(
					""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"",
					""August"", ""September"", ""October"", ""November"", ""December"");

				var now = new Date();
				document.write(dayNames[now.getDay()] + "", "" +
					monthNames[now.getMonth()] + "" "" +
					now.getDate());

				var currentTime = new Date().getHours();
				if (7 <= currentTime && currentTime < 20) {
					if (document.body) {
						document.body.style.backgroundColor = 'rgb(0, 149, 255)';
					}
				}
				else {
					if (document.body) {
						document.body.style.backgroundColor = 'rgb(0, 55, 143)';
					}
				}

			</SCRIPT>
		</p>
	</div>

	<div class=""text-center"" style=""color:white"">
		<h1");
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 1131, "\"", 1238, 3);
                WriteAttributeValue("", 1137, "http://openweathermap.org/img/wn/", 1137, 33, true);
#nullable restore
#line 51 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
WriteAttributeValue("", 1170, Model.weatherResponse.current.weather.FirstOrDefault().icon, 1170, 60, false);

#line default
#line hidden
#nullable disable
                WriteLiteral("@");
                WriteAttributeValue("", 1232, "2x.png", 1232, 6, true);
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 51 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                                                                                                           Write(Model.weatherResponse.current.temp);

#line default
#line hidden
#nullable disable
                WriteLiteral("°</h1>\r\n\t\t<p>\r\n\t\t\t");
#nullable restore
#line 53 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
       Write(Model.weatherResponse.daily.FirstOrDefault().temp.max);

#line default
#line hidden
#nullable disable
                WriteLiteral("°/");
#nullable restore
#line 53 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                                               Write(Model.weatherResponse.daily.FirstOrDefault().temp.min);

#line default
#line hidden
#nullable disable
                WriteLiteral("° Feels like ");
#nullable restore
#line 53 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                                                                                                                  Write(Model.weatherResponse.current.feels_like);

#line default
#line hidden
#nullable disable
                WriteLiteral("°\r\n\t\t<p> ");
#nullable restore
#line 54 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
       Write(Model.weatherResponse.current.weather.FirstOrDefault().description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t<br />\r\n\t\tClouds : ");
#nullable restore
#line 56 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
            Write(Model.weatherResponse.current.clouds);

#line default
#line hidden
#nullable disable
                WriteLiteral("%\r\n\t\t<br />\r\n\t\tHumidity : ");
#nullable restore
#line 58 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
              Write(Model.weatherResponse.current.humidity);

#line default
#line hidden
#nullable disable
                WriteLiteral("%\r\n\t\t<br />\r\n\t\tWind Speed: ");
#nullable restore
#line 60 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
               Write(Model.weatherResponse.current.wind_speed);

#line default
#line hidden
#nullable disable
                WriteLiteral(" mph\r\n\t\t<br />\r\n\t\tVisibility: ");
#nullable restore
#line 62 "C:\Users\erica\OneDrive\Desktop\WebApplication1\WebApplication1\Pages\Index.cshtml"
               Write(Model.weatherResponse.current.visibility);

#line default
#line hidden
#nullable disable
                WriteLiteral("  m\r\n\t\t</p>\r\n\r\n\t\t<br />\r\n\t</div>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.IndexModel>)PageContext?.ViewData;
        public WebApplication1.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
