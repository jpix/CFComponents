using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CFComponentN18.RegioniDropDownList;

namespace CFComponentN18
{

    [Designer(typeof(CCodiceFiscaleSmartTags))]
    public partial class CFComponent: Component, ICodiceFiscale
    {

        //======================================================================================
        // Private members
        //======================================================================================
        private CCodiceFiscale m_CcodiceFiscale;


         
        // Events
        /****************************************************************/
        //After Calculated

        public delegate void AfterCalculatedEventHandler(object sender, AfterCalculatedEventArgs e);
        [Category("Events")]
        public event AfterCalculatedEventHandler AfterCodeCalculated;

        public class AfterCalculatedEventArgs : EventArgs
        {
            
            public string CalculatedCF { get; set; }

            public AfterCalculatedEventArgs(){ }
        }

        protected virtual void OnAfterCodeCalculated(AfterCalculatedEventArgs e)
        {
            // Raise the event
            AfterCodeCalculated?.Invoke(this, e);
            
        }
        /******************************************************************/



        /****************************************************************/
        //Before Calculate

        public delegate void BeforeCalculateEventHandler(object sender, BeforeCalculateEventArgs e);
        [Category("Events")]
        public event BeforeCalculateEventHandler BeforeCodeCalculate;

        public class BeforeCalculateEventArgs : EventArgs
        {

            
            public CFDataMembers CFData;

            public BeforeCalculateEventArgs() {
                CFData = new CFDataMembers();
            }
        }

        protected virtual void OnBeforeCodeCalculate(BeforeCalculateEventArgs e)
        {
            // Raise the event
            BeforeCodeCalculate?.Invoke(this, e);

        }
        /******************************************************************/


        //======================================================================================
        // Constructors
        //======================================================================================
        public CFComponent()
        {
            InitializeComponent();
            m_about_component = "Codice Fiscale Persone Fisiche 2018 Components";
            m_copyright = "Copyright © 2018 Giuseppe Pischedda. All rights reserved";
                                 

        }

        public CFComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            //Class CCodiceFIscale Initialization
            m_CcodiceFiscale = new CCodiceFiscale();


            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("it-IT");


            ComuniDropDownList = new ComuniDropDownList.ComuniDropDownList();
            ProvinceDropDownList = new ProvinceDropDownList.ProvinceDropDownList();
            RegioniDropDownList = new RegioniDropDownList.RegioniDropDownList();
            CognomeTextBox = new CognomeTextBox.CognomeTextBox();
            NomeTextBox = new NomeTextBox.NomeTextBox();
            DataNascitaPicker = new DataNascitaPicker.DataNascitaPicker();
            SessoDropDownList = new SessoDropDownList.SessoDropDownList();

           


        }

        //======================================================================================
        // Properties
        //======================================================================================
        private string m_about_component;
        public string About
        {
            get { return m_about_component; }
            
        }

        private string m_copyright;
        public string Copyright
        {
            get { return m_copyright; }
        }

        [Browsable(false)]
        public string GetCodiceFiscale
        {
            get {

                
                try
                {
                   
                        m_CcodiceFiscale.CFMembers.Cognome = m_CognomeTextBox.Text;
                        m_CcodiceFiscale.CFMembers.Nome = m_NomeTextBox.Text;
                        m_CcodiceFiscale.CFMembers.RegioneDiNascita = m_RegioniDropDownList.SelectedItemText;
                        m_CcodiceFiscale.CFMembers.ProvinciaDiNascita = m_ProvinceDropDownList.SelectedItemText;
                        m_CcodiceFiscale.CFMembers.ComuneDiNascita = m_ComuniDropDownList.SelectedItemText;
                        m_CcodiceFiscale.CFMembers.DataDiNascita = m_DataNascitaPicker.Value;
                        m_CcodiceFiscale.CFMembers.CodiceISTATComune = m_ComuniDropDownList.CodiceComune;
                        m_CcodiceFiscale.CFMembers.Sesso = m_SessoDropDownList.Text;
                        m_CcodiceFiscale.CFMembers.TargaAutomobilistica = m_ComuniDropDownList.Provincia;

                    try
                    {

                        BeforeCalculateEventArgs bEv = new BeforeCalculateEventArgs();
                        bEv.CFData = m_CcodiceFiscale.CFMembers;
                        BeforeCodeCalculate(null, bEv);
                    }
                    catch { }

                    
                }
                catch
                {

                    return "Error!";
                }

                try
                {
                    AfterCalculatedEventArgs aEv = new AfterCalculatedEventArgs();
                    aEv.CalculatedCF = m_CcodiceFiscale.GetCodiceFiscale;
                    AfterCodeCalculated(null, aEv);
                }
                catch { }

                return m_CcodiceFiscale.GetCodiceFiscale;

            }
        }


        private RegioniDropDownList.RegioniDropDownList m_RegioniDropDownList;
        [Browsable(true)]
        [Category("Data Fields")]
        public  RegioniDropDownList.RegioniDropDownList RegioniDropDownList {

            get { return this.m_RegioniDropDownList; }
            set { m_RegioniDropDownList = value; }

        }

        private ProvinceDropDownList.ProvinceDropDownList m_ProvinceDropDownList;
        [Browsable(true)]
        [Category("Data Fields")]
        public  ProvinceDropDownList.ProvinceDropDownList ProvinceDropDownList {
            get { return m_ProvinceDropDownList; }
            set { m_ProvinceDropDownList = value; }
        }


        private ComuniDropDownList.ComuniDropDownList m_ComuniDropDownList;
        [Browsable(true)]
        [Category("Data Fields")]
        public  ComuniDropDownList.ComuniDropDownList ComuniDropDownList
        {
            get { return m_ComuniDropDownList; }
            set { m_ComuniDropDownList = value; }
        }


        private CognomeTextBox.CognomeTextBox m_CognomeTextBox;
        [Browsable(true)]
        [Category("Data Fields")]
        public  CognomeTextBox.CognomeTextBox CognomeTextBox
        {
            get { return m_CognomeTextBox; }
            set { m_CognomeTextBox = value; }
        }

        private NomeTextBox.NomeTextBox m_NomeTextBox;
        [Browsable(true)]
        [Category("Data Fields")]
        public  NomeTextBox.NomeTextBox NomeTextBox
        {
            get { return m_NomeTextBox; }
            set { m_NomeTextBox = value; }
        }


        private DataNascitaPicker.DataNascitaPicker m_DataNascitaPicker;
        [Browsable(true)]
        [Category("Data Fields")]
        public  DataNascitaPicker.DataNascitaPicker DataNascitaPicker
        {
            get { return m_DataNascitaPicker; }
            set { m_DataNascitaPicker = value; }
        }


        private SessoDropDownList.SessoDropDownList m_SessoDropDownList;
        [Browsable(true)]
        [Category("Data Fields")]
        public SessoDropDownList.SessoDropDownList SessoDropDownList
        {
            get { return m_SessoDropDownList; }
            set { m_SessoDropDownList = value; }
        }

              

            
        
    }
}
