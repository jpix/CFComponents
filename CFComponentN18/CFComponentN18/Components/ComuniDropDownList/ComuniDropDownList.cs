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

namespace CFComponentN18.ComuniDropDownList
{


    [DefaultEvent("ComuneSelectedValueChanged")]
    [ToolboxBitmap(typeof(ComboBox))]
    public partial class ComuniDropDownList : ComboBox
    {

        //======================================================================================
        // Private members
        //======================================================================================
        private CDataBase db;
        private DataSet ds;
        private string m_FirstItem = "Scegli un Comune (-- -- -- )";
        private ComuneSelectedEventArgs ComuneSelected = new ComuneSelectedEventArgs();
        private CDataBase db2 = new CDataBase();
        private DataSet ds2 = new DataSet();




        //default ctor
        public ComuniDropDownList()
        {
            InitializeComponent();

            this.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Size = new Size(479, 24);

            this.SelectedItem = -1;
        }

        public ComuniDropDownList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            db = new CDataBase();
            ds = new DataSet();

            ds = db.GetComuniFromSDF_V2(-1,-1);


            this.DataSource = ds.Tables[0];

            this.ValueMember = "id_progressivo";

            this.DisplayMember = "denominazione_in_italiano";

            Initialize(null, null);

        }


        //======================================================================================
        // Public methods
        //======================================================================================
        public void UpdateData(int ItemValue)
        {

            if (ItemValue == -1)
            {
                ds = db.GetComuniFromSDF_V2(-1,ItemValue);
                this.DataSource = ds.Tables[0];

                Initialize(null, null);
                this.SelectedIndex = 0;
                m_codice_comune = "";
                m_provincia = "";

                return;
            }

            ds = db.GetComuniFromSDF_V2(-1,ItemValue);
            this.DataSource = ds.Tables[0];

           
        }


        //======================================================================================
        // Private methods
        //======================================================================================

        private void GetComuneDetalis(int IDComune)
        {
            ds2 = db2.GetComuneDataFromSDF_V2(IDComune);

            try
            {
                m_codice_comune = ds2.Tables[0].Rows[0]["codice_catastale_del_comune"].ToString();
                m_provincia = ds2.Tables[0].Rows[0]["sigla_automobilistica"].ToString();
            }
            catch { }

        }


        private void ComuniDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComuneSelected.ItemIndex = this.SelectedIndex;
            ComuneSelected.ItemText = this.Text;

            OnComuneSelected(sender, ComuneSelected);

        }

        private void ComuniDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComuneSelected.ItemValue = (int)this.SelectedValue;
                ComuneSelected.ItemText = this.Text;
                GetComuneDetalis((int)this.SelectedValue);
            }
            catch
            {
                ComuneSelected.ItemValue = -1;
                ComuneSelected.ItemText = "";
                GetComuneDetalis(-1);

            }

            OnComuneValueChanged(sender, ComuneSelected);
        }


        //======================================================================================
        // Properties
        //======================================================================================

        private string m_codice_comune;
        public string CodiceComune
        {
            get { return m_codice_comune; }
            set { m_codice_comune = value; }
        }


        private string m_provincia;
        public string Provincia
        {
            get { return m_provincia; }
            set { m_provincia = value; }
        }
        

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




        //======================================================================================
        // Private methods
        //======================================================================================
        private void Initialize(object sender, EventArgs e)
        {

          
            ds.Tables[0].Rows.InsertAt(ds.Tables[0].NewRow(), 0);
            ds.Tables[0].Rows[0]["id_progressivo"] = "-1";
            ds.Tables[0].Rows[0]["denominazione_in_italiano"] = m_FirstItem;
            


        }


        //======================================================================================
        // Events and delegates
        //======================================================================================
        public delegate void ComuneSelectedEventHandler(object sender, ComuneSelectedEventArgs e);
        [Category("Events")]
        public event ComuneSelectedEventHandler ComuneSelectedIndexChanged;
        [Category("Events")]
        public event ComuneSelectedEventHandler ComuneSelectedValueChanged;

        //Custom EventArgs class
        //----------------------------------------
        public class ComuneSelectedEventArgs : EventArgs
        {


            public int ItemIndex { get; set; }
            public int ItemValue { get; set; }
            public string ItemText { get; set; }



            public ComuneSelectedEventArgs(int newSelectedIndex, int newSelectedValue)
            {
               
                ItemIndex = newSelectedIndex;
                ItemValue = newSelectedValue;

            }

            // default ctor
            public ComuneSelectedEventArgs()
            {
                ItemIndex = -1;
                ItemValue = -1;
            }



        }
        //----------------------------------------

        //SelectIndex
        protected virtual void OnComuneSelected(object sender, ComuneSelectedEventArgs e)
        {
            // Raise the event 
            ComuneSelectedIndexChanged?.Invoke(this, e);

            m_SelectedItemIndex = e.ItemIndex;

            m_SelectedItemText = e.ItemText;

        }

        //SelectValue
        protected virtual void OnComuneValueChanged(object sender, ComuneSelectedEventArgs e)
        {
            // Raise the event 
            ComuneSelectedValueChanged?.Invoke(this, e);

            m_SelectedItemValue = e.ItemValue;

            m_SelectedItemText = e.ItemText;
                  
           
        }


       
    }
}
