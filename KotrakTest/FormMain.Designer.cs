namespace KotrakTest
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonTest = new System.Windows.Forms.Button();
            this.dataGridViewContractorsTable = new System.Windows.Forms.DataGridView();
            this.contractorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testContractorsDataSet = new KotrakTest.TestContractorsDataSet();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.contractorsTableAdapter = new KotrakTest.TestContractorsDataSetTableAdapters.ContractorsTableAdapter();
            this.contractoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractorsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testContractorsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(584, 12);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // dataGridViewContractorsTable
            // 
            this.dataGridViewContractorsTable.AutoGenerateColumns = false;
            this.dataGridViewContractorsTable.CausesValidation = false;
            this.dataGridViewContractorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContractorsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractoridDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nipDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewContractorsTable.DataSource = this.contractorsBindingSource;
            this.dataGridViewContractorsTable.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewContractorsTable.Name = "dataGridViewContractorsTable";
            this.dataGridViewContractorsTable.Size = new System.Drawing.Size(647, 347);
            this.dataGridViewContractorsTable.TabIndex = 1;
            this.dataGridViewContractorsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContractorsTable_CellContentClick);
            this.dataGridViewContractorsTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContractorsTable_CellContentClick);
            // 
            // contractorsBindingSource
            // 
            this.contractorsBindingSource.DataMember = "Contractors";
            this.contractorsBindingSource.DataSource = this.testContractorsDataSet;
            // 
            // testContractorsDataSet
            // 
            this.testContractorsDataSet.DataSetName = "TestContractorsDataSet";
            this.testContractorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(503, 12);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 2;
            this.buttonAddNew.Text = "Dodaj";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(422, 12);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRecord.TabIndex = 3;
            this.buttonDeleteRecord.Text = "Usuń";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 41);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(647, 20);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // contractorsTableAdapter
            // 
            this.contractorsTableAdapter.ClearBeforeFill = true;
            // 
            // contractoridDataGridViewTextBoxColumn
            // 
            this.contractoridDataGridViewTextBoxColumn.DataPropertyName = "contractor_id";
            this.contractoridDataGridViewTextBoxColumn.HeaderText = "contractor_id";
            this.contractoridDataGridViewTextBoxColumn.Name = "contractoridDataGridViewTextBoxColumn";
            this.contractoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nipDataGridViewTextBoxColumn
            // 
            this.nipDataGridViewTextBoxColumn.DataPropertyName = "nip";
            this.nipDataGridViewTextBoxColumn.HeaderText = "nip";
            this.nipDataGridViewTextBoxColumn.Name = "nipDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(671, 426);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.dataGridViewContractorsTable);
            this.Controls.Add(this.buttonTest);
            this.Name = "FormMain";
            this.Text = "Panel Kontrahentów";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractorsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testContractorsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.DataGridView dataGridViewContractorsTable;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.TextBox textBoxSearch;
        private TestContractorsDataSet testContractorsDataSet;
        private System.Windows.Forms.BindingSource contractorsBindingSource;
        private TestContractorsDataSetTableAdapters.ContractorsTableAdapter contractorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}

