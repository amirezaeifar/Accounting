namespace Accounting.App
{
    partial class frmNewTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.rbReceive = new System.Windows.Forms.RadioButton();
            this.rbpay = new System.Windows.Forms.RadioButton();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgCustomers);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طرف حساب‌ها";
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgCustomers.Location = new System.Drawing.Point(6, 60);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersWidth = 51;
            this.dgCustomers.RowTemplate.Height = 24;
            this.dgCustomers.Size = new System.Drawing.Size(188, 263);
            this.dgCustomers.TabIndex = 1;
            this.dgCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellClick);
            this.dgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(188, 23);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "نوع تراکنش:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "مقدار:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "توضیحات:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 21);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(198, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(33, 197);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(180, 94);
            this.txtDiscription.TabIndex = 6;
            // 
            // rbReceive
            // 
            this.rbReceive.AutoSize = true;
            this.rbReceive.Location = new System.Drawing.Point(70, 98);
            this.rbReceive.Name = "rbReceive";
            this.rbReceive.Size = new System.Drawing.Size(112, 20);
            this.rbReceive.TabIndex = 7;
            this.rbReceive.TabStop = true;
            this.rbReceive.Text = "حساب دریافتی";
            this.rbReceive.UseVisualStyleBackColor = true;
            // 
            // rbpay
            // 
            this.rbpay.AutoSize = true;
            this.rbpay.Location = new System.Drawing.Point(67, 72);
            this.rbpay.Name = "rbpay";
            this.rbpay.Size = new System.Drawing.Size(115, 20);
            this.rbpay.TabIndex = 8;
            this.rbpay.TabStop = true;
            this.rbpay.Text = "حساب پرداختی";
            this.rbpay.UseVisualStyleBackColor = true;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(30, 142);
            this.nudAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(179, 23);
            this.nudAmount.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.nudAmount;
            this.rangeValidator1.ErrorMessage = "مقدار را وارد کنید";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "9999999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtName;
            this.requiredFieldValidator1.ErrorMessage = "یک طرف حساب را انتخاب کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام طرف حساب";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.rbpay);
            this.Controls.Add(this.rbReceive);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.frmNewTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.RadioButton rbReceive;
        private System.Windows.Forms.RadioButton rbpay;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnSave;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}