using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Phillips
{
    public partial class OverzichtPatienten : UserControl
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private static OverzichtPatienten _instance;
        private DataTable dat = new DataTable();
        private int selectedIndex;
        public static OverzichtPatienten Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OverzichtPatienten();
                return _instance;
            }
        }
        public OverzichtPatienten()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1.SetPanel(new WijzigGebruikControl(dat, selectedIndex));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridView1.CurrentCell.RowIndex;
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            string text0 = dataGridView1.SelectedCells[0].Value.ToString();
            string text1 = dataGridView1.SelectedCells[1].Value.ToString();
            string text2 = dataGridView1.SelectedCells[2].Value.ToString();
            string text3 = dataGridView1.SelectedCells[3].Value.ToString();
            string text4 = dataGridView1.SelectedCells[4].Value.ToString();



            Console.WriteLine(text0);
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
        }

        private void OverzichtPatienten_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = bindingSource1;
            GetData(" Goed Command In");
        }

        public void GetData(String SelectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(SelectCommand, "AddConnectionString");

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. 
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dat = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(dat);
                bindingSource1.DataSource = dat;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("Please Replace \"SQLCommand query\" & \"ConnectionString\"");
            }
        }
    }
}
