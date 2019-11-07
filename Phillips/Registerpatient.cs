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
    public partial class Registerpatient : Form
    {
        public Registerpatient()
        {
           
            InitializeComponent();
        }

        private void Registerpatient_Load(object sender, EventArgs e)
        {
            RegisterPanel.Controls.Add(RegristeerPatient.Instance);
        }
    }
}
