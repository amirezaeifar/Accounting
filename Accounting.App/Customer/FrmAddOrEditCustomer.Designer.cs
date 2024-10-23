namespace Accounting.App.Customer
{
    partial class FrmAddOrEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrEditCustomer));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLeg = new System.Windows.Forms.RadioButton();
            this.rbIndi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoblie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcCustomer = new System.Windows.Forms.PictureBox();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLeg);
            this.groupBox2.Controls.Add(this.rbIndi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMoblie);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات";
            // 
            // rbLeg
            // 
            this.rbLeg.AutoSize = true;
            this.rbLeg.Location = new System.Drawing.Point(45, 92);
            this.rbLeg.Name = "rbLeg";
            this.rbLeg.Size = new System.Drawing.Size(68, 20);
            this.rbLeg.TabIndex = 10;
            this.rbLeg.TabStop = true;
            this.rbLeg.Text = "حقوقی";
            this.rbLeg.UseVisualStyleBackColor = true;
            // 
            // rbIndi
            // 
            this.rbIndi.AutoSize = true;
            this.rbIndi.Location = new System.Drawing.Point(146, 92);
            this.rbIndi.Name = "rbIndi";
            this.rbIndi.Size = new System.Drawing.Size(69, 20);
            this.rbIndi.TabIndex = 9;
            this.rbIndi.TabStop = true;
            this.rbIndi.Text = "حقیقی";
            this.rbIndi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع شخص:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "آدرس:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(22, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(22, 236);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(194, 49);
            this.txtAddress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ایمیل:";
            // 
            // txtMoblie
            // 
            this.txtMoblie.Location = new System.Drawing.Point(22, 146);
            this.txtMoblie.Name = "txtMoblie";
            this.txtMoblie.Size = new System.Drawing.Size(194, 23);
            this.txtMoblie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "تلفن:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcCustomer);
            this.groupBox1.Controls.Add(this.btnSelectPic);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصویر";
            // 
            // pcCustomer
            // 
            this.pcCustomer.Image = global::Accounting.App.Properties.Resources.vecteezy_default_avatar_profile_icon_vector_in_flat_style_27708418;
            this.pcCustomer.Location = new System.Drawing.Point(6, 22);
            this.pcCustomer.Name = "pcCustomer";
            this.pcCustomer.Size = new System.Drawing.Size(195, 222);
            this.pcCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCustomer.TabIndex = 2;
            this.pcCustomer.TabStop = false;
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Location = new System.Drawing.Point(68, 250);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPic.TabIndex = 1;
            this.btnSelectPic.Text = "انتخاب";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click_1);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtName;
            this.requiredFieldValidator1.ErrorMessage = "نام را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtMoblie;
            this.requiredFieldValidator2.ErrorMessage = "شماره تلفن را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // FrmAddOrEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAddOrEditCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " طرف حساب جدید";
            this.Load += new System.EventHandler(this.FrmAddOrEditCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoblie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcCustomer;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.RadioButton rbLeg;
        private System.Windows.Forms.RadioButton rbIndi;
        private System.Windows.Forms.Label label5;
    }
}