using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace CFComponentN18.ProvinceDropDownList
{


    [DefaultEvent("ProvinciaSelectedValueChanged")]
    [ToolboxBitmap(typeof(ComboBox))]
    public partial class ProvinceDropDownList : ComboBox
    {


        //======================================================================================
        // Private members
        //======================================================================================
        private CDataBase db;
        private DataSet ds;
        private string m_FirstItem = "Scegli una Provincia (-- -- -- )";
        private ProvinciaSelectedEventArgs ProvinciaSelected = new ProvinciaSelectedEventArgs();



        //======================================================================================
        // Constructors
        //======================================================================================
        //default ctor
        public ProvinceDropDownList()
        {
            InitializeComponent();
            this.DropDownStyle = ComboBoxStyle.DropDownList;
         
            this.Size = new Size(201, 24);

            this.SelectedItem = -1;
        }

        public ProvinceDropDownList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            db = new CDataBase();
            ds = new DataSet();

            ds = db.GetProvinceFromSDF_V2(-1);

            this.DataSource = ds.Tables[0];

            this.ValueMember = "codice_provincia";

            this.DisplayMember = "provincia";

            Initialize(null, null);


        }


        //======================================================================================
        // Public methods
        //======================================================================================
        public void UpdateData(int ItemValue)
        {

            if(ItemValue == -1)
            {
                ds = db.GetProvinceFromSDF_V2(-1);
                this.DataSource = ds.Tables[0];

                Initialize(null,null);
                this.SelectedIndex = 0;
                return;
            }

            ds = db.GetProvinceFromSDF_V2(ItemValue);
            this.DataSource = ds.Tables[0];

        }


        //======================================================================================
        // Private methods
        //======================================================================================
        private void ProvinceDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            ProvinciaSelected.ItemIndex = this.SelectedIndex;
            ProvinciaSelected.ItemText = this.Text;

            OnProvinciaSelected(sender, ProvinciaSelected);
        }


        private void ProvinceDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ProvinciaSelected.ItemValue = (int)this.SelectedValue;
                ProvinciaSelected.ItemText = this.Text;
            }
            catch
            {
                ProvinciaSelected.ItemValue = -1;
                ProvinciaSelected.ItemText = "";
            }

            OnProvinciaValueChanged(sender, ProvinciaSelected);
        }



        //======================================================================================
        // Properties
        //======================================================================================
        private int m_SelectedItemIndex;
        [Browsable(true)]
        [Category("Data Fields")]
        public int SelectedItemIndex
        {
            get { return m_SelectedItemIndex; }
            //set { m_SelectedItemIndex = value; }
        }


        private int m_SelectedItemValue;
        [Browsable(true)]
        [Category("Data Fields")]
        public int SelectedItemValue
        {
            get { return m_SelectedItemValue; }
            //set { m_SelectedItemValue = value; }
        }


        private string m_SelectedItemText;
        [Browsable(true)]
        [Category("Data Fields")]
        public string SelectedItemText
        {
            get { return m_SelectedItemText; }
            //set { m_SelectedItemText = value; }
        }


        private void Initialize(object sender, EventArgs e)
        {


            ds.Tables[0].Rows.InsertAt(ds.Tables[0].NewRow(), 0);
            ds.Tables[0].Rows[0]["codice_regione"] = "-1";
            ds.Tables[0].Rows[0]["codice_provincia"] = "-1";
            ds.Tables[0].Rows[0]["provincia"] = m_FirstItem;



        }


        //======================================================================================
        // Events and delegates
        //======================================================================================
        public delegate void ProvinciaSelectedEventHandler(object sender, ProvinciaSelectedEventArgs e);
        [Category("Events")]
        public event ProvinciaSelectedEventHandler ProvinciaSelectedIndexChanged;
        [Category("Events")]
        public event ProvinciaSelectedEventHandler ProvinciaSelectedValueChanged;

        //Custom EventArgs class
        //----------------------------------------
        public class ProvinciaSelectedEventArgs : EventArgs
        {


            public int ItemIndex { get; set; }
            public int ItemValue { get; set; }
            public string ItemText { get; set; }



            public ProvinciaSelectedEventArgs(int newSelectedIndex, int newSelectedValue)
            {
                
                ItemIndex = newSelectedIndex;
                ItemValue = newSelectedValue;

            }

            // default ctor
            public ProvinciaSelectedEventArgs()
            {
                ItemIndex = -1;
                ItemValue = -1;
            }



        }
        //----------------------------------------



        //SelectIndex
        protected virtual void OnProvinciaSelected(object sender, ProvinciaSelectedEventArgs e)
        {
            // Raise the event 
            ProvinciaSelectedIndexChanged?.Invoke(this, e);

            m_SelectedItemIndex = e.ItemIndex;

            m_SelectedItemText = e.ItemText;
                       
        }

        //SelectValue
        protected virtual void OnProvinciaValueChanged(object sender, ProvinciaSelectedEventArgs e)
        {
            // Raise the event 
            ProvinciaSelectedValueChanged?.Invoke(this, e);

            m_SelectedItemValue = e.ItemValue;

            m_SelectedItemText = e.ItemText;

        }



        

       
    }
}
