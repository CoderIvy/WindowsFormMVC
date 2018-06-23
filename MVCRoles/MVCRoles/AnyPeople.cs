using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRoles
{
   public abstract class AnyPeople
    {
        protected string roleName;
        protected int x_pos;
        protected int y_pos;
        protected string attribute;
        bool isInit;
        bool highlight;

        public AnyPeople(string role, int x, int y, string atribute, bool init)
        {
            roleName = role;
            x_pos = x;
            y_pos = y;
            attribute = atribute;
            isInit = init;
        }

        public override string ToString()
        {
            return attribute + " " + roleName + " add at " + this.Position();
        }

        public abstract void Display(Graphics g);

        

        /// <summary>
        /// position string 
        /// </summary>
        /// <returns></returns>
        public string Position()
        {
            return " ( " + x_pos.ToString() + " , " + y_pos.ToString() + " ) ";
        }


        public bool Highlight { get { return highlight; } set { highlight = value; } }

        public int x { get { return x_pos; } set { x_pos = value; } }

        public int y { get { return y_pos; } set { y_pos = value; } }

        public string name { get { return roleName; } set { roleName = value; } }

        public string atribute { get { return attribute; } set { attribute = value; } }

        public bool init { get { return isInit; } set { isInit = value; } }


        public virtual bool HitTest(Point p)
        {
            Point pt = new Point(x_pos, y_pos);
            Size size = new Size(100, 100);

            return new Rectangle(pt, size).Contains(p);
        }
    }
}
