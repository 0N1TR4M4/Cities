
namespace Cities.View
{
    partial class CitiesVIew
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
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createbtn = new System.Windows.Forms.Button();
            this.populationtxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.populationlbl = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCities
            // 
            this.dgvCities.AutoGenerateColumns = false;
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.city1DataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
            this.dgvCities.DataSource = this.cityBindingSource;
            this.dgvCities.Location = new System.Drawing.Point(33, 32);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.Size = new System.Drawing.Size(252, 390);
            this.dgvCities.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // city1DataGridViewTextBoxColumn
            // 
            this.city1DataGridViewTextBoxColumn.DataPropertyName = "City1";
            this.city1DataGridViewTextBoxColumn.HeaderText = "City";
            this.city1DataGridViewTextBoxColumn.Name = "city1DataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(Cities.Models.City);
            // 
            // createbtn
            // 
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(666, 32);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(109, 47);
            this.createbtn.TabIndex = 1;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // populationtxt
            // 
            this.populationtxt.Location = new System.Drawing.Point(487, 58);
            this.populationtxt.Multiline = true;
            this.populationtxt.Name = "populationtxt";
            this.populationtxt.Size = new System.Drawing.Size(153, 20);
            this.populationtxt.TabIndex = 2;
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(487, 37);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(153, 20);
            this.citytxt.TabIndex = 3;
            this.citytxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylbl.Location = new System.Drawing.Point(443, 37);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(37, 18);
            this.citylbl.TabIndex = 4;
            this.citylbl.Text = "City";
            this.citylbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // populationlbl
            // 
            this.populationlbl.AutoSize = true;
            this.populationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationlbl.Location = new System.Drawing.Point(386, 59);
            this.populationlbl.Name = "populationlbl";
            this.populationlbl.Size = new System.Drawing.Size(94, 20);
            this.populationlbl.TabIndex = 5;
            this.populationlbl.Text = "Population";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(661, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 63);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CitiesVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.populationlbl);
            this.Controls.Add(this.citylbl);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.populationtxt);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.dgvCities);
            this.Name = "CitiesVIew";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn city1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.TextBox populationtxt;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.Label populationlbl;
        private System.Windows.Forms.Button btnUpdate;
    }
}