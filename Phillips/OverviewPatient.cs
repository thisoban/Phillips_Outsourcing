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
        public OverviewPatient()
        {
            InitializeComponent();
            
        }

        private void OverviewPatient_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(OverzichtPatienten.Instance);
        }
    }
}
