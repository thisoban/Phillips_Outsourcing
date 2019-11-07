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
            string[] row0 = { "1", "peeter makleraar", "peter arts", "peter@gmail.com","0612345678"  };
            string[] row1 = { "2", " robin van persie", "peter r de vries", "robin@gmail.com","040-8373458"  };
            string[] row2 = { "3", "josef van woudenstein", "nino verheijen", "josef@gmail.com","0475-776863"  };
            string[] row3 = { "4", "peeter makleraar", "peter arts", "peter@email.com","0612345678"  };
            dataGridView1.Rows.Add(row0);
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
