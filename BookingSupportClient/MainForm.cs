using BookingSupportClient.Data;
using BookingSupportClient.Models;
using BookingSupportClient.Services;

namespace BookingSupportClient;

public partial class MainForm : Form
{
    private readonly BookingRepository _repository = new();
    private readonly CheckoutImportService _checkoutImportService;
    private readonly BindingSource _bookingBindingSource = new();
    private bool _loadingSelection;

    public MainForm()
    {
        InitializeComponent();
        _checkoutImportService = new CheckoutImportService(_repository);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            SqlDatabaseInitializer.EnsureCreated();
            statusComboBox.SelectedIndex = 0;
            bookingGrid.AutoGenerateColumns = false;
            bookingGrid.DataSource = _bookingBindingSource;
            RefreshBookings();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Inicializálási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    private void RefreshBookings()
    {
        _loadingSelection = true;
        var bookings = _repository.GetBookings(searchTextBox.Text, statusComboBox.Text);
        _bookingBindingSource.DataSource = bookings;
        _loadingSelection = false;

        if (bookings.Count > 0)
        {
            bookingGrid.Rows[0].Selected = true;
            LoadBookingToEditor(bookings[0]);
        }
        else
        {
            ClearEditor();
        }
    }

    private void bookingGrid_SelectionChanged(object sender, EventArgs e)
    {
        if (_loadingSelection)
        {
            return;
        }

        if (bookingGrid.CurrentRow?.DataBoundItem is BookingRecord booking)
        {
            LoadBookingToEditor(booking);
        }
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        RefreshBookings();
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        searchTextBox.Clear();
        statusComboBox.SelectedIndex = 0;
        RefreshBookings();
    }

    private void newButton_Click(object sender, EventArgs e)
    {
        ClearEditor();
        bookingIdValueLabel.Text = "Új rekord";
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            var booking = BuildBookingFromEditor();
            BookingRecord saved;

            if (booking.BookingId == 0)
            {
                saved = _repository.InsertBooking(booking);
            }
            else
            {
                saved = _repository.UpdateBooking(booking);
            }

            RefreshBookings();
            SelectBooking(saved.BookingId);
            MessageBox.Show(this, "A foglalás mentése sikeres.", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Mentési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(bookingIdHiddenTextBox.Text, out var bookingId) || bookingId == 0)
        {
            return;
        }

        var confirm = MessageBox.Show(
            this,
            "Biztosan törlöd a kiválasztott foglalást?",
            "Törlés megerősítése",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        _repository.DeleteBooking(bookingId);
        RefreshBookings();
    }

    private void addNoteButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(bookingIdHiddenTextBox.Text, out var bookingId) || bookingId == 0)
        {
            MessageBox.Show(this, "Előbb mentsd a foglalást, hogy megjegyzést lehessen hozzáadni.", "Megjegyzés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (string.IsNullOrWhiteSpace(newNoteTextBox.Text))
        {
            MessageBox.Show(this, "A megjegyzés nem lehet üres.", "Megjegyzés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _repository.AddNote(bookingId, newNoteTextBox.Text.Trim(), noteAuthorTextBox.Text.Trim().Length == 0 ? "Support" : noteAuthorTextBox.Text.Trim());
        newNoteTextBox.Clear();
        LoadNotes(bookingId);
    }

    private void importCheckoutButton_Click(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "JSON fájl (*.json)|*.json",
            Title = "Secure checkout payload kiválasztása",
            InitialDirectory = Path.Combine(AppContext.BaseDirectory, "SampleData")
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var imported = _checkoutImportService.ImportFromJsonFile(dialog.FileName);
            RefreshBookings();
            SelectBooking(imported.BookingId);
            MessageBox.Show(this, "A secure checkout adatok sikeresen bekerültek az SQL adatbázisba.", "Checkout import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Checkout import hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private BookingRecord BuildBookingFromEditor()
    {
        if (string.IsNullOrWhiteSpace(customerNameTextBox.Text))
        {
            throw new InvalidOperationException("Az ügyfél neve kötelező.");
        }

        if (string.IsNullOrWhiteSpace(customerContactTextBox.Text))
        {
            throw new InvalidOperationException("Az ügyfél elérhetősége kötelező.");
        }

        if (string.IsNullOrWhiteSpace(productCodeTextBox.Text))
        {
            throw new InvalidOperationException("A termék vagy szolgáltatás azonosítója kötelező.");
        }

        if (string.IsNullOrWhiteSpace(checkoutReferenceTextBox.Text))
        {
            throw new InvalidOperationException("A checkout referencia kötelező.");
        }

        return new BookingRecord
        {
            BookingId = int.TryParse(bookingIdHiddenTextBox.Text, out var bookingId) ? bookingId : 0,
            CustomerName = customerNameTextBox.Text.Trim(),
            CustomerContact = customerContactTextBox.Text.Trim(),
            ProductCode = productCodeTextBox.Text.Trim(),
            BookingDate = bookingDatePicker.Value.Date,
            SelectedDate = selectedDatePicker.Value.Date,
            Status = bookingStatusComboBox.Text,
            CheckoutReference = checkoutReferenceTextBox.Text.Trim(),
            CheckoutDataJson = string.IsNullOrWhiteSpace(checkoutJsonTextBox.Text) ? "{}" : checkoutJsonTextBox.Text.Trim(),
            InternalNotes = internalNotesTextBox.Text.Trim()
        };
    }

    private void LoadBookingToEditor(BookingRecord booking)
    {
        bookingIdHiddenTextBox.Text = booking.BookingId.ToString();
        bookingIdValueLabel.Text = booking.BookingId.ToString();
        customerNameTextBox.Text = booking.CustomerName;
        customerContactTextBox.Text = booking.CustomerContact;
        productCodeTextBox.Text = booking.ProductCode;
        bookingDatePicker.Value = booking.BookingDate;
        selectedDatePicker.Value = booking.SelectedDate;
        bookingStatusComboBox.Text = booking.Status;
        checkoutReferenceTextBox.Text = booking.CheckoutReference;
        checkoutJsonTextBox.Text = booking.CheckoutDataJson;
        internalNotesTextBox.Text = booking.InternalNotes;
        createdValueLabel.Text = booking.CreatedAt.ToLocalTime().ToString("g");
        updatedValueLabel.Text = booking.UpdatedAt.ToLocalTime().ToString("g");
        LoadNotes(booking.BookingId);
    }

    private void LoadNotes(int bookingId)
    {
        notesListBox.Items.Clear();
        foreach (var note in _repository.GetNotes(bookingId))
        {
            notesListBox.Items.Add(note);
        }
    }

    private void ClearEditor()
    {
        bookingIdHiddenTextBox.Text = "0";
        bookingIdValueLabel.Text = "-";
        customerNameTextBox.Clear();
        customerContactTextBox.Clear();
        productCodeTextBox.Clear();
        bookingDatePicker.Value = DateTime.Today;
        selectedDatePicker.Value = DateTime.Today;
        bookingStatusComboBox.SelectedIndex = 0;
        checkoutReferenceTextBox.Text = $"MANUAL-{DateTime.Now:yyyyMMddHHmmss}";
        checkoutJsonTextBox.Text = "{}";
        internalNotesTextBox.Clear();
        createdValueLabel.Text = "-";
        updatedValueLabel.Text = "-";
        notesListBox.Items.Clear();
        newNoteTextBox.Clear();
    }

    private void SelectBooking(int bookingId)
    {
        foreach (DataGridViewRow row in bookingGrid.Rows)
        {
            if (row.DataBoundItem is BookingRecord booking && booking.BookingId == bookingId)
            {
                row.Selected = true;
                bookingGrid.CurrentCell = row.Cells[0];
                return;
            }
        }
    }
}
