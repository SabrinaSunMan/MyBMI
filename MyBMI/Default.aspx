<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyBMI._Default" %>

 
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row">
        <div class="col-md-4">

            <p>請輸入你的性別</p>
            <asp:DropDownList ID="drop_Sex" runat="server" ></asp:DropDownList> <%--AutoPostback="False"--%>

            <p>請輸入計算的身高單位</p>
            <asp:DropDownList ID="drop_Height" runat="server" ></asp:DropDownList>
            <asp:TextBox ID="tx_Height" runat="server" ></asp:TextBox>

            <p>請輸入計算的體重單位</p>
            <asp:DropDownList ID="drop_Weight" runat="server" ></asp:DropDownList>
            <asp:TextBox ID="tx_Weight" runat="server" ></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Label ID="label_1" runat="server" ></asp:Label>
             
            <input type="button" onclick="javascript: CallMe();" value="CallME!" />
        </div>
    </div>

</asp:Content>
