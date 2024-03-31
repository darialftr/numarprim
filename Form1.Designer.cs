namespace numarprim_k
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckButton = new System.Windows.Forms.Button();
            this.PrimeNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CheckButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckButton.Image")));
            this.CheckButton.Location = new System.Drawing.Point(294, 221);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(182, 60);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "CHECK";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // PrimeNumberTextBox
            // 
            this.PrimeNumberTextBox.Location = new System.Drawing.Point(276, 173);
            this.PrimeNumberTextBox.Name = "PrimeNumberTextBox";
            this.PrimeNumberTextBox.Size = new System.Drawing.Size(217, 22);
            this.PrimeNumberTextBox.TabIndex = 1;
            this.PrimeNumberTextBox.TextChanged += new System.EventHandler(this.PrimeNumberTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrimeNumberTextBox);
            this.Controls.Add(this.CheckButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox PrimeNumberTextBox;
    }
}

