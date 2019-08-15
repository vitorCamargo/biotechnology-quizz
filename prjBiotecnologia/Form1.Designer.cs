namespace prjBiotecnologia
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.PictureBox();
            this.bt2 = new System.Windows.Forms.PictureBox();
            this.bt3 = new System.Windows.Forms.PictureBox();
            this.bt4 = new System.Windows.Forms.PictureBox();
            this.bt5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLHA SEU PERSONAGEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Transparent;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.Image = ((System.Drawing.Image)(resources.GetObject("bt1.Image")));
            this.bt1.Location = new System.Drawing.Point(39, 52);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(145, 120);
            this.bt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt1.TabIndex = 2;
            this.bt1.TabStop = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Transparent;
            this.bt2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt2.BackgroundImage")));
            this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt2.Location = new System.Drawing.Point(59, 208);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(116, 111);
            this.bt2.TabIndex = 3;
            this.bt2.TabStop = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Transparent;
            this.bt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt3.Image = ((System.Drawing.Image)(resources.GetObject("bt3.Image")));
            this.bt3.Location = new System.Drawing.Point(243, 151);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(130, 207);
            this.bt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt3.TabIndex = 4;
            this.bt3.TabStop = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.Transparent;
            this.bt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt4.Image = ((System.Drawing.Image)(resources.GetObject("bt4.Image")));
            this.bt4.Location = new System.Drawing.Point(408, 208);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(169, 138);
            this.bt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt4.TabIndex = 6;
            this.bt4.TabStop = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Transparent;
            this.bt5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt5.BackgroundImage")));
            this.bt5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt5.Location = new System.Drawing.Point(424, 52);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(153, 132);
            this.bt5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt5.TabIndex = 7;
            this.bt5.TabStop = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 331);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Programa Silvio Troll";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bt1;
        private System.Windows.Forms.PictureBox bt2;
        private System.Windows.Forms.PictureBox bt3;
        private System.Windows.Forms.PictureBox bt4;
        private System.Windows.Forms.PictureBox bt5;
    }
}

