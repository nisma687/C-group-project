using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.WinForms;
using GameStore.Classes;

namespace GameStore
{
    public partial class UserControlCart : UserControl
    {
        public UserControlCart()
        {
            InitializeComponent();
        }
        public UserControlCart(Gamer gamer)
        {
            InitializeComponent();
            double total = 0;
            foreach(Product p in gamer.Cart)
            {
                total += p.Price;
                UserControlWishlist ucw = new UserControlWishlist(p, gamer.Cart);
                panelTop.Controls.Add(ucw);
                ucw.Dock = DockStyle.Top;
            }
            if (total > 0) labelCartEmpty.Hide();
            labelTotalBill.Text = total + "$";
        }

        private void testUC_Load(object sender, EventArgs e)
        {

        }

        private void gameBox5_Load(object sender, EventArgs e)
        {

        }

        private void gameBox2_Load(object sender, EventArgs e)
        {

        }

        private void gameBox3_Load(object sender, EventArgs e)
        {

        }

        private void gameBox4_Load(object sender, EventArgs e)
        {

        }

        private void gameBox1_Load(object sender, EventArgs e)
        {

        }

        private void gameBox6_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTotalTag_Click(object sender, EventArgs e)
        {

        }
    }
}
