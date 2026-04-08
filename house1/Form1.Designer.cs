namespace house1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.ComboBox cmbDownPaymentMode;
        private System.Windows.Forms.Label lblDownPaymentUnit;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.NumericUpDown numLoanTerm;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.NumericUpDown numGracePeriod;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;

        private void InitializeComponent()
        {
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.cmbDownPaymentMode = new System.Windows.Forms.ComboBox();
            this.lblDownPaymentUnit = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.numLoanTerm = new System.Windows.Forms.NumericUpDown();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.numGracePeriod = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGracePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalPrice.Location = new System.Drawing.Point(24, 22);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(125, 15);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "房屋總價 (當地貨幣):";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalPrice.Location = new System.Drawing.Point(190, 18);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(122, 23);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "10000000";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDownPayment.Location = new System.Drawing.Point(24, 62);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(49, 15);
            this.lblDownPayment.TabIndex = 2;
            this.lblDownPayment.Text = "自備款:";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDownPayment.Location = new System.Drawing.Point(190, 58);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(120, 23);
            this.txtDownPayment.TabIndex = 3;
            this.txtDownPayment.Text = "20";
            // 
            // cmbDownPaymentMode
            // 
            this.cmbDownPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownPaymentMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDownPaymentMode.Items.AddRange(new object[] {
            "百分比 (%)",
            "金額"});
            this.cmbDownPaymentMode.Location = new System.Drawing.Point(320, 58);
            this.cmbDownPaymentMode.Name = "cmbDownPaymentMode";
            this.cmbDownPaymentMode.Size = new System.Drawing.Size(120, 23);
            this.cmbDownPaymentMode.TabIndex = 4;
            this.cmbDownPaymentMode.SelectedIndexChanged += new System.EventHandler(this.cmbDownPaymentMode_SelectedIndexChanged);
            // 
            // lblDownPaymentUnit
            // 
            this.lblDownPaymentUnit.AutoSize = true;
            this.lblDownPaymentUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDownPaymentUnit.Location = new System.Drawing.Point(162, 62);
            this.lblDownPaymentUnit.Name = "lblDownPaymentUnit";
            this.lblDownPaymentUnit.Size = new System.Drawing.Size(25, 15);
            this.lblDownPaymentUnit.TabIndex = 5;
            this.lblDownPaymentUnit.Text = "(%)";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInterestRate.Location = new System.Drawing.Point(24, 102);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(70, 15);
            this.lblInterestRate.TabIndex = 6;
            this.lblInterestRate.Text = "年利率 (%):";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInterestRate.Location = new System.Drawing.Point(190, 100);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 23);
            this.txtInterestRate.TabIndex = 7;
            this.txtInterestRate.Text = "2.15";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoanTerm.Location = new System.Drawing.Point(24, 142);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(86, 15);
            this.lblLoanTerm.TabIndex = 8;
            this.lblLoanTerm.Text = "貸款年限 (年):";
            // 
            // numLoanTerm
            // 
            this.numLoanTerm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numLoanTerm.Location = new System.Drawing.Point(190, 140);
            this.numLoanTerm.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLoanTerm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLoanTerm.Name = "numLoanTerm";
            this.numLoanTerm.Size = new System.Drawing.Size(80, 23);
            this.numLoanTerm.TabIndex = 9;
            this.numLoanTerm.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGracePeriod.Location = new System.Drawing.Point(24, 182);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(112, 15);
            this.lblGracePeriod.TabIndex = 10;
            this.lblGracePeriod.Text = "寬限期 (年，選填):";
            // 
            // numGracePeriod
            // 
            this.numGracePeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numGracePeriod.Location = new System.Drawing.Point(190, 180);
            this.numGracePeriod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGracePeriod.Name = "numGracePeriod";
            this.numGracePeriod.Size = new System.Drawing.Size(80, 23);
            this.numGracePeriod.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(24, 222);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 34);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "試算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtResult.Location = new System.Drawing.Point(24, 270);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(634, 98);
            this.txtResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(682, 398);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.cmbDownPaymentMode);
            this.Controls.Add(this.lblDownPaymentUnit);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.numLoanTerm);
            this.Controls.Add(this.lblGracePeriod);
            this.Controls.Add(this.numGracePeriod);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房貸試算";
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGracePeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

