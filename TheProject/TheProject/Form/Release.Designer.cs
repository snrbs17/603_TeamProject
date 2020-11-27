
namespace TheProject
{
    partial class Release
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.releaseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chargeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 85);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(776, 208);
            this.dgvList.TabIndex = 0;
            // 
            // releaseBtn
            // 
            this.releaseBtn.Location = new System.Drawing.Point(604, 299);
            this.releaseBtn.Name = "releaseBtn";
            this.releaseBtn.Size = new System.Drawing.Size(184, 47);
            this.releaseBtn.TabIndex = 1;
            this.releaseBtn.Text = "총 1건 출고";
            this.releaseBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "보관내역";
            // 
            // chargeLabel
            // 
            this.chargeLabel.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chargeLabel.Location = new System.Drawing.Point(141, 307);
            this.chargeLabel.Name = "chargeLabel";
            this.chargeLabel.Size = new System.Drawing.Size(457, 31);
            this.chargeLabel.TabIndex = 5;
            this.chargeLabel.Text = "출고시 x,xxx원 결제가 필요합니다";
            this.chargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Release
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chargeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.releaseBtn);
            this.Controls.Add(this.dgvList);
            this.Name = "Release";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button releaseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chargeLabel;
    }
}