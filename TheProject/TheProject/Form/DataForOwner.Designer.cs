
namespace TheProject
{
    partial class DataForOwner
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.projectDataSet = new TheProject.ProjectDataSet();
            this.recieptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recieptTableAdapter = new TheProject.ProjectDataSetTableAdapters.RecieptTableAdapter();
            this.storageSelectionTableAdapter = new TheProject.ProjectDataSetTableAdapters.StorageSelectionTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageInfoForClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importDaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importDaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.importDaoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageInfoForClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDaoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(392, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recieptBindingSource
            // 
            this.recieptBindingSource.DataMember = "Reciept";
            this.recieptBindingSource.DataSource = this.projectDataSet;
            // 
            // recieptTableAdapter
            // 
            this.recieptTableAdapter.ClearBeforeFill = true;
            // 
            // storageSelectionTableAdapter
            // 
            this.storageSelectionTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(439, 80);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(318, 328);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
            // 
            // storageInfoForClientBindingSource
            // 
            this.storageInfoForClientBindingSource.DataSource = typeof(EF.Data.Entities.StorageInfoForClient);
            // 
            // importDaoBindingSource
            // 
            this.importDaoBindingSource.DataSource = typeof(EF.Data.Dao.ImportDao);
            // 
            // importDaoBindingSource1
            // 
            this.importDaoBindingSource1.DataSource = typeof(EF.Data.Dao.ImportDao);
            // 
            // importDaoBindingSource2
            // 
            this.importDaoBindingSource2.DataSource = typeof(EF.Data.Dao.ImportDao);
            // 
            // importBindingSource
            // 
            this.importBindingSource.DataSource = typeof(EF.Data.Entities.Import);
            // 
            // DataForOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataForOwner";
            this.Text = "DataForOwner";
            this.Load += new System.EventHandler(this.DataForOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageInfoForClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDaoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource recieptBindingSource;
        private ProjectDataSetTableAdapters.RecieptTableAdapter recieptTableAdapter;
        private ProjectDataSetTableAdapters.StorageSelectionTableAdapter storageSelectionTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private System.Windows.Forms.BindingSource importDaoBindingSource;
        private System.Windows.Forms.BindingSource importDaoBindingSource1;
        private System.Windows.Forms.BindingSource storageInfoForClientBindingSource;
        private System.Windows.Forms.BindingSource importDaoBindingSource2;
        private System.Windows.Forms.BindingSource importBindingSource;
    }
}