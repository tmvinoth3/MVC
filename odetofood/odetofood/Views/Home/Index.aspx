<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>

    <div id="loadingDisplay">
        <img src="../../Images/hourglass.gif" />
    </div>  
    <div id="timeDisplay">
  <%=Ajax.ActionLink("click here to show the server time", "ServerTime",
  new AjaxOptions { 
      LoadingElementId = "loadingDisplay",
      Confirm = "Are you really sure ?",
       HttpMethod="GET",
        UpdateTargetId="timeDisplay"
           })%>
    </div>

</asp:Content>

