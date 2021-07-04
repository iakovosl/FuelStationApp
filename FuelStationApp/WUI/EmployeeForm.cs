using FuelStationApp.Impl;
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
    public partial class EmployeeForm : Form {
        public SqlConnection Connection { get; set; }
        public EmployeeForm() {
            InitializeComponent();
        }

        void PopulateDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Employees";
                SqlDataAdapter data = new SqlDataAdapter(MyQuery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataset = new DataSet();
                data.Fill(dataset);
                gridEmployees.DataSource = dataset.Tables[0];
                Connection.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        public void AddEmployee() {
            string employeeName = Convert.ToString(ctrlName.EditValue);
            string employeeSurname = Convert.ToString(ctrlSurname.EditValue);
            DateTime? dateStart = null ;
            DateTime? dateEnd = null;
            decimal employeeSalary = Convert.ToDecimal(ctrlSalary.EditValue);


            Employee newEmployee = new Employee(employeeName, employeeSurname, dateStart, dateEnd, employeeSalary);


            SqlCommand cmd = new SqlCommand(string.Format(Resources.InsertEmployee, employeeName, employeeSurname, dateStart, dateEnd, employeeSalary), Connection);
  
            Connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employees Succesfully Added");
            Connection.Close();
            PopulateDataGridView();
        }

        private void DeleteEmployee() {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                SqlCommand cmd = new SqlCommand(string.Format(Resources.DeleteEmployee, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Record Succesfully Deleted!");
                Connection.Close();
                PopulateDataGridView();
               
            }
        }

        private void btnView_Click(object sender, EventArgs e) {
            PopulateDataGridView();
            //ResetFields();
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            AddEmployee();
            PopulateDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e) {
            DeleteEmployee();
        }

        private void ctrlDateStart_EditValueChanged(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {

            }

        }
    }
