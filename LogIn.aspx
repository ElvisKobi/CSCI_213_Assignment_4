<%@ Page Title="" Language="C#" MasterPageFile="~/karateSchool.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Assignment_4.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
&nbsp;<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Text="Log In"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUserName" runat="server">

</asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="UserNameRequiredFieldValidator" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="Please Enter Your User Name" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Please Enter Your Password" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="LogInBtn" runat="server" Text="Log In" OnClick="LogInBtn_Click" />
    </p>
    <p>
        <asp:Login ID="Login1" runat="server">
        </asp:Login>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
