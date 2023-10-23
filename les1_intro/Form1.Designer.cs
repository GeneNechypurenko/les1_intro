namespace les1_intro
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
            button1 = new Button();
            vScrollBar1 = new VScrollBar();
            splitter1 = new Splitter();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(626, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Hello";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(765, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 432);
            vScrollBar1.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.Desktop;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(420, 450);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += splitter1_SplitterMoved;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 63);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Label";
            // 
            // button2
            // 
            button2.Location = new Point(626, 98);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Farewell";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Farewell;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(splitter1);
            Controls.Add(vScrollBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private VScrollBar vScrollBar1;
        private Splitter splitter1;
        private Label label1;
        private Button button2;
    }
}