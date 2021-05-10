<%@ Page Title="Detale Produktu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ProductDetails.aspx.cs" Inherits="MWSklep.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="MWSklep.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="Images/<%#:Item.ImagePath %>" style="border:solid; height:330px" alt="<%#:Item.ProductName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Opis:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>Cena:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Numer Produktu:</b>&nbsp;<%#:Item.ProductID %></span>
                        <br />
                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                                        <span class="ProductListItem">
                                            <b>Dodaj do Koszyka<b>
                                        </span>           
                        </a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>