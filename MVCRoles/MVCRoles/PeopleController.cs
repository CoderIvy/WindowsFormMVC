using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRoles
{
    //not sure the meaning of IShapView
    public interface IShapeView
    {
        void RefreshView();
    }

    public class PeopleController
    {
        //for all roles
        private ArrayList rolesList;

        //constructor
        public PeopleController() {
            rolesList = new ArrayList();
        }

        //add members to roles' list
        public void AddPeople(IShapeView curView) {
            rolesList.Add(curView);
        }

        public void UpdateViews() {
            IShapeView[] theRoles = (IShapeView[])rolesList.ToArray(typeof(IShapeView));
            foreach (IShapeView v in theRoles) {
                v.RefreshView();
            }
        }
    }
}
