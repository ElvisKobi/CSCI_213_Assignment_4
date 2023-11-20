<%@ Page Title="" Language="C#" MasterPageFile="~/karateSchool.Master" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="Assignment_4.Logon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
&nbsp; <span class="auto-style1">&nbsp;Login</span></p>
&nbsp;&nbsp; Username:&nbsp;&nbsp;
    <asp:TextBox ID="usernameTextBox" runat="server" OnTextChanged="usernameTextBox_TextChanged"></asp:TextBox>
&nbsp;<p>
    </p>
    <p>
        &nbsp;&nbsp; Password:&nbsp;&nbsp; &nbsp;<asp:TextBox ID="passwordTextBox" runat="server" OnTextChanged="passwordTextBox_TextChanged" TextMode="Password"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
<asp:Label ID="errorlbl" runat="server" ForeColor="Red"></asp:Label>
<p>
        &nbsp;<asp:Button ID="loginbtn" runat="server" OnClick="loginbtn_Click" Text="Login" />
    </p>
</asp:Content>
