
namespace TheProject
{
    partial class Payment
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPayFee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.infoTotalFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.payTestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(41, 123);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.RowTemplate.Height = 27;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(719, 150);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComboBoxClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Gulim", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "총 결제금액";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPayFee
            // 
            this.infoPayFee.BackColor = System.Drawing.Color.Gold;
            this.infoPayFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPayFee.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoPayFee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.infoPayFee.Location = new System.Drawing.Point(201, 415);
            this.infoPayFee.Name = "infoPayFee";
            this.infoPayFee.Size = new System.Drawing.Size(559, 49);
            this.infoPayFee.TabIndex = 5;
            this.infoPayFee.Text = "XXX,XXX원 입니다.";
            this.infoPayFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Gulim", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(41, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 49);
            this.label7.TabIndex = 8;
            this.label7.Text = "총 입금금액";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoTotalFee
            // 
            this.infoTotalFee.BackColor = System.Drawing.Color.Gold;
            this.infoTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoTotalFee.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoTotalFee.ForeColor = System.Drawing.SystemColors.Window;
            this.infoTotalFee.Location = new System.Drawing.Point(201, 353);
            this.infoTotalFee.Name = "infoTotalFee";
            this.infoTotalFee.Size = new System.Drawing.Size(559, 49);
            this.infoTotalFee.TabIndex = 9;
            this.infoTotalFee.Text = "XX,XXX원 입니다.";
            this.infoTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Gulim", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 49);
            this.label3.TabIndex = 10;
            this.label3.Text = "선택내역";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "나가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Firebrick;
            this.payBtn.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.payBtn.Location = new System.Drawing.Point(138, 514);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(510, 67);
            this.payBtn.TabIndex = 12;
            this.payBtn.Text = "결제 승인중입니다.";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.PayBtnClick);
            // 
            // payTestBtn
            // 
            this.payTestBtn.Location = new System.Drawing.Point(689, 514);
            this.payTestBtn.Name = "payTestBtn";
            this.payTestBtn.Size = new System.Drawing.Size(75, 67);
            this.payTestBtn.TabIndex = 13;
            this.payTestBtn.Text = "테스트";
            this.payTestBtn.UseVisualStyleBackColor = true;
            this.payTestBtn.Click += new System.EventHandler(this.PayTestBtnClick);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.payTestBtn);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoTotalFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.infoPayFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvInfo);
            this.Name = "Payment";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoPayFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label infoTotalFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Button payTestBtn;
    }
}