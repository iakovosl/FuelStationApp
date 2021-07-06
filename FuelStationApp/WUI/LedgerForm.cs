using FuelStationApp.Properties;
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

namespace FuelStationApp.WUI {
    public partial class LedgerForm : Form {
        public SqlConnection Connection { get; set; }
        
       
        public LedgerForm() {
            InitializeComponent();
        }

        private decimal FetchingData(string myquery) {
            try {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(myquery, Connection);
                string result = Convert.ToString(cmd.ExecuteScalar());
                Connection.Close();
                return Convert.ToDecimal(result);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Connection.Close();
                return 0;
            }
        }


        private void Dates()
        {

            DateTime dateStart = Convert.ToDateTime(ctrlDateFrom.EditValue);

            DateTime dateEnd = Convert.ToDateTime(ctrlDateΤο.EditValue);

            const decimal rent = 5000m;

            decimal totalRentCount = (dateEnd - dateStart).Days * rent / 30;

            try
            {
               
                string sqlCommandIncome = String.Format(Resources.Income, dateStart.ToString("yyyy-MM-dd"), dateEnd.ToString("yyyy-MM-dd"));
                decimal income = FetchingData(sqlCommandIncome);
               

                string sqlCommandCost = String.Format(Resources.CostCalculation, dateStart.ToString("yyyy-MM-dd"), dateEnd.ToString("yyyy-MM-dd"));
                decimal itemsCost = FetchingData(sqlCommandCost);

                

                decimal expenses = itemsCost + totalRentCount;
                ctrlIncome.EditValue = income;
                ctrlExpenses.EditValue = expenses;

                TotalValueCalculation(income, expenses);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }
        private void TotalValueCalculation(decimal income, decimal expenses) {
            decimal total;
            if (income > expenses) {
                total = income - expenses;
                ctrlTotal.EditValue = Convert.ToString(total);
              
            }
            else {
                total = expenses - income;
                ctrlTotal.EditValue = Convert.ToString(total);
               
            }
        }



        private void labelControl6_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dates();
        }

        private void ctrlExpenses_EditValueChanged(object sender, EventArgs e) {

        }

        private void ctrlIncome_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
