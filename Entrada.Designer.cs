namespace Check_IN
{
    partial class Entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Estacionam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_LD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-IN";
            // 
            // btn_Estacionam
            // 
            this.btn_Estacionam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Estacionam.Location = new System.Drawing.Point(187, 122);
            this.btn_Estacionam.Name = "btn_Estacionam";
            this.btn_Estacionam.Size = new System.Drawing.Size(168, 41);
            this.btn_Estacionam.TabIndex = 1;
            this.btn_Estacionam.Text = "Estacionamiento";
            this.btn_Estacionam.UseVisualStyleBackColor = true;
            this.btn_Estacionam.Click += new System.EventHandler(this.btn_Estacionam_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pension";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_LD
            // 
            this.lbl_LD.AutoSize = true;
            this.lbl_LD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LD.Location = new System.Drawing.Point(295, 281);
            this.lbl_LD.Name = "lbl_LD";
            this.lbl_LD.Size = new System.Drawing.Size(0, 16);
            this.lbl_LD.TabIndex = 4;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 292);
            this.Controls.Add(this.lbl_LD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Estacionam);
            this.Controls.Add(this.label1);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Estacionam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_LD;
    }
}