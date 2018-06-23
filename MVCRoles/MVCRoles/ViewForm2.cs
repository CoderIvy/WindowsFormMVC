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
    public partial class ViewForm2 : Form, IShapeView
    {
        private PeopleModel theModel;
        //for allow dragging or not
        bool dragging;

        //for selected role
        AnyPeople topRole;

        //for role to edit
        AnyPeople editRole;

        //max x, y
        int max_X = 425;
        int max_Y = 425;

        Point lastposition = new Point(0, 0);
        Point curposition = new Point(0, 0);

        Graphics g;

        public ViewForm2()
        {
            InitializeComponent();
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
            //   Graphics g = this.pnlShowArea.CreateGraphics();

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
            //   pnlShowArea.Controls.Clear();
            pnlShowArea.CreateGraphics().Clear(pnlShowArea.BackColor);
        }



        /// <summary>
        /// check if mouse is down set enable roles to move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlShowArea_MouseDown(object sender, MouseEventArgs e)
        {
            ///           MessageBox.Show("pnl mouse down", "Text Info");
            if (topRole != null)
            {
                dragging = true;
            }
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        if (topRole != null) {
                            if (topRole is AnyCustomer)
                            {
                                contextMenu.Items[1].Text = "Order Food";
                            }
                            else if (topRole is AnyWaiter)
                            {
                                contextMenu.Items[1].Text = "Serve Food";
                            }
                            else if (topRole is AnyChef) {
                                contextMenu.Items[1].Text = "Cook Food";
                            }
                        }
                        contextMenu.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }
        }

        /// <summary>
        /// check if mouse is up set moving disable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlShowArea_MouseUp(object sender, MouseEventArgs e)
        {
            //          MessageBox.Show("pnl mouse up", "Text Info");
            dragging = false;

            clearPanel();

            ArrayList theRoleList = theModel.ModelRoleList;
            AnyPeople[] theRoles = (AnyPeople[])theRoleList.ToArray(typeof(AnyPeople));

            if (topRole != null)
            {
                theRoles[0] = topRole;
                topRole.Display(g);
            }
            theModel.UpdateViews();
        }

        /// <summary>
        /// move item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlShowArea_MouseMove(object sender, MouseEventArgs e)
        {
            //       MessageBox.Show("pnlShowArea_MouseMove", "Text Info");
            lastposition = curposition;
            curposition = new Point(e.X, e.Y);

            int xMove = curposition.X - lastposition.X;
            int yMove = curposition.Y - lastposition.Y;

            if (!dragging)
            {
                topRole = null;
                bool needsDisplay = false;

                ArrayList theRoleList = theModel.ModelRoleList;
                AnyPeople[] theRoles = (AnyPeople[])theRoleList.ToArray(typeof(AnyPeople));

                foreach (AnyPeople r in theRoles)
                {
                    if (r.HitTest(new Point(e.X, e.Y)))
                    {
                        topRole = r;
                    }

                    if (r.Highlight == true)
                    {
                        needsDisplay = true;
                        r.Display(g);
                        r.Highlight = false;
                    }

                }

                if (topRole != null)
                {
                    needsDisplay = true;
                    topRole.Display(g);
                    topRole.Highlight = true;
                }

                if (needsDisplay)
                {
                    theModel.UpdateViews();
                }
            }
            else
            {
                topRole.x = topRole.x + xMove;
                topRole.y = topRole.y + yMove;

                theModel.UpdateViews();
            }
        }     

        /// <summary>
        /// show unique behaviour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuBehavior_Click(object sender, EventArgs e)
        {
            string audioFile;
            if (topRole is AnyCustomer)
            {
                if (topRole.atribute.Equals("Male"))
                {                  
                    audioFile = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "mthankyou.wav");
                }
                else
                {
                    audioFile = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "fthankyou.wav");
                }
                topRole.init = false;
                theModel.UpdateViews();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioFile);
                player.Play();
                MessageBox.Show("Customer ordered food", "Order Food");
               
            }
            else if (topRole is AnyWaiter)
            {
                if (topRole.atribute.Equals("Male"))
                {            
                    audioFile = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "menjoy.wav");
                }
                else
                {             
                    audioFile = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "fenjoy.wav");

                }
                topRole.init = false;
                theModel.UpdateViews();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioFile);
                player.Play();
                MessageBox.Show("Waiter served food", "Serve Food");
            }
            else if (topRole is AnyChef) {
              
                topRole.init = false;
                theModel.UpdateViews();
                audioFile = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "alldone.wav");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioFile);
                player.Play();
                MessageBox.Show("Chef cooked food", "Cooked Food");
            }

           
        }

        /// <summary>
        /// delete item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (topRole != null)
            {
                clearPanel();
                theModel.DeleteRole(topRole);
            }
            theModel.UpdateViews();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuOpen_Click(object sender, EventArgs e)
        {         
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theModel.LoadPeople(openFileDialog1.FileName);
                theModel.UpdateViews();
            }
           
        }

        /// <summary>
        /// Serialisation save data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSave_Click(object sender, EventArgs e)
        {         
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theModel.SavePeople(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
