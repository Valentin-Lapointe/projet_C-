using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CheckersClient
{
    public partial class Pawn : UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(8, 8, 45, 45);
            this.Region = new Region(path);
            base.OnPaint(e);
        }

        private void Pawn_Resize(object sender, EventArgs e)
        {

        }
    }
}
