using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCRoles
{
    class AnyWaiter : AnyPeople
    {

        public AnyWaiter(string roleName, int x, int y, string attribute, bool init) :
            base(roleName, x, y, attribute, init)
        { }

        /// <summary>
        /// display graphic
        /// </summary>
        /// <param name="g"></param>
        public override void Display(Graphics g)
        {
            string resFolder;
            if (g == null && !roleName.Equals("waiter"))
            {
                MessageBox.Show("Graphic is null or role is wrong", "Error");
            }

            if (init)
            {
                switch (attribute)
                {
                    case "Male":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "waiter1.png");
                        break;

                    case "Female":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "waitress1.png");
                        break;

                    default:
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "waitress1.png");
                        break;
                }
            }
            else
            {
                switch (attribute)
                {
                    case "Male":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "waiter2.png");
                        break;

                    case "Female":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "waitress2.png");
                        break;

                    default:
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "waitress2.png");
                        break;
                }
            }

            Image imag = Image.FromFile(resFolder);
            g.DrawImage(imag, new Point(x, y));

        }

    }
}
