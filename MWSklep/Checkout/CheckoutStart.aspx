<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckoutStart.aspx.cs" Inherits="MWSklep.Checkout.CheckoutStart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Zamówienie:</h1>
    <p></p>
    <h3 style="padding-left: 33px">Produkty:</h3>
    <asp:GridView ID="OrderItemList" runat="server" AutoGenerateColumns="False" GridLines="Both" CellPadding="10" Width="500" BorderColor="#efeeef" BorderWidth="33">              
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="ID" />        
            <asp:BoundField DataField="Product.ProductName" HeaderText="Nazwa Produktu" />        
            <asp:BoundField DataField="Product.UnitPrice" HeaderText=" Cena (suma)" DataFormatString="{0:c}"/>     
            <asp:BoundField DataField="Quantity" HeaderText="Ilość" />        
        </Columns>    
    </asp:GridView>

     <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText2" runat="server" Text="Suma zamówienia: "></asp:Label>
            <asp:Label ID="lblTotal2" runat="server" EnableViewState="false"></asp:Label>
        </strong> 
    </div>

      <td>
        <asp:Button ID="ConfirmBtn" runat="server" Text="Zatwierdź" OnClick="ConfirmBtn_Click" />
      </td>

</asp:Content>
