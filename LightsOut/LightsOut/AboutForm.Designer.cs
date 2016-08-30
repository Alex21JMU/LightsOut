namespace LightsOut
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.Title = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Yellow;
            this.Title.Location = new System.Drawing.Point(86, 48);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(155, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Lights Out!";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator.ForeColor = System.Drawing.Color.White;
            this.Creator.Location = new System.Drawing.Point(34, 97);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(216, 19);
            this.Creator.TabIndex = 1;
            this.Creator.Text = "Created by Alejandro Martinez";
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.Color.White;
            this.Instructions.Location = new System.Drawing.Point(55, 116);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(167, 76);
            this.Instructions.TabIndex = 2;
            this.Instructions.Text = "Lights on are white,\r\nlights off are black.\r\nMake all the Lights Out!\r\nto win the" +
    " game.";
            this.Instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(101, 218);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.Title);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Creator;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}