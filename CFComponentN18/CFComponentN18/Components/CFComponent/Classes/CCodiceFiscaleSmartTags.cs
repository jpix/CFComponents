using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CFComponentN18
{

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class CCodiceFiscaleSmartTags: ComponentDesigner //ControlDesigner class if this is an UserControl
    {

        private System.ComponentModel.Design.DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu.
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new System.ComponentModel.Design.DesignerActionListCollection();
                    actionLists.Add(new CFComponentActionList(this.Component));
                }
                return actionLists;
            }
        }

    }



    public class CFComponentActionList : System.ComponentModel.Design.DesignerActionList
    {
        private CFComponentN18.CFComponent m_cfComponent;

        private System.ComponentModel.Design.DesignerActionUIService designerActionUISvc = null;

        //The constructor associates the control with the smart tag list.
        public CFComponentActionList(IComponent component) : base(component)
        {
            
            this.m_cfComponent = component as CFComponentN18.CFComponent;

            // Cache a reference to DesignerActionUIService, 
            // so the DesigneractionList can be refreshed.
            this.designerActionUISvc =
                GetService(typeof(System.ComponentModel.Design.DesignerActionUIService)) as
                System.ComponentModel.Design.DesignerActionUIService;
        }

        


        public override System.ComponentModel.Design.DesignerActionItemCollection GetSortedActionItems()
        {
            System.ComponentModel.Design.DesignerActionItemCollection items = new System.ComponentModel.Design.DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new System.ComponentModel.Design.DesignerActionHeaderItem("Data Fields"));

            items.Add(new System.ComponentModel.Design.DesignerActionPropertyItem("CognomeTextBox",
                                 "Cognome control", null,
                                 "Get or Set Cognome field."));


            items.Add(new System.ComponentModel.Design.DesignerActionPropertyItem("NomeTextBox",
                                "Nome control", null,
                                "Get or Set Nome field."));


            items.Add(new System.ComponentModel.Design.DesignerActionPropertyItem("SessoDropDownList",
                               "Sesso control", null,
                               "Get or Set Sesso field."));


            items.Add(new System.ComponentModel.Design.DesignerActionPropertyItem("DataNascitaPicker",
                               "Data di Nascita control", null,
                               "Get or Set Data di Nascita field."));


            items.Add(new System.ComponentModel.Design.DesignerActionPropertyItem("RegioniDropDownList",
                              "Regione di Nascita control", null,
                              "Get or Set Regione di Nascita field."));

            items.Add(new System.ComponentModel.Design.DesignerActionPropertyItem("ProvinceDropDownList",
                             "Provincia di Nascita control", null,
                             "Get or Set Provincia di Nascita field."));


            items.Add(new System.ComponentModel.Design.DesignerActionPropertyItem("ComuniDropDownList",
                             "Comune di Nascita control", null,
                             "Get or Set Comune di Nascita field."));


            return items;
        }


        private PropertyDescriptor GetPropertyByName(string propName)
        {
            PropertyDescriptor prop = default(PropertyDescriptor);

            prop = TypeDescriptor.GetProperties(m_cfComponent)[propName];
            if (prop == null)
            {
                throw new ArgumentException("Invalid Property", propName);
            }
            else
            {
                return prop;
            }

        }

        public CognomeTextBox.CognomeTextBox CognomeTextBox
        {
            get { return m_cfComponent.CognomeTextBox; }
            set { GetPropertyByName("CognomeTextBox").SetValue(m_cfComponent, value); }
        }

        public NomeTextBox.NomeTextBox NomeTextBox
        {
            get { return m_cfComponent.NomeTextBox; }
            set { GetPropertyByName("NomeTextBox").SetValue(m_cfComponent, value); }
        }


        public SessoDropDownList.SessoDropDownList SessoDropDownList
        {
            get { return m_cfComponent.SessoDropDownList; }
            set { GetPropertyByName("SessoDropDownList").SetValue(m_cfComponent, value); }
        }


        public DataNascitaPicker.DataNascitaPicker DataNascitaPicker
        {
            get { return m_cfComponent.DataNascitaPicker; }
            set { GetPropertyByName("DataNascitaPicker").SetValue(m_cfComponent, value); }
        }


        public RegioniDropDownList.RegioniDropDownList RegioniDropDownList
        {
            get { return m_cfComponent.RegioniDropDownList; }
            set { GetPropertyByName("RegioniDropDownList").SetValue(m_cfComponent, value); }
        }

        public ProvinceDropDownList.ProvinceDropDownList ProvinceDropDownList
        {
            get { return m_cfComponent.ProvinceDropDownList; }
            set { GetPropertyByName("ProvinceDropDownList").SetValue(m_cfComponent, value); }
        }


        public ComuniDropDownList.ComuniDropDownList ComuniDropDownList
        {
            get { return m_cfComponent.ComuniDropDownList; }
            set { GetPropertyByName("ComuniDropDownList").SetValue(m_cfComponent, value); }
        }


    }


}
