#pragma checksum "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4acf04ae5604c1758851acfa0450ae5121a76a8"
// <auto-generated/>
#pragma warning disable 1591
namespace BMC.Security.Web.Blazor.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using BMC.Security.Web.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using BMC.Security.Web.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using BMC.Security.Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"card-img\">\r\n        <img src=\"/images/loginbmc.png\" asp-append-version=\"true\" style=\"width:300px;padding-left:20px\">\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content");
            __builder.AddAttribute(6, "style", "margin-left:30px");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<div>\r\n            <strong style=\"font-size:40px\">WELCOME TO</strong><br>\r\n            <p style=\"font-size:25px\">BMSPACE SECURITY</p>\r\n        </div>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "style", "border: 1px solid grey; border-radius: 30px; text-align: center; padding: 10px; width: 270px;");
            __builder.AddAttribute(13, "placeholder", "Email");
            __builder.AddAttribute(14, "name", "ctl00$MainContent$TxtPass");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "id", "MainContent_TxtPass");
            __builder.AddAttribute(17, "class", "uk-input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
                          Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        <br>\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "style", "border: 1px solid grey; border-radius: 30px; text-align: center; padding: 10px; width: 270px;");
            __builder.AddAttribute(26, "placeholder", "Password");
            __builder.AddAttribute(27, "name", "ctl00$MainContent$TxtPass");
            __builder.AddAttribute(28, "type", "password");
            __builder.AddAttribute(29, "id", "MainContent_TxtPass");
            __builder.AddAttribute(30, "class", "uk-input");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
                          Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        <br>\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn-default");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
                                              DoLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
       
    string Email = string.Empty;
    string Password = string.Empty;

    async Task DoLogin()
    {
        string ErrorMsg = string.Empty;
        if (string.IsNullOrEmpty(Email))
        {
            ErrorMsg = "Insert email";
        }
        if (string.IsNullOrEmpty(Password))
        {
            ErrorMsg = "Insert password";
        }
        if (ErrorMsg.Length > 0)
        {
            toastService.ShowError(ErrorMsg);
            return;
        }
        else
        {
            string logUrl = $"/login?paramUsername={encode(Email)}&paramPassword={encode(Password)}";
            await jsRuntime.InvokeAsync<object>("OpenUrl", logUrl);
        }

        return;
    }

    private string encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }

    protected override async Task OnInitializedAsync()
    {
        var uri = navMgr.ToAbsoluteUri(navMgr.Uri);
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("result", out var resultString))
        {
            var result = bool.Parse(resultString);
            if (!result)
            {
                //showError = true;
                toastService.ShowWarning("username/password salah atau tidak terdaftar", "Perhatian");
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
