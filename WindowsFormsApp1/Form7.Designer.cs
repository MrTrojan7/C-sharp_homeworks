namespace WindowsFormsApp1
{
    partial class Form7
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
            this.buttonToPress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToPress
            // 
            this.buttonToPress.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonToPress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToPress.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonToPress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonToPress.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonToPress.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToPress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonToPress.Location = new System.Drawing.Point(205, 123);
            this.buttonToPress.Name = "buttonToPress";
            this.buttonToPress.Size = new System.Drawing.Size(378, 151);
            this.buttonToPress.TabIndex = 0;
            this.buttonToPress.Text = "Move the mouse over the button and press it immediately";
            this.buttonToPress.UseVisualStyleBackColor = false;
            this.buttonToPress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonToPress_MouseClick);
            this.buttonToPress.MouseLeave += new System.EventHandler(this.buttonToPress_MouseLeave);
            this.buttonToPress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonToPress_MouseMove);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToPress);
            this.Name = "Form7";
            this.Text = "Clicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToPress;
    }
}