<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<odetofood.Models.RestaurantReview>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
              <label>  Name </label>
            </th>
            <th>
              <label>  Rating </label>
            </th>
        </tr>
     </table>
    <% foreach (var item in Model) { %>
<%--                    <div class="editor-label">
                    <%:item.id %>
                </div>--%>
       
                <div class="editor-label">
                    <%:item.Name %>
                </div>
               <div class="editor-label">
                    <%: item.Rating %>
                </div>
                <%: Html.ActionLink("Edit", "Edit", "Reviews")%>
    
    <% } %>



    <p>

        <%: Html.ActionLink("Create New", "Create","Reviews") %>
    </p>

</asp:Content>

