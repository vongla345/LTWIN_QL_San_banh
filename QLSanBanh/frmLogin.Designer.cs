namespace QLSanBanh
{
    partial class frmLogin
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
            this.txtb_tk = new System.Windows.Forms.TextBox();
            this.txtb_pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_tk
            // 
            this.txtb_tk.Location = new System.Drawing.Point(77, 111);
            this.txtb_tk.Name = "txtb_tk";
            this.txtb_tk.Size = new System.Drawing.Size(244, 20);
            this.txtb_tk.TabIndex = 0;
            // 
            // txtb_pass
            // 
            this.txtb_pass.Location = new System.Drawing.Point(77, 137);
            this.txtb_pass.Name = "txtb_pass";
            this.txtb_pass.PasswordChar = '*';
            this.txtb_pass.Size = new System.Drawing.Size(244, 20);
            this.txtb_pass.TabIndex = 1;
            this.txtb_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_pass_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::QLSanBanh.Properties.Resources.user1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QLSanBanh.Properties.Resources.pass;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(47, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 20);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_login.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(136, 172);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(104, 38);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSanBanh.Properties.Resources.bgLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 240);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtb_pass);
            this.Controls.Add(this.txtb_tk);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_tk;
        private System.Windows.Forms.TextBox txtb_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_login;
    }
}