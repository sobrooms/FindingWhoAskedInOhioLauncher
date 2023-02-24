namespace FWAiO
{
    partial class AppAbout
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WinMin = new System.Windows.Forms.Button();
            this.gameName = new System.Windows.Forms.Label();
            this.WinExi = new System.Windows.Forms.Button();
            this.hi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.hi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.WinMin);
            this.panel1.Controls.Add(this.gameName);
            this.panel1.Controls.Add(this.WinExi);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 486);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = ".NET 7.0 STS. WinFormsApp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "v0.0.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "FWAiO Launcher";
            // 
            // WinMin
            // 
            this.WinMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinMin.Location = new System.Drawing.Point(729, 18);
            this.WinMin.Name = "WinMin";
            this.WinMin.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.WinMin.Size = new System.Drawing.Size(30, 30);
            this.WinMin.TabIndex = 5;
            this.WinMin.Text = "--";
            this.WinMin.UseVisualStyleBackColor = true;
            this.WinMin.Click += new System.EventHandler(this.UI_Button_Minimize_Click);
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameName.Location = new System.Drawing.Point(247, 18);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(308, 32);
            this.gameName.TabIndex = 4;
            this.gameName.Text = "Finding Who Asked In Ohio";
            // 
            // WinExi
            // 
            this.WinExi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinExi.Location = new System.Drawing.Point(765, 18);
            this.WinExi.Name = "WinExi";
            this.WinExi.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.WinExi.Size = new System.Drawing.Size(30, 30);
            this.WinExi.TabIndex = 0;
            this.WinExi.Text = "X";
            this.WinExi.UseVisualStyleBackColor = true;
            this.WinExi.Click += new System.EventHandler(this.UI_Button_Exit_Click);
            // 
            // hi
            // 
            this.hi.AutoSize = true;
            this.hi.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hi.Location = new System.Drawing.Point(12, 56);
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(0, 47);
            this.hi.TabIndex = 10;
            // 
            // AppAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(806, 396);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppAbout";
            this.Text = "Finding Who Asked In Ohio";
            this.Load += new System.EventHandler(this.init);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button WinExi;
        private Label gameName;
        private Button WinMin;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label hi;
    }
}