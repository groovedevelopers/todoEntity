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
    public partial class ContactRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/tobiadeyemi/workspace/BlazorServerDbContextExample/Shared/ContactRow.razor"
       

    private Contact _currentContact;

    /// <summary>
    /// The <see cref="Contact"/> being rendered.
    /// </summary>
    [Parameter]
    public Contact CurrentContact
    {
        get => _currentContact;
        set
        {
            if (value != null && !value.Equals(_currentContact))
            {
                _currentContact = value;
                DeleteConfirmation = false;
            }
        }
    }

    /// <summary>
    /// Event to raise when a contact delete is requested.
    /// </summary>
    [Parameter]
    public EventCallback DeleteContact { get; set; }

    /// <summary>
    /// Overall wrapper of functionality.
    /// </summary>
    [CascadingParameter]
    public GridWrapper Wrapper { get; set; }

    /// <summary>
    /// Returns <c>true</c> if conditions for delete are met.
    /// </summary>
    private bool CanDelete => !DeleteConfirmation &&
    (Wrapper.DeleteRequestId == 0 ||
    Wrapper.DeleteRequestId == CurrentContact?.Id);

    /// <summary>
    /// Navigate to view.
    /// </summary>
    private string ViewLink => $"View/{CurrentContact?.Id}";

    /// <summary>
    /// Confirm the delete.
    /// </summary>
    private bool DeleteConfirmation { get; set; }

    /// <summary>
    /// Called based on confirmation.
    /// </summary>
    /// <param name="confirmed"><c>True</c> when confirmed</param>
    /// <returns>A <see cref="Task"/>.</returns>
    private async Task ConfirmAsync(bool confirmed)
    {
        if (confirmed)
        {
            await DeleteAsync();
        }
        else
        {
            DeleteConfirmation = false;
            await Wrapper.DeleteRequested.InvokeAsync(0);
        }
    }

    /// <summary>
    /// Set delete to true.
    /// </summary>
    private async Task DeleteRequestAsync()
    {
        if (Wrapper.DeleteRequestId == 0)
        {
            DeleteConfirmation = true;
            await Wrapper.DeleteRequested.InvokeAsync(CurrentContact.Id);
        }
    }

    /// <summary>
    /// Deletes the <see cref="Contact"/>.
    /// </summary>
    /// <returns>A <see cref="Task"/>.</returns>
    private Task DeleteAsync()
    {
        return DeleteContact.InvokeAsync(this);
    }

    /// <summary>
    /// Correctly formatted name.
    /// </summary>
    private string Name => Filters.ShowFirstNameFirst ?
    $"{CurrentContact?.FirstName} {CurrentContact?.LastName}" :
    $"{CurrentContact?.LastName}, {CurrentContact?.FirstName}";

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactFilters Filters { get; set; }
    }
}
#pragma warning restore 1591
