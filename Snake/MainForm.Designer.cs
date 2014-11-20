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
            this.buttonCountBlocks = new System.Windows.Forms.Button();
            this.buttonStartSnake = new System.Windows.Forms.Button();
            this.buttonCheckResult = new System.Windows.Forms.Button();
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
            // buttonCountBlocks
            // 
            this.buttonCountBlocks.Location = new System.Drawing.Point(117, 42);
            this.buttonCountBlocks.Name = "buttonCountBlocks";
            this.buttonCountBlocks.Size = new System.Drawing.Size(75, 23);
            this.buttonCountBlocks.TabIndex = 2;
            this.buttonCountBlocks.Text = "Count";
            this.buttonCountBlocks.UseVisualStyleBackColor = true;
            this.buttonCountBlocks.Click += new System.EventHandler(this.buttonCountBlocks_Click);
            // 
            // buttonStartSnake
            // 
            this.buttonStartSnake.Location = new System.Drawing.Point(278, 33);
            this.buttonStartSnake.Name = "buttonStartSnake";
            this.buttonStartSnake.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSnake.TabIndex = 3;
            this.buttonStartSnake.Text = "get Snakey!";
            this.buttonStartSnake.UseVisualStyleBackColor = true;
            this.buttonStartSnake.Click += new System.EventHandler(this.buttonStartSnake_Click);
            // 
            // buttonCheckResult
            // 
            this.buttonCheckResult.Location = new System.Drawing.Point(23, 82);
            this.buttonCheckResult.Name = "buttonCheckResult";
            this.buttonCheckResult.Size = new System.Drawing.Size(119, 23);
            this.buttonCheckResult.TabIndex = 4;
            this.buttonCheckResult.Text = "Check Result";
            this.buttonCheckResult.UseVisualStyleBackColor = true;
            this.buttonCheckResult.Click += new System.EventHandler(this.buttonCheckResult_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 318);
            this.Controls.Add(this.buttonCheckResult);
            this.Controls.Add(this.buttonStartSnake);
            this.Controls.Add(this.buttonCountBlocks);
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
        private System.Windows.Forms.Button buttonCountBlocks;
        private System.Windows.Forms.Button buttonStartSnake;
        private System.Windows.Forms.Button buttonCheckResult;
    }
}

