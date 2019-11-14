using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phillips
{
    public partial class OverzichtPatienten : UserControl
    {
        private static OverzichtPatienten _instance;
        private DataTable dat;
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
            string[] row0 = { "1", "peeter makleraar", "peter arts", "peter@gmail.com", "0612345678" };
            string[] row1 = { "2", " robin van persie", "peter r de vries", "robin@gmail.com", "040-8373458" };
            string[] row2 = { "3", "josef van woudenstein", "nino verheijen", "josef@gmail.com", "0475-776863" };
            string[] row3 = { "4", "peeter makleraar", "peter arts", "peter@email.com", "0612345678" };
            dataGridView1.Rows.Add(row0);
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);

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
          string text0 =  dataGridView1.SelectedCells[0].Value.ToString();
          string text1 =  dataGridView1.SelectedCells[1].Value.ToString();
          string text2 =  dataGridView1.SelectedCells[2].Value.ToString();
          string text3 =  dataGridView1.SelectedCells[3].Value.ToString();
          string text4 =  dataGridView1.SelectedCells[4].Value.ToString();
         
           
           
            Console.WriteLine(text0);
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
        }
    }
}
