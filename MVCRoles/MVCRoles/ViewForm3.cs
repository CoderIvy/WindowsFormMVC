using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCRoles
{
    public partial class ViewForm3 : Form, IShapeView
    {
        private PeopleModel theModel;
        Graphics g;

        public ViewForm3()
        {
            InitializeComponent();
            cboSelector.Items.Insert(0,"Show all roles");
            cboSelector.Items.Insert(1, "Show waiter only");
            cboSelector.Items.Insert(2, "Show customer and waiter");            
            cboSelector.Items.Insert(3, "Show waiter and chef");
            g = this.pnlShowArea.CreateGraphics();
        }

        public PeopleModel RoleModel
        {
            set
            {
                theModel = value;
            }
        }

        /// <summary>
        /// refresh view
        /// </summary>
        public void RefreshView()
        {
            clearPanel();
            ArrayList theRolesList = theModel.ModelRoleList;
            AnyPeople[] theRoles = (AnyPeople[])theRolesList.ToArray(typeof(AnyPeople));
     //       Graphics g = this.pnlShowArea.CreateGraphics();

            foreach (AnyPeople r in theRoles)
            {
                r.Display(g);
            }
        }

        /// <summary>
        /// clear panel
        /// </summary>
        private void clearPanel()
        {
      //      pnlShowArea.Controls.Clear();      
            pnlShowArea.CreateGraphics().Clear(pnlShowArea.BackColor);
        }

        /// <summary>
        /// switch to display different item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelector.Text == "Show all roles")
                RefreshView();
            else if (cboSelector.Text == "Show waiter only")
                DisplayWaiter();
            else if (cboSelector.Text == "Show customer and waiter")
                DisplayWaiterCustomer();
            else if (cboSelector.Text == "Show waiter and chef")
                DisplayWaiterChef();
        }


        /// <summary>
        /// display waiter and chef
        /// </summary>
        private void DisplayWaiterChef()
        {
            clearPanel();
            ArrayList theRolesList = theModel.ModelRoleList;
            AnyPeople[] theRoles = (AnyPeople[])theRolesList.ToArray(typeof(AnyPeople));
      //      Graphics g = this.pnlShowArea.CreateGraphics();

            foreach (AnyPeople r in theRoles)
            {
                if (r.name.Equals("waiter") || r.name.Equals("chef")) {
                    r.Display(g);
                }            
            }
        }

        /// <summary>
        /// display waiter and customer
        /// </summary>
        private void DisplayWaiterCustomer()
        {
            clearPanel();
            ArrayList theRolesList = theModel.ModelRoleList;
            AnyPeople[] theRoles = (AnyPeople[])theRolesList.ToArray(typeof(AnyPeople));
      //      Graphics g = this.pnlShowArea.CreateGraphics();

            foreach (AnyPeople r in theRoles)
            {
                if (r.name.Equals("waiter") || r.name.Equals("customer"))
                {
                    r.Display(g);
                }
            }
        }


        /// <summary>
        /// display waiter
        /// </summary>
        private void DisplayWaiter()
        {
            clearPanel();
            ArrayList theRolesList = theModel.ModelRoleList;
            AnyPeople[] theRoles = (AnyPeople[])theRolesList.ToArray(typeof(AnyPeople));
    //        Graphics g = this.pnlShowArea.CreateGraphics();

            foreach (AnyPeople r in theRoles)
            {
                if (r.name.Equals("waiter"))
                {
                    r.Display(g);
                }
            }
        }
    }
}
