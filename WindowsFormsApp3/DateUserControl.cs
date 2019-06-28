using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class DateUserControl : UserControl
    {
    
        public bool IsDragging = false;
        public Point DragCursorPosition;
        public Point DragUCPosition;
        public int data;
        
        public DateUserControl()
        {
            InitializeComponent();
        }


        public void FormTest_MouseDown(object sender, MouseEventArgs e)
        {
            IsDragging = true;
            DragCursorPosition = Cursor.Position;
            DragUCPosition = ((UserControl)sender).Location;
        }

        public void FormTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPosition));
                ((UserControl)sender).Location = Point.Add(DragUCPosition, new Size(dif));
            }
        }
        public void FormTest_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }
            private void DateUserControl_Load(object sender, EventArgs e)
        {
            ((UserControl)sender).MouseDown += new MouseEventHandler(FormTest_MouseDown);
            ((UserControl)sender).MouseMove += new MouseEventHandler(FormTest_MouseMove);
            ((UserControl)sender).MouseUp += new MouseEventHandler(FormTest_MouseUp);
        
            List<string> r = new List<string>(File.ReadLines("Dates.txt", Encoding.UTF8));

            Date.Text =r[GameForm.dattSeichas]+" год";
            data =Convert.ToInt16(r[GameForm.dattSeichas]);
            Tip.Text = r[GameForm.dattSeichas + 1];
            GameForm.dattSeichas+=2;
        }

        private void Tip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
