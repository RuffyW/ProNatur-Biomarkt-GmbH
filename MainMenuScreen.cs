using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductScreen productsScreen = new ProductScreen();
            productsScreen.Show();

            

            
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillScreen billScreen = new BillScreen();
            billScreen.Show();

            
        }
    }
}
