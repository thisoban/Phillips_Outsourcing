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
    public partial class RegristeerPatient : UserControl
    {
        private static RegristeerPatient _instance;

        public static RegristeerPatient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegristeerPatient();
                return _instance;
            }
        }
        public RegristeerPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sessionid = ""; // heere need to be sessionid
            string Name = firstname.Text;
            string Username = username.Text;
            string Password = password.Text;
            string Email = email.Text;
            //GENDER
            string Adres = adres.Text;
            string Nr = nr.Text;
            string Zipcode = zipcode.Text;
            string City = city.Text;
            string Country = country.Text;
            string Phone = phone.Text;
            var Insulinsensitivity = insulinsensitivity.Text;
           decimal Weight = Convert.ToDecimal(weight.Text);
            int Length = Convert.ToInt32(length.Text);
            DateTime DateNow = DateTime.Now;
            





        }
    }
}
