<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroPessoas.aspx.cs" Inherits="WebUI.CadastroPessoas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            margin-left: 120px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>:: Cadastro de Pessoas</h2>
    <table>
        <tr>
            <td>Código:</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" OnTextChanged="txtCodigo_TextChanged"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td>Nome:</td>
            <td>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>CPF:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Dt. Nascimento:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtDtNascimento" runat="server" OnTextChanged="txtDtNascimento_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Estado Civil:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlEstadosCivis" runat="server">
                    <asp:ListItem Value="S">Solteiro</asp:ListItem>
                    <asp:ListItem Value="C">Casado</asp:ListItem>
                    <asp:ListItem Value="D">Divorciado</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Sexo:</td>
            <td class="auto-style1">
                <asp:RadioButtonList ID="rblSexos" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Feminino</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Telefone:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:CheckBox ID="chkRecebeSMS" runat="server" Text="Recebe SMS" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:CheckBox ID="chkRecebeEmail" runat="server" Text="Recebe E-mail" />
            </td>
        </tr>
    </table>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Foto:"></asp:Label>
        <asp:FileUpload ID="fuFoto" runat="server" />
</p>
    <p>
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" style="margin-left: 15px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" style="margin-left: 11px" />
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
</p>
    <asp:GridView ID="grvPessoas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="593px" OnRowCommand="grvPessoas_RowCommand">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="CdPessoa" HeaderText="Código" />
            <asp:BoundField DataField="NmPessoa" HeaderText="Nome" />
            <asp:BoundField DataField="NrCPF" HeaderText="CPF" />
            <asp:BoundField DataField="DtNascimento" DataFormatString="{0:d}" HeaderText="Dt. Nascimento" />
            <asp:BoundField DataField="DsEmail" HeaderText="E-mail" />
            <asp:CheckBoxField DataField="BtRecebeSMS" HeaderText="Recebe SMS" />
            <asp:CheckBoxField DataField="BtRecebeEmail" HeaderText="Recebe E-mail" />
            <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>
                    <asp:ImageButton ID="ibtnEditar" runat="server" Height="36px" ImageUrl="~/img/edit 2.jpg" Width="39px" commandName="editar" CommandArgument='<%# Eval("CdPessoa") %>'      />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
                <ItemTemplate>
                    <asp:ImageButton ID="ibtnExcluir" runat="server" Height="30px" ImageUrl="~/img/delete 2.jpg" Width="37px" commandName="excluir" CommandArgument='<%# Eval("CdPessoa") %>' OnClientClick="return confirm('Deseja excluir o item selecionado?');" name="testo"/>

                </ItemTemplate>
            </asp:TemplateField>
            <asp:ImageField DataAlternateTextFormatString="CdPessoa" DataImageUrlField="E:\SISTEMA FULL\WebUI\Fotos\Pessoas\{0}.jpg" HeaderText="foto" ReadOnly="True">
                <ControlStyle Height="50px" />
            </asp:ImageField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</asp:Content>
