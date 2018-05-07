using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using System.Reflection;

namespace CFComponentN18.SessoDropDownList
{


    [ToolboxBitmap(typeof(ComboBox))]
    public partial class SessoDropDownList : ComboBox
    {

        //======================================================================================
        // Private members
        //======================================================================================
        private Dictionary<int,string> data = new Dictionary<int,string>();



        //======================================================================================
        // Constructors
        //======================================================================================
        public SessoDropDownList()
        {
            InitializeComponent();

            this.Size = new Size(201, 24);

            this.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public SessoDropDownList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();


            data.Add(1, "F");
            data.Add(2, "M");

            this.DataSource = new BindingSource(data, null);
            this.DisplayMember = "Value";
            this.ValueMember = "Key";


        }

      
            

       
    }
}
