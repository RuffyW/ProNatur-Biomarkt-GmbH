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

    public partial class Loadingscreen : Form
    {

        private int loadingBarValue;
        public Loadingscreen()
        {
            InitializeComponent();
        }

        private void Loadingscreen_Load(object sender, EventArgs e)
        {
            LoadingBarTimer.Start();
        }

        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 1;

            lblLoadingProgress.Text = loadingBarValue.ToString() + "%";

            loadingProgressBar.Value = loadingBarValue;

            if(loadingBarValue >= loadingProgressBar.Maximum)
            {
                LoadingBarTimer.Stop();

                //Finished Loading

                //TESTTESTTESTTEST
            }
        }

       
    }
}
