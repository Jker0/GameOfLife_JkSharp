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
            cbPreliminaryCalculation = new CheckBox();
            bClear = new Button();
            bStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btNextStep = new Button();
            ((System.ComponentModel.ISupportInitialize)Board).BeginInit();
            gbMainControl.SuspendLayout();
            SuspendLayout();
            // 
            // Board
            // 
            Board.Location = new Point(12, 12);
            Board.Name = "Board";
            Board.Size = new Size(824, 784);
            Board.TabIndex = 0;
            Board.TabStop = false;
            Board.Click += Board_Click;
            Board.MouseClick += Board_MouseClick;
            // 
            // gbMainControl
            // 
            gbMainControl.Controls.Add(btNextStep);
            gbMainControl.Controls.Add(cbPreliminaryCalculation);
            gbMainControl.Controls.Add(bClear);
            gbMainControl.Controls.Add(bStart);
            gbMainControl.Location = new Point(842, 12);
            gbMainControl.Name = "gbMainControl";
            gbMainControl.Size = new Size(225, 784);
            gbMainControl.TabIndex = 0;
            gbMainControl.TabStop = false;
            // 
            // cbPreliminaryCalculation
            // 
            cbPreliminaryCalculation.AutoSize = true;
            cbPreliminaryCalculation.Location = new Point(12, 20);
            cbPreliminaryCalculation.Name = "cbPreliminaryCalculation";
            cbPreliminaryCalculation.Size = new Size(213, 29);
            cbPreliminaryCalculation.TabIndex = 3;
            cbPreliminaryCalculation.Text = "Preliminary calculation";
            cbPreliminaryCalculation.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            bClear.Location = new Point(122, 55);
            bClear.Name = "bClear";
            bClear.Size = new Size(97, 34);
            bClear.TabIndex = 2;
            bClear.Text = "Clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // bStart
            // 
            bStart.Location = new Point(128, 744);
            bStart.Name = "bStart";
            bStart.Size = new Size(99, 34);
            bStart.TabIndex = 0;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btNextStep
            // 
            btNextStep.Location = new Point(12, 55);
            btNextStep.Name = "btNextStep";
            btNextStep.Size = new Size(104, 34);
            btNextStep.TabIndex = 4;
            btNextStep.Text = "NextStep";
            btNextStep.UseVisualStyleBackColor = true;
            btNextStep.Click += btNextStep_Click;
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
    }
}
