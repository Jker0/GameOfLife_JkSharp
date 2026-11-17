
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
        }

        private void bStart_Click(object sender, EventArgs e)
        {

        }
    }
}
