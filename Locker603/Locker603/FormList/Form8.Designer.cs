
namespace Cus.Form5.NewFolder1
{
    partial class Form8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.centerPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 208);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "보관목록";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "보관소 번호";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "보관소 위치";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "입고 위치";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "입고시각";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "출고시각";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "잔여시간";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
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
            this.firstPageBtn.Location = new System.Drawing.Point(294, 372);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(60, 60);
            this.firstPageBtn.TabIndex = 7;
            this.firstPageBtn.Text = "4";
            this.firstPageBtn.UseVisualStyleBackColor = true;
            this.firstPageBtn.Click += new System.EventHandler(this.TestBtn);
            // 
            // centerPageBtn
            // 
            this.centerPageBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.centerPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.centerPageBtn.FlatAppearance.BorderSize = 0;
            this.centerPageBtn.Location = new System.Drawing.Point(360, 372);
            this.centerPageBtn.Name = "centerPageBtn";
            this.centerPageBtn.Size = new System.Drawing.Size(60, 60);
            this.centerPageBtn.TabIndex = 8;
            this.centerPageBtn.Text = "5";
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
            this.lastPageBtn.Text = "6";
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
            // 
            // Form8
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firstPageBtn;
        private System.Windows.Forms.Button centerPageBtn;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
    }
}