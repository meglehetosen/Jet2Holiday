namespace BookingSupportClient;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;
    private DataGridView bookingGrid = null!;
    private TextBox searchTextBox = null!;
    private ComboBox statusComboBox = null!;
    private Button searchButton = null!;
    private Button resetButton = null!;
    private Button newButton = null!;
    private Button saveButton = null!;
    private Button deleteButton = null!;
    private Button importCheckoutButton = null!;
    private TextBox bookingIdHiddenTextBox = null!;
    private Label bookingIdValueLabel = null!;
    private TextBox customerNameTextBox = null!;
    private TextBox customerContactTextBox = null!;
    private TextBox productCodeTextBox = null!;
    private DateTimePicker bookingDatePicker = null!;
    private DateTimePicker selectedDatePicker = null!;
    private ComboBox bookingStatusComboBox = null!;
    private TextBox checkoutReferenceTextBox = null!;
    private TextBox checkoutJsonTextBox = null!;
    private TextBox internalNotesTextBox = null!;
    private ListBox notesListBox = null!;
    private TextBox newNoteTextBox = null!;
    private TextBox noteAuthorTextBox = null!;
    private Button addNoteButton = null!;
    private Label createdValueLabel = null!;
    private Label updatedValueLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        SuspendLayout();
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1460, 860);
        MinimumSize = new Size(1280, 760);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Booking Support Client";
        Load += MainForm_Load;

        var rootLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            Padding = new Padding(12)
        };
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54F));

        var leftPanel = BuildLeftPanel();
        var rightPanel = BuildRightPanel();

        rootLayout.Controls.Add(leftPanel, 0, 0);
        rootLayout.Controls.Add(rightPanel, 1, 0);

        Controls.Add(rootLayout);
        ResumeLayout(false);
    }

    private Control BuildLeftPanel()
    {
        var panel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            RowCount = 3,
            ColumnCount = 1,
            Margin = new Padding(0, 0, 12, 0)
        };
        panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        var filterGroup = new GroupBox
        {
            Text = "Keresés és szűrés",
            Dock = DockStyle.Fill,
            Padding = new Padding(12)
        };

        var filterLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 4,
            RowCount = 2
        };
        filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
        filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
        filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

        searchTextBox = new TextBox { Dock = DockStyle.Fill, PlaceholderText = "Név, termék vagy checkout ref." };
        statusComboBox = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList };
        statusComboBox.Items.AddRange(["All", "Pending", "Confirmed", "Cancelled", "CheckoutCompleted"]);
        searchButton = new Button { Text = "Keresés", Dock = DockStyle.Fill, Height = 32 };
        resetButton = new Button { Text = "Szűrő törlése", Dock = DockStyle.Fill, Height = 32 };
        searchButton.Click += searchButton_Click;
        resetButton.Click += resetButton_Click;

        filterLayout.Controls.Add(new Label { Text = "Kereső", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
        filterLayout.Controls.Add(searchTextBox, 1, 0);
        filterLayout.Controls.Add(new Label { Text = "Státusz", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 2, 0);
        filterLayout.Controls.Add(statusComboBox, 3, 0);
        filterLayout.Controls.Add(searchButton, 2, 1);
        filterLayout.Controls.Add(resetButton, 3, 1);
        filterGroup.Controls.Add(filterLayout);

        bookingGrid = new DataGridView
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            BackgroundColor = SystemColors.Window
        };
        bookingGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BookingId", HeaderText = "ID", FillWeight = 15 });
        bookingGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Ügyfél", FillWeight = 35 });
        bookingGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductCode", HeaderText = "Termék", FillWeight = 25 });
        bookingGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SelectedDate", HeaderText = "Dátum", FillWeight = 25, DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" } });
        bookingGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Státusz", FillWeight = 22 });
        bookingGrid.SelectionChanged += bookingGrid_SelectionChanged;

        var actionPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.LeftToRight,
            AutoSize = true
        };
        newButton = new Button { Text = "Új foglalás", Width = 120, Height = 34 };
        saveButton = new Button { Text = "Mentés", Width = 120, Height = 34 };
        deleteButton = new Button { Text = "Törlés", Width = 120, Height = 34 };
        importCheckoutButton = new Button { Text = "Checkout import", Width = 140, Height = 34 };
        newButton.Click += newButton_Click;
        saveButton.Click += saveButton_Click;
        deleteButton.Click += deleteButton_Click;
        importCheckoutButton.Click += importCheckoutButton_Click;
        actionPanel.Controls.AddRange([newButton, saveButton, deleteButton, importCheckoutButton]);

        panel.Controls.Add(filterGroup, 0, 0);
        panel.Controls.Add(bookingGrid, 0, 1);
        panel.Controls.Add(actionPanel, 0, 2);
        return panel;
    }

    private Control BuildRightPanel()
    {
        var panel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            RowCount = 2,
            ColumnCount = 1
        };
        panel.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
        panel.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));

        var detailsGroup = new GroupBox
        {
            Text = "Foglalás részletei",
            Dock = DockStyle.Fill,
            Padding = new Padding(12)
        };

        var detailsLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 11
        };
        detailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        detailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

        bookingIdHiddenTextBox = new TextBox { Visible = false, Text = "0" };
        bookingIdValueLabel = new Label { Text = "-", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
        customerNameTextBox = new TextBox { Dock = DockStyle.Fill };
        customerContactTextBox = new TextBox { Dock = DockStyle.Fill };
        productCodeTextBox = new TextBox { Dock = DockStyle.Fill };
        bookingDatePicker = new DateTimePicker { Dock = DockStyle.Left, Width = 220, Format = DateTimePickerFormat.Short };
        selectedDatePicker = new DateTimePicker { Dock = DockStyle.Left, Width = 220, Format = DateTimePickerFormat.Short };
        bookingStatusComboBox = new ComboBox { Dock = DockStyle.Left, Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
        bookingStatusComboBox.Items.AddRange(["Pending", "Confirmed", "Cancelled", "CheckoutCompleted"]);
        checkoutReferenceTextBox = new TextBox { Dock = DockStyle.Fill };
        checkoutJsonTextBox = new TextBox { Dock = DockStyle.Fill, Multiline = true, ScrollBars = ScrollBars.Vertical };
        internalNotesTextBox = new TextBox { Dock = DockStyle.Fill, Multiline = true, ScrollBars = ScrollBars.Vertical };
        createdValueLabel = new Label { Text = "-", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
        updatedValueLabel = new Label { Text = "-", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };

        AddDetailsRow(detailsLayout, 0, "Foglalás ID", bookingIdValueLabel);
        AddDetailsRow(detailsLayout, 1, "Ügyfél neve", customerNameTextBox);
        AddDetailsRow(detailsLayout, 2, "Elérhetőség", customerContactTextBox);
        AddDetailsRow(detailsLayout, 3, "Termék / szolgáltatás", productCodeTextBox);
        AddDetailsRow(detailsLayout, 4, "Foglalási dátum", bookingDatePicker);
        AddDetailsRow(detailsLayout, 5, "Kiválasztott dátum", selectedDatePicker);
        AddDetailsRow(detailsLayout, 6, "Státusz", bookingStatusComboBox);
        AddDetailsRow(detailsLayout, 7, "Checkout referencia", checkoutReferenceTextBox);
        AddDetailsRow(detailsLayout, 8, "Checkout JSON", checkoutJsonTextBox, 100F);
        AddDetailsRow(detailsLayout, 9, "Belső megjegyzések", internalNotesTextBox, 100F);

        var auditPanel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 4 };
        auditPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        auditPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        auditPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        auditPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        auditPanel.Controls.Add(new Label { Text = "Létrehozva", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
        auditPanel.Controls.Add(createdValueLabel, 1, 0);
        auditPanel.Controls.Add(new Label { Text = "Módosítva", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 2, 0);
        auditPanel.Controls.Add(updatedValueLabel, 3, 0);
        AddDetailsRow(detailsLayout, 10, "Audit", auditPanel);

        detailsGroup.Controls.Add(detailsLayout);

        var notesGroup = new GroupBox
        {
            Text = "Megjegyzések és feljegyzések",
            Dock = DockStyle.Fill,
            Padding = new Padding(12)
        };

        var notesLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 4
        };
        notesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        notesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        notesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
        notesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));

        notesListBox = new ListBox { Dock = DockStyle.Fill };
        noteAuthorTextBox = new TextBox { Dock = DockStyle.Fill, Text = "Support" };
        newNoteTextBox = new TextBox { Dock = DockStyle.Fill, Multiline = true, ScrollBars = ScrollBars.Vertical };
        addNoteButton = new Button { Text = "Megjegyzés hozzáadása", Dock = DockStyle.Right, Width = 180 };
        addNoteButton.Click += addNoteButton_Click;

        notesLayout.Controls.Add(notesListBox, 0, 0);
        notesLayout.Controls.Add(noteAuthorTextBox, 0, 1);
        notesLayout.Controls.Add(newNoteTextBox, 0, 2);
        notesLayout.Controls.Add(addNoteButton, 0, 3);
        notesGroup.Controls.Add(notesLayout);

        panel.Controls.Add(detailsGroup, 0, 0);
        panel.Controls.Add(notesGroup, 0, 1);
        panel.Controls.Add(bookingIdHiddenTextBox, 0, 0);
        return panel;
    }

    private static void AddDetailsRow(TableLayoutPanel layout, int rowIndex, string labelText, Control control, float height = 34F)
    {
        layout.RowStyles.Add(new RowStyle(rowIndex is 8 or 9 ? SizeType.Percent : SizeType.Absolute, height));
        var label = new Label
        {
            Text = labelText,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft
        };

        control.Margin = new Padding(3);
        control.Dock = DockStyle.Fill;

        layout.Controls.Add(label, 0, rowIndex);
        layout.Controls.Add(control, 1, rowIndex);
    }
}
