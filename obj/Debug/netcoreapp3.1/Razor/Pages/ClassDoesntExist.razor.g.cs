#pragma checksum "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\ClassDoesntExist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e971c3e812af5ab6bf06929c1927451c25169240"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/noclass/{classCode}")]
    public partial class ClassDoesntExist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Class ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\ClassDoesntExist.razor"
          ClassCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " does not exist");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "c:\Users\Ophir\source\repos\IAmHere.Blazor\Pages\ClassDoesntExist.razor"
       
	[Parameter] public string ClassCode { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
