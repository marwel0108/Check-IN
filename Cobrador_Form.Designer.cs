namespace Check_IN
{
    partial class Cobrador_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobrador_Form));
            this.Menu = new System.Windows.Forms.Panel();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.btn_CobrarE = new FontAwesome.Sharp.IconButton();
            this.btn_CobrarP = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_BtnActual = new System.Windows.Forms.Label();
            this.iconoLogo = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Menu.Controls.Add(this.btn_logout);
            this.Menu.Controls.Add(this.btn_CobrarE);
            this.Menu.Controls.Add(this.btn_CobrarP);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(220, 450);
            this.Menu.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_logout.ForeColor = System.Drawing.Color.Silver;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btn_logout.IconColor = System.Drawing.Color.White;
            this.btn_logout.IconSize = 16;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 260);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_logout.Rotation = 0D;
            this.btn_logout.Size = new System.Drawing.Size(220, 60);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_CobrarE
            // 
            this.btn_CobrarE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CobrarE.FlatAppearance.BorderSize = 0;
            this.btn_CobrarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CobrarE.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_CobrarE.ForeColor = System.Drawing.Color.Silver;
            this.btn_CobrarE.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.btn_CobrarE.IconColor = System.Drawing.Color.White;
            this.btn_CobrarE.IconSize = 16;
            this.btn_CobrarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CobrarE.Location = new System.Drawing.Point(0, 200);
            this.btn_CobrarE.Name = "btn_CobrarE";
            this.btn_CobrarE.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_CobrarE.Rotation = 0D;
            this.btn_CobrarE.Size = new System.Drawing.Size(220, 60);
            this.btn_CobrarE.TabIndex = 5;
            this.btn_CobrarE.Text = "Cobrar estacionamiento";
            this.btn_CobrarE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CobrarE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CobrarE.UseVisualStyleBackColor = true;
            this.btn_CobrarE.Click += new System.EventHandler(this.btn_CobrarE_Click);
            // 
            // btn_CobrarP
            // 
            this.btn_CobrarP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CobrarP.FlatAppearance.BorderSize = 0;
            this.btn_CobrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CobrarP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_CobrarP.ForeColor = System.Drawing.Color.Silver;
            this.btn_CobrarP.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btn_CobrarP.IconColor = System.Drawing.Color.White;
            this.btn_CobrarP.IconSize = 16;
            this.btn_CobrarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CobrarP.Location = new System.Drawing.Point(0, 140);
            this.btn_CobrarP.Name = "btn_CobrarP";
            this.btn_CobrarP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_CobrarP.Rotation = 0D;
            this.btn_CobrarP.Size = new System.Drawing.Size(220, 60);
            this.btn_CobrarP.TabIndex = 3;
            this.btn_CobrarP.Text = "Cobrar pension";
            this.btn_CobrarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CobrarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CobrarP.UseVisualStyleBackColor = true;
            this.btn_CobrarP.Click += new System.EventHandler(this.btn_CobrarP_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(25, 22);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(171, 101);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lb_BtnActual);
            this.panel2.Controls.Add(this.iconoLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 80);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lb_BtnActual
            // 
            this.lb_BtnActual.AutoSize = true;
            this.lb_BtnActual.ForeColor = System.Drawing.Color.Silver;
            this.lb_BtnActual.Location = new System.Drawing.Point(53, 31);
            this.lb_BtnActual.Name = "lb_BtnActual";
            this.lb_BtnActual.Size = new System.Drawing.Size(32, 13);
            this.lb_BtnActual.TabIndex = 1;
            this.lb_BtnActual.Text = "Inicio";
            this.lb_BtnActual.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconoLogo
            // 
            this.iconoLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.iconoLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconoLogo.IconChar = FontAwesome.Sharp.IconChar.HouseDamage;
            this.iconoLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconoLogo.IconSize = 29;
            this.iconoLogo.Location = new System.Drawing.Point(18, 22);
            this.iconoLogo.Name = "iconoLogo";
            this.iconoLogo.Size = new System.Drawing.Size(29, 31);
            this.iconoLogo.TabIndex = 0;
            this.iconoLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 9);
            this.panel3.TabIndex = 2;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 89);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(580, 361);
            this.panelEscritorio.TabIndex = 3;
            // 
            // Cobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Menu);
            this.Name = "Cobrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Cobrador_Load);
            this.Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton btn_CobrarE;
        private FontAwesome.Sharp.IconButton btn_CobrarP;
        private FontAwesome.Sharp.IconButton btn_logout;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconoLogo;
        private System.Windows.Forms.Label lb_BtnActual;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelEscritorio;
    }
}

