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

    public partial class WijzigGebruikControl : UserControl
    {
        int  lengte, insuline, tel, adresNr;
        double gewicht;
        string id, voornaam, achternaam, geslacht, adres, postcode, stad, pf,email, country;

        private void uploadBt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pf = openFileDialog1.FileName;
            }
        }
    


        public WijzigGebruikControl()
        {
            InitializeComponent();
        }

        private void WijzigenBt_Click(object sender, EventArgs e)
        {
            id = IdTb.Text;
            voornaam = VoorNaamTb.Text;
            achternaam = AchterNaamTb.Text;
            geslacht = GeslachtCb.SelectedItem.ToString();
            lengte = Convert.ToInt32(LengteTb.Text);
            gewicht = Convert.ToDouble(GewichtTb.Text);
            insuline = Convert.ToInt32(InsulineTb.Text);
            adres = CountryTb.Text;
            postcode = PostCodeTb.Text;
            tel = Convert.ToInt32(TelTb.Text);
            adresNr = Convert.ToInt32(AdresNrTb.Text);
            email = EmailTb.Text;
            stad = StadTb.Text;
            PfPb.Image = Image.FromFile(pf); 
            country = CountryTb.Text;
            //PostViaWebREquest
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public WijzigGebruikControl(DataTable dat, int RowIndex)
        {
            IdTb.Text = dat.Rows[RowIndex][0].ToString();
            VoorNaamTb.Text = dat.Rows[RowIndex][1].ToString();
            AchterNaamTb.Text = dat.Rows[RowIndex][2].ToString();
            if (dat.Rows[RowIndex][3].ToString() == "Man")
            {
                GeslachtCb.SelectedIndex = 1;
            }
            else
            {
                GeslachtCb.SelectedIndex = 2;
            }
            LengteTb.Text = dat.Rows[RowIndex][4].ToString();
            GewichtTb.Text = dat.Rows[RowIndex][5].ToString();
            InsulineTb.Text = dat.Rows[RowIndex][6].ToString();
            CountryTb.Text = dat.Rows[RowIndex][7].ToString();
            PostCodeTb.Text = dat.Rows[RowIndex][8].ToString();
            TelTb.Text = dat.Rows[RowIndex][9].ToString();
            AdresNrTb.Text = dat.Rows[RowIndex][10].ToString();
            EmailTb.Text = dat.Rows[RowIndex][11].ToString();
            StadTb.Text = dat.Rows[RowIndex][12].ToString();
            PfPb.Image = Image.FromFile(dat.Rows[RowIndex][13].ToString());

        }
    }
}
