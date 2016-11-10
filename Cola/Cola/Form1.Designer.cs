namespace Cola
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
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnCaja1 = new System.Windows.Forms.Button();
            this.btnCaja2 = new System.Windows.Forms.Button();
            this.btnCaja3 = new System.Windows.Forms.Button();
            this.btnCaja4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTurno
            // 
            this.btnTurno.Location = new System.Drawing.Point(47, 12);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(133, 47);
            this.btnTurno.TabIndex = 0;
            this.btnTurno.Text = "Cliente";
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnCaja1
            // 
            this.btnCaja1.Location = new System.Drawing.Point(12, 489);
            this.btnCaja1.Name = "btnCaja1";
            this.btnCaja1.Size = new System.Drawing.Size(133, 47);
            this.btnCaja1.TabIndex = 1;
            this.btnCaja1.Text = "Caja 1";
            this.btnCaja1.UseVisualStyleBackColor = true;
            this.btnCaja1.Click += new System.EventHandler(this.btnCaja1_Click);
            // 
            // btnCaja2
            // 
            this.btnCaja2.Location = new System.Drawing.Point(151, 489);
            this.btnCaja2.Name = "btnCaja2";
            this.btnCaja2.Size = new System.Drawing.Size(133, 47);
            this.btnCaja2.TabIndex = 2;
            this.btnCaja2.Text = "Caja 2";
            this.btnCaja2.UseVisualStyleBackColor = true;
            this.btnCaja2.Click += new System.EventHandler(this.btnCaja2_Click);
            // 
            // btnCaja3
            // 
            this.btnCaja3.Location = new System.Drawing.Point(290, 489);
            this.btnCaja3.Name = "btnCaja3";
            this.btnCaja3.Size = new System.Drawing.Size(133, 47);
            this.btnCaja3.TabIndex = 3;
            this.btnCaja3.Text = "Caja 3";
            this.btnCaja3.UseVisualStyleBackColor = true;
            this.btnCaja3.Click += new System.EventHandler(this.btnCaja3_Click);
            // 
            // btnCaja4
            // 
            this.btnCaja4.Location = new System.Drawing.Point(429, 489);
            this.btnCaja4.Name = "btnCaja4";
            this.btnCaja4.Size = new System.Drawing.Size(133, 47);
            this.btnCaja4.TabIndex = 4;
            this.btnCaja4.Text = "Caja 4";
            this.btnCaja4.UseVisualStyleBackColor = true;
            this.btnCaja4.Click += new System.EventHandler(this.btnCaja4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turno";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(322, 46);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 6;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(252, 128);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 13);
            this.lblTurno.TabIndex = 7;
            this.lblTurno.Text = "TURNO";
            this.lblTurno.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(250, 175);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 29);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "lbl3";
            this.lbl3.Visible = false;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Location = new System.Drawing.Point(261, 267);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(33, 13);
            this.lblCaja.TabIndex = 9;
            this.lblCaja.Text = "CAJA";
            this.lblCaja.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(250, 330);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(56, 29);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "lbl4";
            this.lbl4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 548);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaja4);
            this.Controls.Add(this.btnCaja3);
            this.Controls.Add(this.btnCaja2);
            this.Controls.Add(this.btnCaja1);
            this.Controls.Add(this.btnTurno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnCaja1;
        private System.Windows.Forms.Button btnCaja2;
        private System.Windows.Forms.Button btnCaja3;
        private System.Windows.Forms.Button btnCaja4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lbl4;
    }
}