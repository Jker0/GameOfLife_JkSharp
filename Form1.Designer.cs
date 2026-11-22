namespace GameOfLife_JkSh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Board = new PictureBox();
            gbMainControl = new GroupBox();
            gbScaleBoard = new GroupBox();
            trackBarScale = new TrackBar();
            gbButtons = new GroupBox();
            btNextStep = new Button();
            bClear = new Button();
            bStart = new Button();
            cbPreliminaryCalculation = new CheckBox();
            trackBarSpeed = new TrackBar();
            LbSpeed = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Board).BeginInit();
            gbMainControl.SuspendLayout();
            gbScaleBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarScale).BeginInit();
            gbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // Board
            // 
            Board.Dock = DockStyle.Left;
            Board.Location = new Point(0, 0);
            Board.Name = "Board";
            Board.Size = new Size(848, 895);
            Board.TabIndex = 0;
            Board.TabStop = false;
            Board.Click += Board_Click;
            Board.MouseClick += Board_MouseClick;
            // 
            // gbMainControl
            // 
            gbMainControl.Controls.Add(gbScaleBoard);
            gbMainControl.Controls.Add(gbButtons);
            gbMainControl.Controls.Add(bStart);
            gbMainControl.Controls.Add(cbPreliminaryCalculation);
            gbMainControl.Controls.Add(trackBarSpeed);
            gbMainControl.Controls.Add(LbSpeed);
            gbMainControl.Dock = DockStyle.Right;
            gbMainControl.Location = new Point(854, 0);
            gbMainControl.Name = "gbMainControl";
            gbMainControl.Size = new Size(225, 895);
            gbMainControl.TabIndex = 0;
            gbMainControl.TabStop = false;
            // 
            // gbScaleBoard
            // 
            gbScaleBoard.Controls.Add(trackBarScale);
            gbScaleBoard.Dock = DockStyle.Bottom;
            gbScaleBoard.Location = new Point(3, 708);
            gbScaleBoard.Name = "gbScaleBoard";
            gbScaleBoard.Size = new Size(219, 150);
            gbScaleBoard.TabIndex = 8;
            gbScaleBoard.TabStop = false;
            gbScaleBoard.Text = "Scale :";
            // 
            // trackBarScale
            // 
            trackBarScale.Dock = DockStyle.Top;
            trackBarScale.Location = new Point(3, 27);
            trackBarScale.Maximum = 100;
            trackBarScale.Name = "trackBarScale";
            trackBarScale.Size = new Size(213, 69);
            trackBarScale.TabIndex = 0;
            trackBarScale.TickFrequency = 10;
            trackBarScale.Value = 50;
            trackBarScale.Scroll += trackBarScale_Scroll;
            // 
            // gbButtons
            // 
            gbButtons.Controls.Add(btNextStep);
            gbButtons.Controls.Add(bClear);
            gbButtons.Dock = DockStyle.Top;
            gbButtons.Location = new Point(3, 150);
            gbButtons.Name = "gbButtons";
            gbButtons.Size = new Size(219, 65);
            gbButtons.TabIndex = 5;
            gbButtons.TabStop = false;
            // 
            // btNextStep
            // 
            btNextStep.Dock = DockStyle.Left;
            btNextStep.Location = new Point(3, 27);
            btNextStep.Name = "btNextStep";
            btNextStep.Size = new Size(104, 35);
            btNextStep.TabIndex = 4;
            btNextStep.Text = "NextStep";
            btNextStep.UseVisualStyleBackColor = true;
            btNextStep.Click += btNextStep_Click;
            // 
            // bClear
            // 
            bClear.Dock = DockStyle.Right;
            bClear.Location = new Point(119, 27);
            bClear.Name = "bClear";
            bClear.Size = new Size(97, 35);
            bClear.TabIndex = 2;
            bClear.Text = "Clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // bStart
            // 
            bStart.Dock = DockStyle.Bottom;
            bStart.Location = new Point(3, 858);
            bStart.Name = "bStart";
            bStart.Size = new Size(219, 34);
            bStart.TabIndex = 0;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // cbPreliminaryCalculation
            // 
            cbPreliminaryCalculation.AutoSize = true;
            cbPreliminaryCalculation.Dock = DockStyle.Top;
            cbPreliminaryCalculation.Location = new Point(3, 121);
            cbPreliminaryCalculation.Name = "cbPreliminaryCalculation";
            cbPreliminaryCalculation.Size = new Size(219, 29);
            cbPreliminaryCalculation.TabIndex = 3;
            cbPreliminaryCalculation.Text = "Preliminary calculation";
            cbPreliminaryCalculation.UseVisualStyleBackColor = true;
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.Dock = DockStyle.Top;
            trackBarSpeed.Location = new Point(3, 52);
            trackBarSpeed.Maximum = 100;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(219, 69);
            trackBarSpeed.TabIndex = 6;
            trackBarSpeed.TickFrequency = 10;
            trackBarSpeed.Value = 50;
            trackBarSpeed.Scroll += trackBar1_Scroll;
            // 
            // LbSpeed
            // 
            LbSpeed.AutoSize = true;
            LbSpeed.Dock = DockStyle.Top;
            LbSpeed.Location = new Point(3, 27);
            LbSpeed.Name = "LbSpeed";
            LbSpeed.Size = new Size(76, 25);
            LbSpeed.TabIndex = 7;
            LbSpeed.Text = "Speed : ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 895);
            Controls.Add(gbMainControl);
            Controls.Add(Board);
            Name = "Form1";
            Text = "Game of Life (Jkero)";
            ((System.ComponentModel.ISupportInitialize)Board).EndInit();
            gbMainControl.ResumeLayout(false);
            gbMainControl.PerformLayout();
            gbScaleBoard.ResumeLayout(false);
            gbScaleBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarScale).EndInit();
            gbButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Board;
        private GroupBox gbMainControl;
        private Button bStart;
        private Button bClear;
        private CheckBox cbPreliminaryCalculation;
        private System.Windows.Forms.Timer timer1;
        private Button btNextStep;
        private GroupBox gbButtons;
        private TrackBar trackBarSpeed;
        private Label LbSpeed;
        private GroupBox gbScaleBoard;
        private TrackBar trackBarScale;
    }
}
