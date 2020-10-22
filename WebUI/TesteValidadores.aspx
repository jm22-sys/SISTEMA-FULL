<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteValidadores.aspx.cs" Inherits="WebUI.TesteValidadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="margin-left: 120px">Teste Validadores</h2>
<p style="margin-left: 40px">Nome:
    <asp:TextBox ID="txtNome" runat="server" OnTextChanged="txtNome_TextChanged"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Nome incorreto" ForeColor="Red">*</asp:RequiredFieldValidator>
</p>
    <p>Valor Inteiro::
        <asp:TextBox ID="txtNumeroInt" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="cvNumeroInt" runat="server" BorderColor="Red" ControlToValidate="txtNumeroInt" ErrorMessage="Somente numeros são permitidos" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
</p>
    <p>DT. Inicial.<asp:TextBox ID="txtInicial" runat="server" Width="81px"></asp:TextBox>
&nbsp;DT. Final:<asp:TextBox ID="txtFinal" runat="server" Width="88px"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtInicial" ControlToValidate="txtFinal" ErrorMessage="dt final deve ser maior ou igual a DT inicial" ForeColor="Red" Operator="GreaterThanEqual" Type="Date">*</asp:CompareValidator>
</p>
    <p>Numero menor que 100:<asp:TextBox ID="txt100" runat="server" ViewStateMode="Disabled" Width="84px"></asp:TextBox>
        <asp:CompareValidator ID="cvNumeromaiorcem" runat="server" ControlToValidate="txt100" ErrorMessage="O numero tem que ser menor que 100." ForeColor="Red" Operator="LessThan" Type="Integer" ValueToCompare="100">*</asp:CompareValidator>
</p>
    <p>E-mail:<asp:TextBox ID="txtemail" runat="server" Width="239px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="rev" runat="server" ControlToValidate="txtemail" ErrorMessage="Email Invalido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
</p>
    <p>Digite um mes::<asp:TextBox ID="txtMes" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="rvMes" runat="server" ControlToValidate="txtMes" ErrorMessage="Insira um mes valido" ForeColor="Red" MaximumValue="12" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
</p>
<p>
    <asp:Button ID="btnConfirmar" runat="server" OnClick="btnConfirmar_Click" Text="Confirmar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnLimpar" runat="server" CausesValidation="False" OnClick="btnLimpar_Click" Text="Limpar Campos" Width="101px" />
</p>
    <p>
</p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
<p>
    <asp:Label ID="lblRetorno" runat="server"></asp:Label>
</p>
</asp:Content>
