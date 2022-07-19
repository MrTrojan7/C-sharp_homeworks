namespace WindowsFormsApp1
{
    partial class task3
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
            this.driving_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.timer.Start();
            // 
            // driving_button
            // 
            this.driving_button.Location = new System.Drawing.Point(37, 62);
            this.driving_button.Name = "driving_button";
            this.driving_button.Size = new System.Drawing.Size(75, 23);
            this.driving_button.TabIndex = 0;
            this.driving_button.Text = "Я уезжаю";
            this.driving_button.UseVisualStyleBackColor = true;
            // 
            // task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 336);
            this.Controls.Add(this.driving_button);
            this.Name = "task3";
            this.Text = "task3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button driving_button;
    }
}