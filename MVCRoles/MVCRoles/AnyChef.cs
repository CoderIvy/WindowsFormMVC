using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCRoles
{
    class AnyChef : AnyPeople
    {

        public AnyChef(string roleName, int x, int y, string attribute, bool init) :
            base(roleName, x, y, attribute, init)
        { }

        /// <summary>
        /// display graphics
        /// </summary>
        /// <param name="g"></param>
        public override void Display(Graphics g)
        {
            string resFolder;
            if (g == null && !roleName.Equals("chef"))
            {
                MessageBox.Show("Graphic is null or role is wrong", "Error");
            }

            if (init)
            {
                switch (attribute)
                {
                    case "Three stars":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "3chef1.png");
                        break;

                    case "Four stars":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "4chef1.png");
                        break;

                    case "Five stars":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "5chef1.png");
                        break;

                    default:
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "5chef1.png");
                        break;
                }
            }
            else
            {
                switch (attribute)
                {
                    case "Three stars":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "3chef2.png");
                        break;

                    case "Four stars":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "4chef2.png");
                        break;

                    case "Five stars":
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "5chef2.png");
                        break;

                    default:
                        resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "5chef2.png");
                        break;
                }
            }
            Image imag = Image.FromFile(resFolder);

            g.DrawImage(imag, new Point(x, y));
        }
    }
}
