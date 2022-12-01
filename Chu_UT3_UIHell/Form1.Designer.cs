namespace Chu_UT3_UIHell
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
            this.button = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(58, 35);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "why";
            this.button.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(1228, 134);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(180, 20);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "donde esta la biblioteca?";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(743, 622);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(53, 20);
            this.radioButton.TabIndex = 2;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "start";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(1289, 564);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 22);
            this.textBox.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(246, 167);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(175, 175);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 862);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

