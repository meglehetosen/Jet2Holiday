namespace kliens_alkalmazas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            foglalasIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            userBindingSource = new BindingSource(components);
            productBvinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lokacioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            erkezesDatumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tavozasDatumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendegSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            letrehozasDatumaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCancelledDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            cancellationReasonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastModifiedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            handledByUserIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ejszakakSzamaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBvinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foglalaBindingSource = new BindingSource(components);
            hccProductBindingSource = new BindingSource(components);
            hccOrderBindingSource = new BindingSource(components);
            listBoxUser = new ListBox();
            textBoxUserFilter = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foglalaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hccProductBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hccOrderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { foglalasIdDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, productBvinDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, lokacioDataGridViewTextBoxColumn, erkezesDatumDataGridViewTextBoxColumn, tavozasDatumDataGridViewTextBoxColumn, vendegSzamDataGridViewTextBoxColumn, letrehozasDatumaDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, isCancelledDataGridViewCheckBoxColumn, cancellationReasonDataGridViewTextBoxColumn, lastModifiedDateDataGridViewTextBoxColumn, handledByUserIdDataGridViewTextBoxColumn, bookingReferenceDataGridViewTextBoxColumn, ejszakakSzamaDataGridViewTextBoxColumn, orderBvinDataGridViewTextBoxColumn });
            dataGridView1.DataSource = foglalaBindingSource;
            dataGridView1.Location = new Point(316, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1429, 853);
            dataGridView1.TabIndex = 0;
            // 
            // foglalasIdDataGridViewTextBoxColumn
            // 
            foglalasIdDataGridViewTextBoxColumn.DataPropertyName = "FoglalasId";
            foglalasIdDataGridViewTextBoxColumn.HeaderText = "FoglalasId";
            foglalasIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            foglalasIdDataGridViewTextBoxColumn.Name = "foglalasIdDataGridViewTextBoxColumn";
            foglalasIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.DataSource = userBindingSource;
            userIdDataGridViewTextBoxColumn.DisplayMember = "DisplayName";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            userIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            userIdDataGridViewTextBoxColumn.ValueMember = "UserId";
            userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // productBvinDataGridViewTextBoxColumn
            // 
            productBvinDataGridViewTextBoxColumn.DataPropertyName = "ProductBvin";
            productBvinDataGridViewTextBoxColumn.HeaderText = "ProductBvin";
            productBvinDataGridViewTextBoxColumn.MinimumWidth = 6;
            productBvinDataGridViewTextBoxColumn.Name = "productBvinDataGridViewTextBoxColumn";
            productBvinDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            productBvinDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // lokacioDataGridViewTextBoxColumn
            // 
            lokacioDataGridViewTextBoxColumn.DataPropertyName = "Lokacio";
            lokacioDataGridViewTextBoxColumn.HeaderText = "Lokacio";
            lokacioDataGridViewTextBoxColumn.MinimumWidth = 6;
            lokacioDataGridViewTextBoxColumn.Name = "lokacioDataGridViewTextBoxColumn";
            lokacioDataGridViewTextBoxColumn.Width = 125;
            // 
            // erkezesDatumDataGridViewTextBoxColumn
            // 
            erkezesDatumDataGridViewTextBoxColumn.DataPropertyName = "ErkezesDatum";
            erkezesDatumDataGridViewTextBoxColumn.HeaderText = "ErkezesDatum";
            erkezesDatumDataGridViewTextBoxColumn.MinimumWidth = 6;
            erkezesDatumDataGridViewTextBoxColumn.Name = "erkezesDatumDataGridViewTextBoxColumn";
            erkezesDatumDataGridViewTextBoxColumn.Width = 125;
            // 
            // tavozasDatumDataGridViewTextBoxColumn
            // 
            tavozasDatumDataGridViewTextBoxColumn.DataPropertyName = "TavozasDatum";
            tavozasDatumDataGridViewTextBoxColumn.HeaderText = "TavozasDatum";
            tavozasDatumDataGridViewTextBoxColumn.MinimumWidth = 6;
            tavozasDatumDataGridViewTextBoxColumn.Name = "tavozasDatumDataGridViewTextBoxColumn";
            tavozasDatumDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendegSzamDataGridViewTextBoxColumn
            // 
            vendegSzamDataGridViewTextBoxColumn.DataPropertyName = "VendegSzam";
            vendegSzamDataGridViewTextBoxColumn.HeaderText = "VendegSzam";
            vendegSzamDataGridViewTextBoxColumn.MinimumWidth = 6;
            vendegSzamDataGridViewTextBoxColumn.Name = "vendegSzamDataGridViewTextBoxColumn";
            vendegSzamDataGridViewTextBoxColumn.Width = 125;
            // 
            // letrehozasDatumaDataGridViewTextBoxColumn
            // 
            letrehozasDatumaDataGridViewTextBoxColumn.DataPropertyName = "LetrehozasDatuma";
            letrehozasDatumaDataGridViewTextBoxColumn.HeaderText = "LetrehozasDatuma";
            letrehozasDatumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            letrehozasDatumaDataGridViewTextBoxColumn.Name = "letrehozasDatumaDataGridViewTextBoxColumn";
            letrehozasDatumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // isCancelledDataGridViewCheckBoxColumn
            // 
            isCancelledDataGridViewCheckBoxColumn.DataPropertyName = "IsCancelled";
            isCancelledDataGridViewCheckBoxColumn.HeaderText = "IsCancelled";
            isCancelledDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isCancelledDataGridViewCheckBoxColumn.Name = "isCancelledDataGridViewCheckBoxColumn";
            isCancelledDataGridViewCheckBoxColumn.Width = 125;
            // 
            // cancellationReasonDataGridViewTextBoxColumn
            // 
            cancellationReasonDataGridViewTextBoxColumn.DataPropertyName = "CancellationReason";
            cancellationReasonDataGridViewTextBoxColumn.HeaderText = "CancellationReason";
            cancellationReasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            cancellationReasonDataGridViewTextBoxColumn.Name = "cancellationReasonDataGridViewTextBoxColumn";
            cancellationReasonDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastModifiedDateDataGridViewTextBoxColumn
            // 
            lastModifiedDateDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedDate";
            lastModifiedDateDataGridViewTextBoxColumn.HeaderText = "LastModifiedDate";
            lastModifiedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastModifiedDateDataGridViewTextBoxColumn.Name = "lastModifiedDateDataGridViewTextBoxColumn";
            lastModifiedDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // handledByUserIdDataGridViewTextBoxColumn
            // 
            handledByUserIdDataGridViewTextBoxColumn.DataPropertyName = "HandledByUserId";
            handledByUserIdDataGridViewTextBoxColumn.HeaderText = "HandledByUserId";
            handledByUserIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            handledByUserIdDataGridViewTextBoxColumn.Name = "handledByUserIdDataGridViewTextBoxColumn";
            handledByUserIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingReferenceDataGridViewTextBoxColumn
            // 
            bookingReferenceDataGridViewTextBoxColumn.DataPropertyName = "BookingReference";
            bookingReferenceDataGridViewTextBoxColumn.HeaderText = "BookingReference";
            bookingReferenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookingReferenceDataGridViewTextBoxColumn.Name = "bookingReferenceDataGridViewTextBoxColumn";
            bookingReferenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // ejszakakSzamaDataGridViewTextBoxColumn
            // 
            ejszakakSzamaDataGridViewTextBoxColumn.DataPropertyName = "EjszakakSzama";
            ejszakakSzamaDataGridViewTextBoxColumn.HeaderText = "EjszakakSzama";
            ejszakakSzamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            ejszakakSzamaDataGridViewTextBoxColumn.Name = "ejszakakSzamaDataGridViewTextBoxColumn";
            ejszakakSzamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBvinDataGridViewTextBoxColumn
            // 
            orderBvinDataGridViewTextBoxColumn.DataPropertyName = "OrderBvin";
            orderBvinDataGridViewTextBoxColumn.HeaderText = "OrderBvin";
            orderBvinDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderBvinDataGridViewTextBoxColumn.Name = "orderBvinDataGridViewTextBoxColumn";
            orderBvinDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            orderBvinDataGridViewTextBoxColumn.Width = 125;
            // 
            // foglalaBindingSource
            // 
            foglalaBindingSource.DataSource = typeof(Models.Foglala);
            // 
            // hccProductBindingSource
            // 
            hccProductBindingSource.DataSource = typeof(Models.HccProduct);
            // 
            // hccOrderBindingSource
            // 
            hccOrderBindingSource.DataSource = typeof(Models.HccOrder);
            // 
            // listBoxUser
            // 
            listBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxUser.DataSource = userBindingSource;
            listBoxUser.DisplayMember = "DisplayName";
            listBoxUser.FormattingEnabled = true;
            listBoxUser.Location = new Point(12, 138);
            listBoxUser.Name = "listBoxUser";
            listBoxUser.Size = new Size(298, 844);
            listBoxUser.TabIndex = 1;
            listBoxUser.ValueMember = "UserId";
            listBoxUser.SelectedIndexChanged += listBoxUser_SelectedIndexChanged;
            // 
            // textBoxUserFilter
            // 
            textBoxUserFilter.Location = new Point(12, 33);
            textBoxUserFilter.Name = "textBoxUserFilter";
            textBoxUserFilter.Size = new Size(298, 27);
            textBoxUserFilter.TabIndex = 2;
            textBoxUserFilter.TextChanged += textBoxUserFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 3;
            label1.Text = "Keresés név alapján";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(362, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 28);
            comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1748, 1033);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBoxUserFilter);
            Controls.Add(listBoxUser);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)foglalaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hccProductBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hccOrderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource foglalaBindingSource;
        private ListBox listBoxUser;
        private BindingSource userBindingSource;
        private BindingSource hccProductBindingSource;
        private BindingSource hccOrderBindingSource;
        private TextBox textBoxUserFilter;
        private DataGridViewTextBoxColumn foglalasIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productBvinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lokacioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn erkezesDatumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tavozasDatumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vendegSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letrehozasDatumaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCancelledDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn cancellationReasonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastModifiedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn handledByUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ejszakakSzamaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderBvinDataGridViewTextBoxColumn;
        private Label label1;
        private ComboBox comboBox1;
    }
}
