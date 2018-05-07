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

namespace CFComponentN18.RegioniDropDownList
{


    [DefaultEvent("RegioneSelectedValueChanged")]
    [ToolboxBitmap(typeof(ComboBox))]
    public partial class RegioniDropDownList : ComboBox
    {

        //======================================================================================
        // Private members
        //======================================================================================
        private CDataBase db;
        private DataSet ds;

        private string m_FirstItem = "Scegli una Regione (-- -- -- )";
        private RegioneSelectedEventArgs RegioneSelected = new RegioneSelectedEventArgs();



        //======================================================================================
        // Properties
        //======================================================================================

        private int m_SelectedItemIndex;
        [Browsable(true)]
        [Category("Data Fields")]
        public int SelectedItemIndex {
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
        // Constructors
        //======================================================================================
        //default ctor
        public RegioniDropDownList()
        {
            InitializeComponent();

            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Size = new Size(201, 24);

            this.SelectedItem = -1;
            

        }

        public RegioniDropDownList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            
            db = new CDataBase();
            ds = new DataSet();

            ds = db.GetRegionsFromSDF_V2();

            this.DataSource = ds.Tables[0];
            
            this.ValueMember = "codice_regione";

            this.DisplayMember = "denominazione_regione";

            Initialize(null,null);
            
        }


        //======================================================================================
        // Private methods
        //======================================================================================
        private void Initialize(object sender, EventArgs e)
        {

            ds.Tables[0].Rows.InsertAt(ds.Tables[0].NewRow(), 0);
            ds.Tables[0].Rows[0]["codice_regione"] = "-1";
            ds.Tables[0].Rows[0]["denominazione_regione"] = m_FirstItem;
            
        }

        private void RegioniDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {


            RegioneSelected.ItemIndex = this.SelectedIndex;
            RegioneSelected.ItemText = this.Text;

            OnRegioneSelected(sender, RegioneSelected);
        }


        private void RegioniDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                RegioneSelected.ItemValue = (int)this.SelectedValue;
                RegioneSelected.ItemText = this.Text;
            }
            catch
            {
                RegioneSelected.ItemValue = -1;
                RegioneSelected.ItemText = "";
            }

            OnRegioneValueChanged(sender, RegioneSelected);
        }


        //======================================================================================
        // Events and delegates
        //======================================================================================

        public delegate void RegioneSelectedEventHandler(object sender, RegioneSelectedEventArgs e);
        [Category("Events")]
        public event RegioneSelectedEventHandler RegioneSelectedIndexChanged;
        [Category("Events")]
        public event RegioneSelectedEventHandler RegioneSelectedValueChanged;

        //Custom EventArgs class
        //----------------------------------------
        public class RegioneSelectedEventArgs : EventArgs
        {

           
            public int ItemIndex   { get; set; }            
            public int ItemValue   { get; set; }
            public string ItemText { get; set; }



            public RegioneSelectedEventArgs(int newSelectedIndex,int newSelectedValue)
            {
                
                ItemIndex = newSelectedIndex;
                ItemValue = newSelectedValue;
                
            }

            // default ctor
            public RegioneSelectedEventArgs()
            {
                ItemIndex = -1;
                ItemValue = -1;
            }



        }
        //----------------------------------------


        //SelectIndex
        protected virtual void OnRegioneSelected(object sender, RegioneSelectedEventArgs e)
        {
            // Raise the event 
           RegioneSelectedIndexChanged?.Invoke(this, e);

           m_SelectedItemIndex = e.ItemIndex;

           m_SelectedItemText = e.ItemText;

           
        }

        //SelectValue
        protected virtual void OnRegioneValueChanged(object sender , RegioneSelectedEventArgs e)
        {
            // Raise the event 
            RegioneSelectedValueChanged?.Invoke(this, e);

            m_SelectedItemValue = e.ItemValue;

            m_SelectedItemText = e.ItemText;

        }

       
        
    }
}
