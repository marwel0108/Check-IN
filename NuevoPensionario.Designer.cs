namespace Check_IN
{
    partial class NuevoPensionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_Clean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE NUEVO USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE: ";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(179, 78);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(176, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "APELLIDOS: ";
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(179, 160);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(176, 20);
            this.txt_ap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "TELEFONO:";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(179, 236);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(176, 20);
            this.txt_tel.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Agregar.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_Agregar.IconColor = System.Drawing.Color.Indigo;
            this.btn_Agregar.IconSize = 61;
            this.btn_Agregar.Location = new System.Drawing.Point(432, 140);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(64, 61);
            this.btn_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.TabStop = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "La contraseña es: ";
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(216, 308);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 9;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Clean
            // 
            this.btn_Clean.Location = new System.Drawing.Point(400, 308);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(121, 23);
            this.btn_Clean.TabIndex = 10;
            this.btn_Clean.Text = "Limpiar contraseña";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(564, 356);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoUsuario";
            this.Text = "Pension";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel;
        private FontAwesome.Sharp.IconPictureBox btn_Agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_Clean;
    }
}