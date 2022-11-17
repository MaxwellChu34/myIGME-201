namespace Chu_MultipleForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.lowEnd = new System.Windows.Forms.TextBox();
            this.highEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(284, 336);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(188, 63);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lowEnd
            // 
            this.lowEnd.Location = new System.Drawing.Point(176, 124);
            this.lowEnd.Name = "lowEnd";
            this.lowEnd.Size = new System.Drawing.Size(100, 22);
            this.lowEnd.TabIndex = 1;
            this.lowEnd.Text = "1";
            this.lowEnd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // highEnd
            // 
            this.highEnd.Location = new System.Drawing.Point(479, 124);
            this.highEnd.Name = "highEnd";
            this.highEnd.Size = new System.Drawing.Size(100, 22);
            this.highEnd.TabIndex = 2;
            this.highEnd.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highEnd);
            this.Controls.Add(this.lowEnd);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox lowEnd;
        private System.Windows.Forms.TextBox highEnd;
    }
}

