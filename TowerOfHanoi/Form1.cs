using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public static List<Button> takeButtons;
        public static List<Button> putButtons;
        public static List<Tower> towers;

        //временное хранилище для кольца, взятого методом Take
        public static PictureBox temp;

        public static int steps;

        public class Tower
        {
            public int placeIndex = 0;
            public Point placeCenterPoint;
            public List<PictureBox> rings = new List<PictureBox>();
            public Tower(int place)
            {
                this.placeIndex = place;
                this.placeCenterPoint = new Point(85 + placeIndex * 170, 282);
            }
            public void Paint()
            {
                int j = 0;


                foreach(PictureBox ring in rings)
                {
                    int i = ring.Size.Width / 50;

                    int x = placeCenterPoint.X - 25 * i;
                    int y = placeCenterPoint.Y - 58 * j;

                    ring.Location = new Point(x, y);
                    j++;
                }
            }
            public void Take()
            {
                PictureBox takedRing = rings.Last();
                rings.RemoveAt(rings.Count-1);
                takedRing.Top = 100;

                temp = takedRing;

                CheckTowersToPut();
            }
        }

        //проверка башен на возможность взять кольцо
        public static void CheckTowersToTake()
        {
            for (int i = 0; i < 3; i++)
            {
                if (towers[i].rings.Count > 0)
                {
                    takeButtons[i].Visible = true;
                }
            }
        }

        //проверка башен на возможность поместить туда кольцо
        public static void CheckTowersToPut()
        {
            for(int i = 0; i < 3; i++)
            {
                if (towers[i].rings.Count == 0 || temp.Width < towers[i].rings.Last().Width)
                {
                    putButtons[i].Visible = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            takeButtons = new List<Button>() { takeButton1, takeButton2, takeButton3 };
            putButtons = new List<Button>() { putButton1, putButton2, putButton3 };
            towers = new List<Tower>() { new Tower(0), new Tower(1), new Tower(2) };

            //добавление колец на первую башню при инициализации формы
            for (int i = 3; i > 0; i--)
            {
                PictureBox ring = new PictureBox();
                ring.Name = i.ToString();

                ring.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                ring.Size = new Size(50 * i, 50);
                ring.Visible = true;
                ring.Enabled = true;

                this.Controls.Add(ring);
                towers[0].rings.Add(ring);
            }

            CheckTowersToTake();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //отрисовка стеднов для башен
            Graphics g;
            g = CreateGraphics();
            g.DrawLine(new Pen(Color.Black, 10), 85, 155, 85, 340);
            g.DrawLine(new Pen(Color.Black, 10), 255, 155, 255, 340);
            g.DrawLine(new Pen(Color.Black, 10), 425, 155, 425, 340);

            //отрисовка колец на каждой башне
            foreach(Tower tower in towers)
            {
                tower.Paint();
            }

            label1.Text = "Шагов: " + steps;
        }

        private void takeButtons_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int index = takeButtons.FindIndex(b => b == button);

            towers[index].Take();

            foreach (Button takeButton in takeButtons)
            {
                takeButton.Visible = false;
            }

            this.Refresh();
        }

        private void putButtons_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int index = putButtons.FindIndex(b => b == button);

            towers[index].rings.Add(temp);

            foreach(Button putButton in putButtons)
            {
                putButton.Visible = false;
            }

            CheckTowersToTake();

            this.Refresh();

            steps++;

            if (towers[2].rings.Count == 3)
            {
                MessageBox.Show("Вы прошли головоломку 'Ханойские башни'!", "Поздравляем!");
                for (int i = 0; i < 3; i++)
                {
                    takeButtons[i].Visible = false;
                    putButtons[i].Visible = false;
                }

            }
        }
    }
}
