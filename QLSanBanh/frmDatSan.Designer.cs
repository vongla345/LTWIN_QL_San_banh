namespace QLSanBanh
{
    partial class frmDatSan
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
            this.components = new System.ComponentModel.Container();
            this.grInfor = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grFinal = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bt_quayVe = new System.Windows.Forms.Button();
            this.grInfor.SuspendLayout();
            this.grFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // grInfor
            // 
            this.grInfor.Controls.Add(this.txtName);
            this.grInfor.Controls.Add(this.lblTime);
            this.grInfor.Controls.Add(this.txtTime);
            this.grInfor.Controls.Add(this.btnQuery);
            this.grInfor.Controls.Add(this.dtpDate);
            this.grInfor.Controls.Add(this.lblDate);
            this.grInfor.Controls.Add(this.cbType);
            this.grInfor.Controls.Add(this.cbSize);
            this.grInfor.Controls.Add(this.lblType);
            this.grInfor.Controls.Add(this.lblSize);
            this.grInfor.Controls.Add(this.lblName);
            this.grInfor.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfor.Location = new System.Drawing.Point(65, 115);
            this.grInfor.Name = "grInfor";
            this.grInfor.Size = new System.Drawing.Size(884, 226);
            this.grInfor.TabIndex = 0;
            this.grInfor.TabStop = false;
            this.grInfor.Text = "Thông Tin";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(103, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 106);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(92, 23);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Thời gian";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(104, 103);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(290, 31);
            this.txtTime.TabIndex = 8;
            this.txtTime.Enter += new System.EventHandler(this.txtTime_Enter);
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            this.txtTime.Leave += new System.EventHandler(this.txtTime_Leave);
            // 
            // btnQuery
            // 
            this.btnQuery.AutoSize = true;
            this.btnQuery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuery.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Location = new System.Drawing.Point(585, 157);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(135, 46);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "Lọc";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd / HH:mm:ss";
            this.dtpDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(104, 157);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(290, 31);
            this.dtpDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 23);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Ngày đặt";
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(549, 45);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(255, 31);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(549, 102);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(255, 31);
            this.cbSize.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(439, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 23);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Loại sân";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(439, 105);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(104, 23);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Kích thước";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 51);
            this.label5.TabIndex = 8;
            this.label5.Text = "ĐẶT SÂN";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(695, 43);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 46);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(538, 519);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 46);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(116, 53);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(544, 31);
            this.cbSelect.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên sân";
            // 
            // grFinal
            // 
            this.grFinal.Controls.Add(this.cbSelect);
            this.grFinal.Controls.Add(this.label6);
            this.grFinal.Controls.Add(this.btnSubmit);
            this.grFinal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grFinal.Location = new System.Drawing.Point(65, 363);
            this.grFinal.Name = "grFinal";
            this.grFinal.Size = new System.Drawing.Size(884, 141);
            this.grFinal.TabIndex = 11;
            this.grFinal.TabStop = false;
            this.grFinal.Text = "Chọn Sân";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(253, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 46);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Đặt lại";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // bt_quayVe
            // 
            this.bt_quayVe.BackgroundImage = global::QLSanBanh.Properties.Resources.quayVe;
            this.bt_quayVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_quayVe.Location = new System.Drawing.Point(65, 30);
            this.bt_quayVe.Name = "bt_quayVe";
            this.bt_quayVe.Size = new System.Drawing.Size(49, 43);
            this.bt_quayVe.TabIndex = 13;
            this.bt_quayVe.UseVisualStyleBackColor = true;
            this.bt_quayVe.Click += new System.EventHandler(this.bt_quayVe_Click);
            // 
            // frmDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(970, 590);
            this.Controls.Add(this.bt_quayVe);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grFinal);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grInfor);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDatSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Sân";
            this.Load += new System.EventHandler(this.datSan_Load);
            this.grInfor.ResumeLayout(false);
            this.grInfor.PerformLayout();
            this.grFinal.ResumeLayout(false);
            this.grFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grInfor;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grFinal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button bt_quayVe;
    }
}