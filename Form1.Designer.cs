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
            gbButtons = new GroupBox();
            btNextStep = new Button();
            bClear = new Button();
            cbPreliminaryCalculation = new CheckBox();
            bStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Board).BeginInit();
            gbMainControl.SuspendLayout();
            gbButtons.SuspendLayout();
            SuspendLayout();
            // 
            // Board
            // 
            Board.Dock = DockStyle.Left;
            Board.Location = new Point(0, 0);
            Board.Name = "Board";
            Board.Size = new Size(848, 810);
            Board.TabIndex = 0;
            Board.TabStop = false;
            Board.Click += Board_Click;
            Board.MouseClick += Board_MouseClick;
            // 
            // gbMainControl
            // 
            gbMainControl.Controls.Add(gbButtons);
            gbMainControl.Controls.Add(cbPreliminaryCalculation);
            gbMainControl.Controls.Add(bStart);
            gbMainControl.Dock = DockStyle.Right;
            gbMainControl.Location = new Point(854, 0);
            gbMainControl.Name = "gbMainControl";
            gbMainControl.Size = new Size(225, 810);
            gbMainControl.TabIndex = 0;
            gbMainControl.TabStop = false;
            // 
            // gbButtons
            // 
            gbButtons.Controls.Add(btNextStep);
            gbButtons.Controls.Add(bClear);
            gbButtons.Dock = DockStyle.Top;
            gbButtons.Location = new Point(3, 56);
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
            // cbPreliminaryCalculation
            // 
            cbPreliminaryCalculation.AutoSize = true;
            cbPreliminaryCalculation.Dock = DockStyle.Top;
            cbPreliminaryCalculation.Location = new Point(3, 27);
            cbPreliminaryCalculation.Name = "cbPreliminaryCalculation";
            cbPreliminaryCalculation.Size = new Size(219, 29);
            cbPreliminaryCalculation.TabIndex = 3;
            cbPreliminaryCalculation.Text = "Preliminary calculation";
            cbPreliminaryCalculation.UseVisualStyleBackColor = true;
            // 
            // bStart
            // 
            bStart.Dock = DockStyle.Bottom;
            bStart.Location = new Point(3, 773);
            bStart.Name = "bStart";
            bStart.Size = new Size(219, 34);
            bStart.TabIndex = 0;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 810);
            Controls.Add(gbMainControl);
            Controls.Add(Board);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Board).EndInit();
            gbMainControl.ResumeLayout(false);
            gbMainControl.PerformLayout();
            gbButtons.ResumeLayout(false);
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
    }
}
