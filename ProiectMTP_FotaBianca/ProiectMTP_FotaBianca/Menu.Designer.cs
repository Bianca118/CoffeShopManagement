namespace ProiectMTP_FotaBianca
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCategorii = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnProd);
            this.panel1.Controls.Add(this.btnCategorii);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 606);
            this.panel1.TabIndex = 0;
            // 
            // btnCategorii
            // 
            this.btnCategorii.FlatAppearance.BorderSize = 0;
            this.btnCategorii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCategorii.Location = new System.Drawing.Point(62, 193);
            this.btnCategorii.Name = "btnCategorii";
            this.btnCategorii.Size = new System.Drawing.Size(166, 46);
            this.btnCategorii.TabIndex = 0;
            this.btnCategorii.Text = "Categorii";
            this.btnCategorii.UseVisualStyleBackColor = true;
            this.btnCategorii.Click += new System.EventHandler(this.btnCategorii_Click);
            // 
            // btnProd
            // 
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProd.Location = new System.Drawing.Point(62, 296);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(166, 46);
            this.btnProd.TabIndex = 1;
            this.btnProd.Text = "Produse";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProiectMTP_FotaBianca.Properties.Resources.rsz_1search;
            this.pictureBox2.InitialImage = global::ProiectMTP_FotaBianca.Properties.Resources.rsz_1coffee_cup;
            this.pictureBox2.Location = new System.Drawing.Point(17, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 60);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProiectMTP_FotaBianca.Properties.Resources.rsz_1coffee_cup;
            this.pictureBox1.InitialImage = global::ProiectMTP_FotaBianca.Properties.Resources.rsz_1coffee_cup;
            this.pictureBox1.Location = new System.Drawing.Point(17, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to CoffePlease";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProiectMTP_FotaBianca.Properties.Resources.rsz_216743436;
            this.panel2.Location = new System.Drawing.Point(442, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 343);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(427, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "With love for out customers";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnCategorii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}