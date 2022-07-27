namespace Maze
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
            this.health = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.energy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.ForeColor = System.Drawing.Color.Red;
            this.health.Location = new System.Drawing.Point(523, 191);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(37, 21);
            this.health.TabIndex = 0;
            this.health.Text = "100";
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coins.ForeColor = System.Drawing.Color.Gold;
            this.coins.Location = new System.Drawing.Point(523, 221);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(19, 21);
            this.coins.TabIndex = 1;
            this.coins.Text = "0";
            // 
            // energy
            // 
            this.energy.AutoSize = true;
            this.energy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.energy.ForeColor = System.Drawing.Color.Lime;
            this.energy.Location = new System.Drawing.Point(526, 252);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(37, 21);
            this.energy.TabIndex = 2;
            this.energy.Text = "500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 397);
            this.Controls.Add(this.energy);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.health);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.Label energy;
    }
}

