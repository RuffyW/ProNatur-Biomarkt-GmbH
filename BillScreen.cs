using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class BillScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\weidi\OneDrive\Dokumente\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedBill;

        public BillScreen()
        {
            InitializeComponent();

            ShowBills();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == ""
                || textBox_Empfänger.Text == ""
                || textBox_BillText.Text == ""
                || textBox_Price.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Felder aus");
                return;
            }

            //save Products in Database
            string billID = textBox_ID.Text;
            string billEmpfänger = textBox_Empfänger.Text;
            string billRechnungsText = textBox_BillText.Text;
            string billPrice = textBox_Price.Text;

            string query = string.Format("insert into Rechnungen values('{0}', '{1}', '{2}', '{3}')", billID, billEmpfänger, billRechnungsText, billPrice);
            ExecuteQuery(query);

            ShowBills();
            ClearAllFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lastSelectedBill == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Rechnung aus");
                return;
            }

            string billID = textBox_ID.Text;
            string billEmpfänger = textBox_Empfänger.Text;
            string billRechnungsText = textBox_BillText.Text;
            string billProdukte = textBox_Price.Text;

            string query = string.Format("update Rechnungen set ID='{0}', Empfänger='{1}', RechnungsText='{2}', Preis='{3}'",
                billID, billEmpfänger, billRechnungsText, billProdukte);
            ExecuteQuery(query);

            ShowBills();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lastSelectedBill == 0)
            {
                MessageBox.Show("Bitte wähle ein Rechnung aus.");
                return;
            }

            string query = string.Format("delete from Rechnungen where ID={0};", lastSelectedBill);
            ExecuteQuery(query);

            ClearAllFields();
            ShowBills();
        }

        private void ClearAllFields()
        {
            textBox_Empfänger.Text = "";
            textBox_ID.Text = "";
            textBox_BillText.Text = "";
            textBox_Price.Text = "";
            
        }

        private void ShowBills()
        {
            //Start
            databaseConnection.Open();

            string query = "select * from Rechnungen";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            DGV_Bills.DataSource = dataSet.Tables[0];

            DGV_Bills.Columns[0].Visible = true;

            databaseConnection.Close();
        }

        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void DGV_Bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = DGV_Bills.SelectedRows[0].Cells[1].Value.ToString();
            textBox_Empfänger.Text = DGV_Bills.SelectedRows[0].Cells[2].Value.ToString();
            textBox_BillText.Text = DGV_Bills.SelectedRows[0].Cells[3].Value.ToString();
            



            lastSelectedBill = (int)DGV_Bills.SelectedRows[0].Cells[0].Value;
        }
    }


}
