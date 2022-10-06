
namespace ArabaKiralamaHoşgeldiniz
{
    partial class exportform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.arabaKiralamaDataSet = new ArabaKiralamaHoşgeldiniz.ArabaKiralamaDataSet();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTableAdapter1 = new ArabaKiralamaHoşgeldiniz.ArabaKiralamaDataSetTableAdapters.aracTableAdapter();
            this.aracplakanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kirabedeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitestipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisyernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaKiralamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracplakanoDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.kirabedeliDataGridViewTextBoxColumn,
            this.vitestipiDataGridViewTextBoxColumn,
            this.satisyernoDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(350, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arabaKiralamaDataSet
            // 
            this.arabaKiralamaDataSet.DataSetName = "ArabaKiralamaDataSet";
            this.arabaKiralamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataMember = "arac";
            this.aracBindingSource.DataSource = this.arabaKiralamaDataSet;
            // 
            // aracTableAdapter1
            // 
            this.aracTableAdapter1.ClearBeforeFill = true;
            // 
            // aracplakanoDataGridViewTextBoxColumn
            // 
            this.aracplakanoDataGridViewTextBoxColumn.DataPropertyName = "aracplakano";
            this.aracplakanoDataGridViewTextBoxColumn.HeaderText = "aracplakano";
            this.aracplakanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aracplakanoDataGridViewTextBoxColumn.Name = "aracplakanoDataGridViewTextBoxColumn";
            this.aracplakanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
            this.renkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            this.renkDataGridViewTextBoxColumn.Width = 125;
            // 
            // kirabedeliDataGridViewTextBoxColumn
            // 
            this.kirabedeliDataGridViewTextBoxColumn.DataPropertyName = "kirabedeli";
            this.kirabedeliDataGridViewTextBoxColumn.HeaderText = "kirabedeli";
            this.kirabedeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kirabedeliDataGridViewTextBoxColumn.Name = "kirabedeliDataGridViewTextBoxColumn";
            this.kirabedeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // vitestipiDataGridViewTextBoxColumn
            // 
            this.vitestipiDataGridViewTextBoxColumn.DataPropertyName = "vitestipi";
            this.vitestipiDataGridViewTextBoxColumn.HeaderText = "vitestipi";
            this.vitestipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vitestipiDataGridViewTextBoxColumn.Name = "vitestipiDataGridViewTextBoxColumn";
            this.vitestipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // satisyernoDataGridViewTextBoxColumn
            // 
            this.satisyernoDataGridViewTextBoxColumn.DataPropertyName = "satisyerno";
            this.satisyernoDataGridViewTextBoxColumn.HeaderText = "satisyerno";
            this.satisyernoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisyernoDataGridViewTextBoxColumn.Name = "satisyernoDataGridViewTextBoxColumn";
            this.satisyernoDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // exportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "exportform";
            this.Text = "Araba Listesi Export";
            this.Load += new System.EventHandler(this.exportform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaKiralamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ArabaKiralamaDataSet arabaKiralamaDataSet;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private ArabaKiralamaDataSetTableAdapters.aracTableAdapter aracTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracplakanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kirabedeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitestipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisyernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
    }
}