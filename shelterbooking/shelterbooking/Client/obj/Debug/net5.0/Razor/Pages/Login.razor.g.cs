#pragma checksum "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01226059e8801ad01162a83811dc7562b26f557d"
// <auto-generated/>
#pragma warning disable 1591
namespace shelterbooking.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using shelterbooking.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using shelterbooking.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LogIn</h3>");
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
}
else
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\n    Username:\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "placeholder", "Email");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
                                       email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    <br>\n    Password: \n     ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "placeholder", "Password");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
                                           password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    <br>\n    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-success");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
                                              () => startLogin(email, password)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    <br>\n     ");
            __builder.AddMarkupContent(19, "<a href=\"https://localhost:5001/createuser\">Dont have a user?</a>");
            __builder.CloseElement();
#nullable restore
#line 27 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Login.razor"
       
    public string email;
    public string password;

    public Bruger[] users;

    protected override async Task OnInitializedAsync()
    {
        users = await Http.GetFromJsonAsync<Bruger[]>("api/Brugere");
    }

    public void startLogin(string email, string password)
    {
        foreach (var user in users)
        {
            if (user.email == email && user.password == password)
            {
                if (user.level == 0)
                {
                    uriHelper.NavigateTo($"fetchdata/{user._id}");
                    break;

                }
                else if (user.level == 1)
                {
                    uriHelper.NavigateTo($"pedelside");
                    break;
                }
                else
                {
                    js.InvokeVoidAsync("alert", $"User access not permitted");
                    break;
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
