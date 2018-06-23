using System;
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
    public partial class MainForm : Form
    {
        private PeopleModel theModel;
        private PeopleController theController;
        private ViewForm1 frmForm1;
        private ViewForm2 frmForm2;
        private ViewForm3 frmForm3;



        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// init controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeController_Click(object sender, EventArgs e)
        {
            theController = new PeopleController();
        }

        /// <summary>
        /// init model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeModel_Click(object sender, EventArgs e)
        {
            theModel = new PeopleModel(theController);
        }

        /// <summary>
        /// init views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeViews_Click(object sender, EventArgs e)
        {
            frmForm1 = new ViewForm1();
            frmForm2 = new ViewForm2();
            frmForm3 = new ViewForm3();

            frmForm1.RoleModel = theModel;
            frmForm2.RoleModel = theModel;
            frmForm3.RoleModel = theModel;

            theController.AddPeople(frmForm1);
            theController.AddPeople(frmForm2);
            theController.AddPeople(frmForm3);
        }

        /// <summary>
        /// show views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowViews_Click(object sender, EventArgs e)
        {
            frmForm1.Show();
            frmForm2.Show();
            frmForm3.Show();
        }

        /// <summary>
        /// auto setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.completeSetUp();
        }

        /// <summary>
        /// auto setup controller, model and views
        /// </summary>
        private void completeSetUp()
        {
            theController = new PeopleController();
            theModel = new PeopleModel(theController);

            frmForm1 = new ViewForm1();
            frmForm2 = new ViewForm2();
            frmForm3 = new ViewForm3();

            frmForm1.RoleModel = theModel;
            frmForm2.RoleModel = theModel;
            frmForm3.RoleModel = theModel;

            theController.AddPeople(frmForm1);
            theController.AddPeople(frmForm2);
            theController.AddPeople(frmForm3);

            frmForm1.Show();
            frmForm2.Show();
            frmForm3.Show();
        }
    }
}
