namespace prjBiotecnologia
{
    partial class Pergunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta));
            this.lbPergunta = new System.Windows.Forms.Label();
            this.btConferir = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbPergunta
            // 
            this.lbPergunta.AutoSize = true;
            this.lbPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lbPergunta.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPergunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPergunta.Location = new System.Drawing.Point(12, 9);
            this.lbPergunta.Name = "lbPergunta";
            this.lbPergunta.Size = new System.Drawing.Size(155, 40);
            this.lbPergunta.TabIndex = 1;
            this.lbPergunta.Text = "Pergunta 1";
            // 
            // btConferir
            // 
            this.btConferir.BackColor = System.Drawing.Color.Transparent;
            this.btConferir.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btConferir.Location = new System.Drawing.Point(417, 356);
            this.btConferir.Name = "btConferir";
            this.btConferir.Size = new System.Drawing.Size(114, 39);
            this.btConferir.TabIndex = 7;
            this.btConferir.Text = "Corrigir";
            this.btConferir.UseVisualStyleBackColor = false;
            this.btConferir.Click += new System.EventHandler(this.btConferir_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Transparent;
            this.rb1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb1.Location = new System.Drawing.Point(39, 111);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(90, 24);
            this.rb1.TabIndex = 8;
            this.rb1.Text = "resposta1";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Transparent;
            this.rb2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb2.Location = new System.Drawing.Point(39, 189);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(92, 24);
            this.rb2.TabIndex = 9;
            this.rb2.Text = "resposta2";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Transparent;
            this.rb3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb3.Location = new System.Drawing.Point(39, 266);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(92, 24);
            this.rb3.TabIndex = 10;
            this.rb3.Text = "resposta3";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // Pergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 407);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.btConferir);
            this.Controls.Add(this.lbPergunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pergunta";
            this.Load += new System.EventHandler(this.Pergunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPergunta;
        private System.Windows.Forms.Button btConferir;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
    }
}