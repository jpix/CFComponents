using CFComponentN18.RegioniDropDownList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = regioniDropDownList1.SelectedItemValue.ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

          

            textBoxCodiceFiscale.Text = cfComponent1.GetCodiceFiscale;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        

        private void regioniDropDownList1_RegioneSelectedValueChanged(object sender, RegioniDropDownList.RegioneSelectedEventArgs e)
        {
          
            this.textBox1.Text = e.ItemValue.ToString();
            provinceDropDownList1.UpdateData(e.ItemValue);
        }

        private void provinceDropDownList1_ProvinciaSelectedValueChanged(object sender, CFComponentN18.ProvinceDropDownList.ProvinceDropDownList.ProvinciaSelectedEventArgs e)
        {
            this.textBox2.Text = e.ItemValue.ToString();
            comuniDropDownList1.UpdateData(e.ItemValue);
        }

        private void comuniDropDownList1_ComuneSelectedValueChanged(object sender, CFComponentN18.ComuniDropDownList.ComuniDropDownList.ComuneSelectedEventArgs e)
        {
            textBox3.Text = e.ItemValue.ToString();
            textBox4.Text = comuniDropDownList1.CodiceComune;
            textBox5.Text = comuniDropDownList1.Provincia;
        }

        private void cfComponent1_AfterCodeCalculated(object sender, CFComponentN18.CFComponent.AfterCalculatedEventArgs e)
        {
            MessageBox.Show("Calculated Code: " + e.CalculatedCF);
        }

        private void cfComponent1_BeforeCodeCalculate(object sender, CFComponentN18.CFComponent.BeforeCalculateEventArgs e)
        {
            if (e.CFData.Cognome.Trim().Equals("")
              ||e.CFData.Nome.Trim().Equals(""))
            {
               
                MessageBox.Show("Invalid entry");
            }
        }
    }
}
