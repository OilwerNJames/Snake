namespace Snake
{
    partial class MainForm
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
            this.buttonCreateGrid = new System.Windows.Forms.Button();
            this.textBoxGridInstructions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreateGrid
            // 
            this.buttonCreateGrid.Location = new System.Drawing.Point(296, 109);
            this.buttonCreateGrid.Name = "buttonCreateGrid";
            this.buttonCreateGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateGrid.TabIndex = 0;
            this.buttonCreateGrid.Text = "Create Gird";
            this.buttonCreateGrid.UseVisualStyleBackColor = true;
            this.buttonCreateGrid.Click += new System.EventHandler(this.buttonCreateGrid_Click);
            // 
            // textBoxGridInstructions
            // 
            this.textBoxGridInstructions.Location = new System.Drawing.Point(37, 111);
            this.textBoxGridInstructions.Multiline = true;
            this.textBoxGridInstructions.Name = "textBoxGridInstructions";
            this.textBoxGridInstructions.Size = new System.Drawing.Size(243, 158);
            this.textBoxGridInstructions.TabIndex = 1;
            this.textBoxGridInstructions.Text = "4,4,3\r\n1,1\r\n1,2\r\n2,2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 318);
            this.Controls.Add(this.textBoxGridInstructions);
            this.Controls.Add(this.buttonCreateGrid);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateGrid;
        private System.Windows.Forms.TextBox textBoxGridInstructions;
    }
}

