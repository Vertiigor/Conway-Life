using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwayLife
{
    public partial class GameForm : System.Windows.Forms.Form
    {
        private Field field;
        private Graphics graphics;
        private Bitmap bitmap;
        private Pen pen;

        public GameForm()
        {
            InitializeComponent();

            field = new Field((int)CellSizeUpDown.Value, Canvas.Width, Canvas.Height, (int)DensityUpDown.Value);

            Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);

            bitmap = new Bitmap(Canvas.Width, Canvas.Height);

            graphics = Graphics.FromImage(bitmap);

            this.pen = new Pen(Color.Magenta, 1);

            UpdateTimer.Start();
        }

        private void DelayTrackBar_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateTimer.Interval = 100 * DelayTrackBar.Value;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);

            field.Update();

            for (int x = 0; x < field.Width; x++)
            {
                for (int y = 0; y < field.Height; y++)
                {
                    if (field.Points[x, y].State == Point.CellState.Alive)
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * (int)CellSizeUpDown.Value, y * (int)CellSizeUpDown.Value, (int)CellSizeUpDown.Value, (int)CellSizeUpDown.Value);
                    }
                }
            }

            Canvas.Image = bitmap;
        }


        private void StopButton_Click(object sender, EventArgs e)
        {
            this.UpdateTimer.Stop();

            this.CellSizeUpDown.Enabled = this.DensityUpDown.Enabled = true;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            this.UpdateTimer.Start();
            this.CellSizeUpDown.Enabled = this.DensityUpDown.Enabled = false;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            field.Random((int)DensityUpDown.Value);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            field.Clear();
        }

        private void CellSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            field = new Field((int)CellSizeUpDown.Value, Canvas.Image.Width, Canvas.Image.Height, (int)DensityUpDown.Value);
        }

        private void DensityUpDown_ValueChanged(object sender, EventArgs e)
        {
            field = new Field((int)CellSizeUpDown.Value, Canvas.Image.Width, Canvas.Image.Height, (int)DensityUpDown.Value);
        }
    }
}
