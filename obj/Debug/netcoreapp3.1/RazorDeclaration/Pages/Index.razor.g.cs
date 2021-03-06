#pragma checksum "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77ba9b4f4e8d3fac07ee6357978e56ed6c817f3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IAmHere_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using IAmHere_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using IAmHere_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Ophir\source\repos\IAmHere.Blazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\Index.razor"
using IAmHere.Blazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\Index.razor"
       
	[Inject] public NavigationManager NavigationManager { get; set; }
	[Inject] public IBrowserSessionHandler SessionHandler { get; set; }
	[Inject] public IClassInfoService ClassInfoService { get; set; }
	private FormModel CodeModel = new FormModel();

	public async Task OnInput()
	{
		// Check if user already entered classroom (w\ browser session)
		if (!ClassInfoService.ClassExists(CodeModel.ClassCode))
		{
			NavigationManager.NavigateTo($"/noclass/{CodeModel.ClassCode}");
			return;
		}

		var result = await SessionHandler.IsStudentRegisteredToClass(CodeModel.ClassCode);
		if (result)
		{
			NavigationManager.NavigateTo("/alreadyentered");
			return;
		}
		
		NavigationManager.NavigateTo($"/enter/{CodeModel.ClassCode}");
	}

	public class FormModel
	{
		[Required]
		[MinLength(CodeLength)]
		[MaxLength(CodeLength)]
    public string ClassCode { get; set; }

		private const int CodeLength = 6;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
