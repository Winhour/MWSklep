using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MWSklep.Models;

namespace MWSklep.Checkout
{
    public partial class CheckoutStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (MWSklep.Logic.ShoppingCartActions usersShoppingCart = new MWSklep.Logic.ShoppingCartActions())
            {
                List<CartItem> myOrderList = usersShoppingCart.GetCartItems();

                OrderItemList.DataSource = myOrderList;
                OrderItemList.DataBind();

                lblTotal2.Text = String.Format("{0:c}", usersShoppingCart.GetTotal());

            }

                
        }

        protected void ConfirmBtn_Click(object sender, EventArgs e)
        {
            using (MWSklep.Logic.ShoppingCartActions usersShoppingCart = new MWSklep.Logic.ShoppingCartActions())
            {
                usersShoppingCart.EmptyCart();

            }
            Response.Redirect("~//Default.aspx");
        }

    }
}