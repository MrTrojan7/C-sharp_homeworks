namespace ListBoxExample1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddToListBox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCopyFromListBox = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // btnAddToListBox
            // 
            this.btnAddToListBox.Location = new System.Drawing.Point(13, 183);
            this.btnAddToListBox.Name = "btnAddToListBox";
            this.btnAddToListBox.Size = new System.Drawing.Size(120, 23);
            this.btnAddToListBox.TabIndex = 1;
            this.btnAddToListBox.Text = "AddToListBox";
            this.btnAddToListBox.UseVisualStyleBackColor = true;
            this.btnAddToListBox.Click += new System.EventHandler(this.btnAddToListBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnCopyFromListBox
            // 
            this.btnCopyFromListBox.Location = new System.Drawing.Point(156, 183);
            this.btnCopyFromListBox.Name = "btnCopyFromListBox";
            this.btnCopyFromListBox.Size = new System.Drawing.Size(111, 23);
            this.btnCopyFromListBox.TabIndex = 4;
            this.btnCopyFromListBox.Text = "CopyFromListBox";
            this.btnCopyFromListBox.UseVisualStyleBackColor = true;
            this.btnCopyFromListBox.Click += new System.EventHandler(this.btnCopyFromListBox_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(156, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 5;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(13, 229);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveSelected.TabIndex = 6;
            this.btnRemoveSelected.Text = "RemoveSelected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnCopyFromListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddToListBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddToListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCopyFromListBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}

