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
    public partial class ViewForm1 : Form, IShapeView
    {
        private PeopleModel theModel;

        //max x, y
        int max_X = 425;
        int max_Y = 425;

        //list box selected index
        int lstBoxIdx = -1;

        /// <summary>
        /// init role data
        /// </summary>
        public ViewForm1()
        {
            InitializeComponent();
            cboCustomer.Items.Insert(0, "Male");
            cboCustomer.Items.Insert(1, "Female");
            cboWaiter.Items.Insert(0, "Male");
            cboWaiter.Items.Insert(1, "Female");
            cboChef.Items.Insert(0, "ThreeStar");
            cboChef.Items.Insert(1, "FourStar");
            cboChef.Items.Insert(2, "FiveStar");
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            //only allow user input Integer
            System.Text.RegularExpressions.Regex.IsMatch(txtX.Text, "[ ^ 0-9]");
            System.Text.RegularExpressions.Regex.IsMatch(txtY.Text, "[ ^ 0-9]");
        }

        /// <summary>
        /// init model
        /// </summary>
        public PeopleModel RoleModel
        {
            set
            {
                theModel = value;
            }
        }

        /// <summary>
        /// add role to views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            int x, y;
            AnyPeople aPeople;
            bool isValidInput = false;

            try
            {
                if ((txtX.Text.ToString() == "") || (txtY.Text.ToString() == ""))
                {
                    MessageBox.Show("Please enter position x and y", "Required Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    isValidInput = InputValid(txtX.Text.ToString(), txtY.Text.ToString());

                    if (isValidInput)
                    {
                        x = Convert.ToInt32(txtX.Text.ToString());
                        y = Convert.ToInt32(txtY.Text.ToString());


                        if (radiobtnCustomer.Checked)
                        {
                            aPeople = new AnyCustomer("customer", x, y, cboCustomer.Text.ToString(), true);
                            theModel.AddRole(aPeople);
                        }
                        else if (radioBtnChef.Checked)
                        {
                            aPeople = new AnyChef("chef", x, y, cboChef.Text.ToString(), true);
                            theModel.AddRole(aPeople);

                        }
                        else if (radioBtnWaiter.Checked)
                        {
                            aPeople = new AnyWaiter("waiter", x, y, cboWaiter.Text.ToString(),true);
                            theModel.AddRole(aPeople);
                        }

                    }
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n");
            }
        }

        /// <summary>
        /// update role's info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //radiobtnCustomer.Enabled = false;
            //radioBtnWaiter.Enabled = false;
            //radioBtnChef.Enabled = false;

            if (lstBoxIdx != -1)
            {
                AnyPeople updateRole = (AnyPeople)theModel.ModelRoleList[lstBoxIdx];


                if (txtX.Text.ToString() != "")
                {
                    updateRole.x = Convert.ToInt32(txtX.Text.ToString());
                }

                //if (!String.IsNullOrEmpty(txtY.Text.ToString()))
                if (txtY.Text.ToString() != "")
                {
                    updateRole.y = Convert.ToInt32(txtY.Text.ToString());
                }

                theModel.UpdateRoleInfo(lstBoxIdx, updateRole);
            }
        }


        /// <summary>
        /// select to create a customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radiobtnCustomer_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            cboChef.Enabled = false;
            cboCustomer.Enabled = true;
            cboWaiter.Enabled = false;
        }

        /// <summary>
        /// select to create a waiter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioBtnWaiter_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            cboCustomer.Enabled = false;
            cboWaiter.Enabled = true;
            cboChef.Enabled = false;
        }

        /// <summary>
        /// select to create a chef
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioBtnChef_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            cboCustomer.Enabled = false;
            cboChef.Enabled = true;
            cboWaiter.Enabled = false;
        }

        /// <summary>
        /// delete select item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBoxIdx != -1)
            {
                theModel.DeleteRole(lstBoxIdx);
            }
        }

        /// <summary>
        /// get current index when selecting different items in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstboxShowArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            ClearInput();

            // if (!String.IsNullOrEmpty(lstboxShowArea.SelectedItem.ToString())) {
         
                // Get the currently selected item in the ListBox.
                string curItem = lstboxShowArea.SelectedItem.ToString();

                // Find the string in ListBox2.
                lstBoxIdx = lstboxShowArea.FindString(curItem);

        }

        /// <summary>
        /// check input value is valid or not
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool InputValid(string x, string y)
        {
            int x_pos, y_pos;
            bool validInput = false;

            x_pos = Convert.ToInt32(x);
            y_pos = Convert.ToInt32(y);

            if (x_pos > max_X || y_pos > max_Y)
            {
                MessageBox.Show("Maximum value for X is " + max_X + ".\r\n" +
                    "Maximum value for Y is " + max_Y, "Please check the input values",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                validInput = true;
            }
            return validInput;
        }

        /// <summary>
        /// refresh view
        /// </summary>
        public void RefreshView()
        {
            lstboxShowArea.Items.Clear();
            ArrayList theRolesList = theModel.ModelRoleList;
            AnyPeople[] theRoles = (AnyPeople[])theRolesList.ToArray(typeof(AnyPeople));
            //       Graphics g = this.pnlShowArea.CreateGraphics();

            foreach (AnyPeople r in theRoles)
            {
                lstboxShowArea.Items.Add(r);
            }
        }

        /// <summary>
        /// clear user input
        /// </summary>
        public void ClearInput()
        {
            txtX.Text = "";
            txtY.Text = "";
        }

    }
}
