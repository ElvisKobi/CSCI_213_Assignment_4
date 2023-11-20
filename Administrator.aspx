<%@ Page Title="" Language="C#" MasterPageFile="~/karateSchool.Master" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="Assignment_4.Administrator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        <span class="auto-style1">Administrator&nbsp;&nbsp;&nbsp;</span>&nbsp;</p>
    
    <p>
        Members<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
          <p>
    Instructors&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</p>
    <p>
    </p>
    <p class="auto-style2">
        Add User</p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="User Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="usertypeDropDown" runat="server">
            <asp:ListItem>Instructor</asp:ListItem>
            <asp:ListItem>Member</asp:ListItem>
        </asp:DropDownList>
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MemberPhoneTxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MemberEmailTxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="MemberCreateBtn" runat="server" Height="43px" OnClick="MemberCreateBtn_Click" Text="Add" Width="152px" />
    </p>
    <p>
        <asp:Label ID="errorlbl" runat="server"></asp:Label>
    </p>
    <p class="auto-style2">
        Delete User:</p>
    <p>
        UserName to delete:</p>
    <p>
        <asp:TextBox ID="deleteNameTxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="deletebtn" runat="server" OnClick="deletebtn_Click" Text="Delete" Width="145px" />
    </p>
    <asp:Label ID="deleteError" runat="server"></asp:Label>
    <br />
    <br />
    <span class="auto-style2">Add Member to Section:<br />
    </span>
    <p>
        Member:&nbsp;&nbsp;
        <asp:DropDownList ID="memberDropDwn" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Instructor:&nbsp;
        <asp:DropDownList ID="instructorDropDwn" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Section Name:&nbsp;
        <asp:DropDownList ID="sectionNameDrpDwn" runat="server">
            <asp:ListItem>Karate Age-Uke</asp:ListItem>
            <asp:ListItem>Karate Chudan-Uke</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Section Fee:&nbsp;
        <asp:TextBox ID="sectionFeeTxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="sectionBtn" runat="server" Height="40px" Text="Create Section" Width="155px" />
    </p>
    <asp:Label ID="SectionError" runat="server"></asp:Label>
    <p>
    </p>
      
     
</asp:Content>
