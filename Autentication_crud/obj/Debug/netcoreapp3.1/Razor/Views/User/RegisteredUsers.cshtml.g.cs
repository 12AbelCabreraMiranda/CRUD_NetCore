#pragma checksum "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14576202f52a3ac305cc6c57bebfe3ba7981cc19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_RegisteredUsers), @"mvc.1.0.view", @"/Views/User/RegisteredUsers.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\_ViewImports.cshtml"
using Autentication_crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\_ViewImports.cshtml"
using Autentication_crud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14576202f52a3ac305cc6c57bebfe3ba7981cc19", @"/Views/User/RegisteredUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"481549ff7a86f16caca0d63ffeb7716c9c239958", @"/Views/_ViewImports.cshtml")]
    public class Views_User_RegisteredUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Autentication_crud.Models.UserSecurity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UsersUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
  
    ViewData["Title"] = "RegisteredUsers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center text-info\">Usuarios registrados en la Base de Datos</h1>\r\n<br />\r\n<br />\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14576202f52a3ac305cc6c57bebfe3ba7981cc194999", async() => {
                WriteLiteral("Crear Nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div>\r\n");
#nullable restore
#line 14 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
     if (TempData["mensajeRegistrado"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible fase show\" role=\"alert\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
       Write(TempData["mensajeRegistrado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n");
#nullable restore
#line 25 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
     if (TempData["mensajeUpdate"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible fase show\" role=\"alert\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
       Write(TempData["mensajeUpdate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n");
#nullable restore
#line 36 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
     if (TempData["mensajeDeleted"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger alert-dismissible fase show\" role=\"alert\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
       Write(TempData["mensajeDeleted"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>NOMBRE</th>
            <th>APELLIDOS</th>
            <th>USUARIO</th>
            <th>CONTRASEÑA</th>
            <th>FECHA REGISTRADO</th>
            <th>ESTADO USUARIO</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 60 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserSecurityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserData.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserData.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserRegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserState));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14576202f52a3ac305cc6c57bebfe3ba7981cc1913045", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
                                                                       WriteLiteral(item.UserSecurityId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n");
            WriteLiteral("\r\n                    <a href=\"#DeleteConfirmation\" id=\"datoID\" class=\"btnDelete btn btn-danger\" data-toggle=\"modal\" data-id=\"");
#nullable restore
#line 90 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
                                                                                                                       Write(item.UserSecurityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Eliminar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Autentication_crud\Autentication_crud\Views\User\RegisteredUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
<div class=""modal fade"" id=""DeleteConfirmation"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4>Eliminar Registro</h4>
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
            </div>
            <div class=""modal-body"">
                <h4>¿Estás seguro? </h4>
                <h5>Quieres eliminar este registro.</h5>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" class=""btn btn-primary"" data-dismiss=""modal"" id=""r"">Cancelar</a>
                <button class=""btnConfir btn btn-danger"">Confirmar</button>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Autentication_crud.Models.UserSecurity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
