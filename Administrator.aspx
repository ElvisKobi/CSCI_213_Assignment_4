<%@ Page Title="" Language="C#" MasterPageFile="~/karateSchool.Master" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="Assignment_4.Administrator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    <p>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    <p>
    </p>
    <p>
        <strong>Add Member</strong></p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="User Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="usertypeDropDown" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="UserType" DataValueField="UserType">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [NetUser]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MemberFirstNameTxt" runat="server" OnTextChanged="MemberFirstNameTxt_TextChanged"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MemberLastNameTxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MemberDateTxt" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MemberPhoneTxt" runat="server" TextMode="Phone"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MemberEmailTxt" runat="server" TextMode="Email"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="MemberCreateBtn" runat="server" Height="43px" OnClick="MemberCreateBtn_Click" Text="Add" Width="152px" />
    </p>
    <p>
    </p>
    <p>
        <strong>Add Instructor</strong></p>
    <p>
        <asp:Label ID="Label9" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label10" runat="server" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label11" runat="server" Text="Phone Number"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="PhoneNumberTextBox" runat="server" TextMode="Phone"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="InstructorBtn" runat="server" Height="43px" OnClick="InstructorBtn_Click" Text="Add" Width="116px" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
