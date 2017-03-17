using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Game
{
    
    class Area
    {
        public PictureBox PicturBox = new PictureBox();


        public void SetPictureBox(bool visible, int x, int y, int width, int height)
        {
            this.PicturBox.Visible = visible;
            this.PicturBox.Location = new Point(x, y);
            this.PicturBox.Size = new Size(width, height);
            this.PicturBox.BackColor = Color.White;
            this.PicturBox.BorderStyle = BorderStyle.Fixed3D;
        }
        
        
    }
}
