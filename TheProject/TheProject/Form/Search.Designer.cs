
namespace TheProject
{
    partial class Search
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
            this.dgvSearchInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.centerPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchInfo
            // 
            this.dgvSearchInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchInfo.Location = new System.Drawing.Point(12, 121);
            this.dgvSearchInfo.Name = "dgvSearchInfo";
            this.dgvSearchInfo.ReadOnly = true;
            this.dgvSearchInfo.RowHeadersWidth = 51;
            this.dgvSearchInfo.RowTemplate.Height = 27;
            this.dgvSearchInfo.Size = new System.Drawing.Size(776, 208);
            this.dgvSearchInfo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "현재 보관내역";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "총 N개 보관중";
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.firstPageBtn.Location = new System.Drawing.Point(294, 372);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(60, 60);
            this.firstPageBtn.TabIndex = 7;
            this.firstPageBtn.Text = "1";
            this.firstPageBtn.UseVisualStyleBackColor = false;
            this.firstPageBtn.Click += new System.EventHandler(this.TestBtn);
            // 
            // centerPageBtn
            // 
            this.centerPageBtn.BackColor = System.Drawing.SystemColors.Control;
            this.centerPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.centerPageBtn.FlatAppearance.BorderSize = 0;
            this.centerPageBtn.Location = new System.Drawing.Point(360, 372);
            this.centerPageBtn.Name = "centerPageBtn";
            this.centerPageBtn.Size = new System.Drawing.Size(60, 60);
            this.centerPageBtn.TabIndex = 8;
            this.centerPageBtn.Text = "2";
            this.centerPageBtn.UseVisualStyleBackColor = false;
            this.centerPageBtn.Click += new System.EventHandler(this.TestBtn);
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lastPageBtn.Location = new System.Drawing.Point(426, 372);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(60, 60);
            this.lastPageBtn.TabIndex = 9;
            this.lastPageBtn.Text = "3";
            this.lastPageBtn.UseVisualStyleBackColor = false;
            this.lastPageBtn.Click += new System.EventHandler(this.TestBtn);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(151, 476);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(475, 65);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "과거 보관 내역 조회";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "나가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.centerPageBtn);
            this.Controls.Add(this.firstPageBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSearchInfo);
            this.Name = "Search";
            this.Text = "물품 검색";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firstPageBtn;
        private System.Windows.Forms.Button centerPageBtn;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
    }
}