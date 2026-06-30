namespace NoteFreak
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
            textBox = new TextBox();
            button2 = new Button();
            output = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 349);
            button1.Name = "button1";
            button1.Size = new Size(197, 67);
            button1.TabIndex = 0;
            button1.Text = "Save file as";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SaveAs;
            // 
            // textBox
            // 
            textBox.Location = new Point(29, 28);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(733, 223);
            textBox.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(565, 349);
            button2.Name = "button2";
            button2.Size = new Size(197, 67);
            button2.TabIndex = 2;
            button2.Text = "Open File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OpenFile;
            // 
            // output
            // 
            output.Location = new Point(29, 257);
            output.Name = "output";
            output.Size = new Size(733, 23);
            output.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(301, 349);
            button3.Name = "button3";
            button3.Size = new Size(197, 67);
            button3.TabIndex = 4;
            button3.Text = "Save file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Save;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(output);
            Controls.Add(button2);
            Controls.Add(textBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox;
        private Button button2;
        private TextBox output;
        private Button button3;
    }
}
