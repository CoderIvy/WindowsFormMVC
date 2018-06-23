using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCRoles
{
    
    public class PeopleModel
    {
        private ArrayList modelRolesList;
        private PeopleController theController;

        public PeopleModel(PeopleController controller) {
            modelRolesList = new ArrayList();
            theController = controller;
        }

        /// <summary>
        /// get model roles list
        /// </summary>
        public ArrayList ModelRoleList {
            get {
                return modelRolesList;
            }
        }

        /// <summary>
        /// add role to the rolesList
        /// </summary>
        /// <param name="view"></param>
        public void AddRole(AnyPeople role) {
            modelRolesList.Add(role);
            UpdateRoles();
        }

        /// <summary>
        /// delete role by index
        /// </summary>
        /// <param name="idx"></param>
        public void DeleteRole(int idx) {
            modelRolesList.RemoveAt(idx);
            UpdateRoles();
        }

        /// <summary>
        /// delete role by value
        /// </summary>
        /// <param name="aPerson"></param>
        public void DeleteRole(AnyPeople aPerson)
        {
            modelRolesList.Remove(aPerson);
            UpdateRoles();
        }

        /// <summary>
        /// update role's info
        /// </summary>
        /// <param name="idx"></param>
        /// <param name="role"></param>
        public void UpdateRoleInfo(int idx, AnyPeople role) {
            modelRolesList[idx] = role;
            UpdateRoles();
        }

        /// <summary>
        /// update view
        /// </summary>
        private void UpdateRoles()
        {
            UpdateViews();
        }


        /// <summary>
        /// refresh all views
        /// </summary>
        public void UpdateViews()
        {
            theController.UpdateViews();
        }


        //TODO: sent to back, bring to front
        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        public void SentToBack(AnyPeople role) {
            ArrayList sortList = new ArrayList();

            int max = modelRolesList.IndexOf(role);

            sortList.Add(role);

            for (int i = 0; i < max; i++) {
                sortList.Add(modelRolesList[i]);
            }

            for (int i = 0; i < max; i++)
            {
                modelRolesList.Add(sortList[i]);
            }
            UpdateViews();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        public void BringToFront(IShapeView view)
        {
            ArrayList sortList = new ArrayList();

            int max = modelRolesList.IndexOf(view);

            sortList.Add(view);

            for (int i = max+1; i < modelRolesList.Count; i++)
            {
                sortList[i-1] = modelRolesList[i];
            }

            for (int i = 0; i < sortList.Count; i++)
            {
                modelRolesList[i] = sortList[i];
            }
            UpdateViews();
        }

        /// <summary>
        /// Serialisation save data
        /// </summary>
        /// <param name="fileName"></param>
        public void SavePeople(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            AnyPeople[] people = (AnyPeople[])modelRolesList.ToArray(typeof(AnyPeople));

            foreach (AnyPeople p in people) {
                sb.Append(p.ToString()+"#");
            }
            string temp = sb.ToString();

            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(sb);
            sw.Close();
        }

        internal void LoadPeople(string fileName)
        {

            //-------------
            modelRolesList.Clear(); //should really ask if they want to save first
            StreamReader sr = new StreamReader(fileName);
            string theDots = sr.ReadToEnd();
            sr.Close();
            string[] theLines = theDots.Split('#');
            foreach (string stringDot in theLines)
            {
                string[] roleInfo = stringDot.Split(' ');
                if (roleInfo.Length > 2) {
                    string curRoleAttr = roleInfo[0];
                    string curRoleName = roleInfo[1];
                    int curRoleX = Convert.ToInt32( roleInfo[6]);
                    int curRoleY = Convert.ToInt32(roleInfo[8]);

                    switch (curRoleName) {
                        case "customer":
                            if (curRoleAttr.Equals("")) {
                                curRoleAttr = "Female";
                            }
                            modelRolesList.Add(new AnyCustomer(curRoleName, curRoleX, curRoleY, curRoleAttr, true));
                            break;

                        case "waiter":
                            if (curRoleAttr.Equals(""))
                            {
                                curRoleAttr = "Female";
                            }
                            modelRolesList.Add(new AnyWaiter(curRoleName, curRoleX, curRoleY, curRoleAttr, true));
                            break;

                        case "chef":
                            if (curRoleAttr.Equals(""))
                            {
                                curRoleAttr = "FiveStar";
                            }
                            modelRolesList.Add(new AnyChef(curRoleName, curRoleX, curRoleY, curRoleAttr, true));
                            break;
                    }
                }
            }
        }
    }
}
