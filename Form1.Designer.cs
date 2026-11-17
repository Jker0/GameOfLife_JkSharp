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
            Board = new PictureBox();
            gbMainControl = new GroupBox();
            bStart = new Button();
            ((System.ComponentModel.ISupportInitialize)Board).BeginInit();
            gbMainControl.SuspendLayout();
            SuspendLayout();
            // 
            // Board
            // 
            Board.Location = new Point(12, 12);
            Board.Name = "Board";
            Board.Size = new Size(657, 784);
            Board.TabIndex = 0;
            Board.TabStop = false;
            // 
            // gbMainControl
            // 
            gbMainControl.Controls.Add(bStart);
            gbMainControl.Location = new Point(689, 12);
            gbMainControl.Name = "gbMainControl";
            gbMainControl.Size = new Size(200, 100);
            gbMainControl.TabIndex = 0;
            gbMainControl.TabStop = false;
            // 

            // 
            // bStart
            // 
            bStart.Location = new Point(11, 15);
            bStart.Name = "bStart";
            bStart.Size = new Size(112, 34);
            bStart.TabIndex = 0;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 880);
            Controls.Add(gbMainControl);
            Controls.Add(Board);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Board).EndInit();
            gbMainControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Board;
        private GroupBox gbMainControl;
        private Button bStart;
    }
}
