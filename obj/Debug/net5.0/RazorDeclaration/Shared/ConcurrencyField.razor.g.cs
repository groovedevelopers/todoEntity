// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerDbContextExample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using BlazorServerDbContextExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using BlazorServerDbContextExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using BlazorServerDbContextExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/_Imports.razor"
using BlazorServerDbContextExample.Grid;

#line default
#line hidden
#nullable disable
    public partial class ConcurrencyField<TModel> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/Shared/ConcurrencyField.razor"
       
    /// <summary>
    /// The <see cref="TModel"/> being edited.
    /// </summary>
    [Parameter]
    public TModel Model { get; set; }

    /// <summary>
    /// The <see cref="TModel"/> in the database.
    /// </summary>
    [Parameter]
    public TModel DbModel { get; set; }

    /// <summary>
    /// Returns the property to inspect.
    /// </summary>
    [Parameter]
    public Func<TModel, IComparable> Property { get; set; }

    /// <summary>
    /// Only show if concurrency conflict exists.
    /// </summary>
    private bool Show => Model != null && DbModel != null;

    /// <summary>
    /// Highlight properties with different values.
    /// </summary>
    private bool IsDelta => !Property(Model).Equals(Property(DbModel));

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
