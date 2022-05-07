<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<asp:TextBox ID="Num1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
<asp:TextBox ID="Num2" runat="server"></asp:TextBox>
&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="Chisla1" runat="server" ControlToValidate="Num1" ErrorMessage="Введите цифры от 0 до 9" ForeColor="Red" ValidationExpression="[0-9-]*"></asp:RegularExpressionValidator>
&nbsp;
<asp:RegularExpressionValidator ID="Chisla2" runat="server" ControlToValidate="Num2" ErrorMessage="Введите цифры от 0 до 9" ForeColor="Red" ValidationExpression="[0-9-]*"></asp:RegularExpressionValidator>
<p>
    <asp:Button ID="Plus" runat="server" Font-Size="14pt" Height="33px" Text="+" Width="41px" OnClick="Plus_Click" />
    <asp:Button ID="Minus" runat="server" Font-Size="14pt" Height="33px" Text="-" Width="41px" OnClick="Minus_Click" />
    <asp:Button ID="Umn" runat="server" Font-Size="14pt" Height="33px" Text="*" Width="41px" OnClick="Umn_Click" />
    <asp:Button ID="Del" runat="server" Font-Size="14pt" Height="33px" Text="/" Width="41px" OnClick="Del_Click" />
</p>
<p>
    <asp:TextBox ID="Res" runat="server" Enabled="False"></asp:TextBox>
    <asp:Button ID="Clear" runat="server" Font-Size="12pt" Height="33px" Text="Clear" Width="54px" OnClick="Clear_Click" />
</p>
<asp:Button ID="GetCus" runat="server" Font-Size="14pt" Text="GetCustomers" OnClick="GetCus_Click" />
&nbsp;<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>

