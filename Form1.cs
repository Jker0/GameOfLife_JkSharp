
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using BoardCanvas_Jker0_Lib;

namespace GameOfLife_JkSh
{
    public partial class Form1 : Form
    {
        BoardCanvas? BoardCanvas { get; set; }
        public Form1()
        {
            InitializeComponent();
            Board.Image = new Bitmap(Board.Width, Board.Height);
            BoardCanvas = new BoardCanvas(Board.Image);
            BoardCanvas.InitPBCanvas(20, 2, 40, 40);
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (bStart.Text == "Start")
            {
                StartGame();
            }
            else
            {
                StopGame();
            }

        }

        private void StopGame()
        {
            bStart.Text = "Start";
            btNextStep.Enabled = true;
            timer1.Stop();
        }

        private void StartGame()
        {
            bStart.Text = "Stop";
            btNextStep.Enabled = false;
            timer1.Start();
        }

        private void Board_MouseClick(object sender, MouseEventArgs e)
        {
            BoardCanvas.MarkCellByPoint(e.Location);
            Board.Refresh();

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            StopGame();

            BoardCanvas.ClearCanvas();
            Board.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbPreliminaryCalculation.Checked)
                Game.NextStepWithPrelim(BoardCanvas);
            else
                Game.NextStepWithoutPrelim(BoardCanvas);

            Board.Refresh();
        }

        private void btNextStep_Click(object sender, EventArgs e)
        {
            if (cbPreliminaryCalculation.Checked)
                Game.NextStepWithPrelim(BoardCanvas);
            else
                Game.NextStepWithoutPrelim(BoardCanvas);

            Board.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            StopGame();

            int NewScale = 10 + trackBarScale.Value / 10;
            int NewCountRowCol = 40 + 40 * (100 - trackBarScale.Value) / 100;

            BoardCanvas.InitPBCanvas(NewScale, 2, NewCountRowCol, NewCountRowCol);

            BoardCanvas.ClearCanvas();
            Board.Refresh();
        }

        private void cbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            StopGame();
            List<Color> Colors = new List<Color> { Color.White, Color.Black, Color.Red, Color.Green };

            if (cbDarkMode.Checked)
                Colors = new List<Color> { Color.Black, Color.White, Color.Red, Color.Green };
            

            BoardCanvas.SetColors(Colors);
            BoardCanvas.ClearCanvas();
            Board.Refresh();
        }
    }
}
