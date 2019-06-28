using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class GameForm : Form
    {
        public static int dattSeichas = 0;
        public static int yroven = 0;
        public static int ball = 0;
        public static int time = 0;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //  this.Controls.Clear();
            List<string> r = new List<string>(File.ReadLines("Dates.txt", Encoding.UTF8));
            if (GameForm.yroven == 0)
            {
                buttonNext.Text = "Начать";
            }
            else if ((GameForm.yroven > 0) && (GameForm.yroven <    3))
            {
                buttonNext.Text = "Далее";
            }
            else if (GameForm.yroven == 3)
            {
                buttonNext.Text = "Итог";
            }


        }

        void check(DateUserControl u1, DateUserControl u2, DateUserControl u3)
        {
            if ((u1.data > u2.data) && (u1.Location.X > u2.Location.X))
            {
                GameForm.ball++;
            }

            if ((u1.data < u2.data) && (u1.Location.X < u2.Location.X))
            {
                GameForm.ball++;
            }

            if ((u2.data > u3.data) && (u2.Location.X > u3.Location.X))
            {
                GameForm.ball++;
            }

            if ((u2.data < u3.data) && (u2.Location.X < u3.Location.X))
            {
                GameForm.ball++;
            }

            if ((u2.data > u3.data) && (u2.Location.X > u3.Location.X))
            {
                GameForm.ball++;
            }

            if ((u1.data < u3.data) && (u1.Location.X < u3.Location.X))
            {
                GameForm.ball++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разместите исторические даты на таймлайне в соответствии с их положением во времени. Используйте мышь. Удачи!" + Environment.NewLine + "Как правильно играть:" + Environment.NewLine + "1.Нажать далее" + Environment.NewLine + "2.Разместить даты на таймлайне" + Environment.NewLine + "3.Вписать результаты" + Environment.NewLine + "4.Нажать далее" + Environment.NewLine+ "И так до упора. Приятного упрорства!" );
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DateUserControl u1 = new DateUserControl();
        public DateUserControl u2 = new DateUserControl();
        public DateUserControl u3 = new DateUserControl();
        private void buttonNext_Click(object sender, EventArgs e)
        {


            
            /*this.Controls.Add(timeline);
            this.Controls.Add(z);
            this.Controls.Add(n);
            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(b3);
            this.Controls.Add(b4);*/
            
            this.Controls.Add(u1);
            this.Controls.Add(u2);
            this.Controls.Add(u3);
            GameForm.yroven++;
            GameForm_Load(sender, e);


        }

        private void buttonRez_Click(object sender, EventArgs e)
        {
            check(u1, u2, u3);
            this.Controls.Remove(u1);
            this.Controls.Remove(u2);
            this.Controls.Remove(u3);
            u1 = new DateUserControl();
            u2 = new DateUserControl();
            u3 = new DateUserControl();
            BallLabel.Text = "Баллы: " + GameForm.ball.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameForm.time++;
            TimeLabel.Text = "Время: " + GameForm.time.ToString();
            GameForm_Load(sender, e);
        }
    
    }
}
