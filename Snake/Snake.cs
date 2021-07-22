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

namespace Snake
{
    public partial class Snake : Form
    {
        public Player Player = new Player();
        public bool paused = false;
        public int SegmentSize = 16;
        public Color Background = Color.Black;
        public Snake()
        {
            InitializeComponent();
            KeyPreview = true;
            DoubleBuffered = true;
            string colorText = File.ReadAllText("bgcolor.cfg");
            int[] colorValues = colorText.Split(',').Select(s => Int32.Parse(s)).ToArray();
            Background = Color.FromArgb(colorValues[0], colorValues[1], colorValues[2]);
            Frametick.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxDrawer_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.Clear(Background); 
            e.Graphics.FillEllipse(
                Brushes.Green, 
                new Rectangle( 
                    new Point (Player.Position.X * SegmentSize,Player.Position.Y *SegmentSize),
                    new Size(SegmentSize,SegmentSize))
                );
            
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                Player.Direction = Direction.Right;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                Player.Direction = Direction.Left;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                Player.Direction = Direction.Up;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                Player.Direction = Direction.Down;
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                if (paused == true)
                {
                    paused = false;
                    Frametick.Start();
                }
                    else
                {
                    paused = true;
                    Frametick.Stop(); 
                }
            }
            if (e.KeyCode == Keys.C)
            {
                using(var form = new ColorDialog())
                {
                    if(form.ShowDialog() == DialogResult.Cancel)
                    {
                        return;

                    }
                    Background = form.Color; PictureBoxDrawer.Invalidate();
                    File.WriteAllText("bgcolor.cfg",  $"{form.Color.R},{form.Color.G},{form.Color.B}");
                }
            }
           
        }
        private void Frametick_Tick(object sender, EventArgs e)
        {
            Player.Move();
            PictureBoxDrawer.Invalidate();
        }
    }
}
