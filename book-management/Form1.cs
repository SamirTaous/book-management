using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace book_management
{
    public partial class Form1 : Form
    {
        private List<Book> books;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        // Book class to store book information
        public class Book
        {
            public int Id { get; set; }
            public string Label { get; set; }
            public int Sold { get; set; }
        }

        // Loads data into the DataGridView and updates statistics
        private void LoadData()
        {
            // Sample data
            books = new List<Book>
            {
                new Book { Id = 1, Label = "Book A", Sold = 5 },
                new Book { Id = 2, Label = "Book B", Sold = 10 },
                new Book { Id = 3, Label = "Book C", Sold = 15 },
                new Book { Id = 4, Label = "Book D", Sold = 20 },
                new Book { Id = 5, Label = "Book E", Sold = 25 }
            };

            // Bind the data to the DataGridView
            BooksDataGrid.DataSource = null; // Clear any existing data
            BooksDataGrid.DataSource = books; // Rebind updated list

            UpdateStatistics();
            UpdateTopAndLeastSelling();
        }

        // Updates total statistics
        private void UpdateStatistics()
        {
            int totalBooks = books.Count;
            int totalSold = books.Sum(b => b.Sold);
            StatisticsLabel.Text = $"Total Books: {totalBooks}, Total Sold: {totalSold}";
        }

        // Updates top-selling and least-selling book labels
        private void UpdateTopAndLeastSelling()
        {
            var topSelling = books.OrderByDescending(b => b.Sold).FirstOrDefault();
            var leastSelling = books.OrderBy(b => b.Sold).FirstOrDefault();

            TopSellingLabel.Text = $"Top Selling Book: {topSelling?.Label} ({topSelling?.Sold} sold)";
            LeastSellingLabel.Text = $"Least Selling Book: {leastSelling?.Label} ({leastSelling?.Sold} sold)";
        }

        // Filter books as you type in the search box
        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = FilterTextBox.Text.ToLower();
            var filteredBooks = books.Where(b => b.Label.ToLower().Contains(searchText)).ToList();
            BooksDataGrid.DataSource = filteredBooks;
            UpdateStatistics();
            UpdateTopAndLeastSelling();
        }

        // Event handler for adding a new book
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            int newId = books.Max(b => b.Id) + 1; // Generate new ID based on max existing ID
            books.Add(new Book { Id = newId, Label = $"New Book {newId}", Sold = 0 });

            // Refresh the DataGridView to display the new book
            LoadData();
        }

        // Event handler for deleting a selected book
        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            var selectedRow = BooksDataGrid.CurrentRow;
            if (selectedRow != null)
            {
                var selectedBook = selectedRow.DataBoundItem as Book;
                if (selectedBook != null)
                {
                    books.Remove(selectedBook); // Remove the selected book
                    LoadData(); // Refresh the data in the DataGridView
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
