using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixView.Forms.Design
{
    class DragObj
    {
        #region DragForm
        private Form frm;
        private Control cntrl;

        public DragObj() { }

        public DragObj(Form _frm, Control _cntrl)
        {
            frm = _frm;
            cntrl = _cntrl;

            AddDrag();
        }

        public void AddDrag()
        {
            cntrl.MouseDown += new MouseEventHandler(Drag_MouseDown);
            cntrl.MouseMove += new MouseEventHandler(Drag_MouseMove);
            cntrl.MouseUp += new MouseEventHandler(Drag_MouseUp);
        }

        public bool MouseDown;
        private Point lastLocation;

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            lastLocation = e.Location;
            Control cntrl = (Control)sender;
            //Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = Enums.AccentState.ACCENT_DISABLED });
            //this.Opacity = 0.85;
            cntrl.Cursor = Cursors.Hand;
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                frm.Location = new Point(
                    (frm.Location.X - lastLocation.X) + e.X, (frm.Location.Y - lastLocation.Y) + e.Y);

                frm.Update();
            }
        }

        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            Control cntrl = (Control)sender;
            //Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = FormAccent });
            //this.Opacity = 1;
            cntrl.Cursor = Cursors.Default;
        }
        #endregion
    }
}
