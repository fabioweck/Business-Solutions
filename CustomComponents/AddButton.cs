using BusinessManager.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.CustomComponents
{
    public class AddButton: Button
    {
        public AddButton()
        {
            this.Size = new Size(50, 50);
            this.Text = string.Empty;
            Image backgroundImg = Resources.addIcon;
            Bitmap bmp = new Bitmap(backgroundImg, new Size(50, 50));
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.Transparent;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.LightGray;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.Transparent;
        }
    }
}
