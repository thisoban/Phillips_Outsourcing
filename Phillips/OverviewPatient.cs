using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phillips
{
    public partial class OverviewPatient : Form
    {
        OverzichtPatienten op = new OverzichtPatienten();
        public OverviewPatient()
        {
            InitializeComponent();
            
        }

        private void OverviewPatient_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(op);
        }
        public static void  SetPanel(UserControl uc)
        {
            panel1.Controls.Add(uc);
        }
    }
}
