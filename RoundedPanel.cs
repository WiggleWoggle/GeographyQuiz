using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultwinform
{
    public class RoundedPanel : System.Windows.Forms.Panel
    {
        private int borderRadius = 30;

        public RoundedPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }   

        public int BorderRadius { get => borderRadius; set => borderRadius = value; }

        private GraphicsPath GetPanelPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            //drawing shape
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);

            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //override the onPaint event
            base.OnPaint(e);
            //create a paintable rectangle drawing passing in the width and height the control is scaled to
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            //keep the panel from having a radius below 2 that would cause visual errors
            if (borderRadius > 2)
            {
                //start drawing a bordered rectangle
                using (GraphicsPath path = GetPanelPath(rectangleF, borderRadius))
                //assign a color to the drawn shape
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    //update the shape and draw it
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            //default to a normal rectangle if under 2 radius
            else
            {
                this.Region = new Region(rectangleF);
            }
        }
    }
}
