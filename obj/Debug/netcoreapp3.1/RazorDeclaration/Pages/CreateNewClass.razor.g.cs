#pragma checksum "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\CreateNewClass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1cadfe7be4a312a8df2a8bb1ac13df4dd37fe92"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/create")]
    public partial class CreateNewClass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\CreateNewClass.razor"
       
    [Inject] public NavigationManager NavigationManager { get; set; }
    [Inject] public IAmHere.Blazor.Services.IClassInfoService ClassInfoService { get; set; }
    [Inject] public IAmHere.Blazor.Services.IClassCodeGenerator ClassCodeGenerator { get; set; }

    private void CreateClass()
    {
        var classCode = ClassCodeGenerator.GenerateClassCode();
        ClassInfoService.CreateNewClassSession(classCode.Code);
        NavigationManager.NavigateTo($"/newclass/{classCode.Code}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591