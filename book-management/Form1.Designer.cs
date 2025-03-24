namespace book_management
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView BooksDataGrid;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label StatisticsLabel;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.Label TopSellingLabel;
        private System.Windows.Forms.Label LeastSellingLabel;

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
            this.BooksDataGrid = new System.Windows.Forms.DataGridView();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.StatisticsLabel = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.TopSellingLabel = new System.Windows.Forms.Label();
            this.LeastSellingLabel = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).BeginInit();
            this.SuspendLayout();

            // BooksDataGrid
            this.BooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGrid.Location = new System.Drawing.Point(12, 12);
            this.BooksDataGrid.Name = "BooksDataGrid";
            this.BooksDataGrid.Size = new System.Drawing.Size(760, 300);
            this.BooksDataGrid.TabIndex = 0;

            // FilterTextBox
            this.FilterTextBox.Location = new System.Drawing.Point(12, 330);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(200, 20);
            this.FilterTextBox.TabIndex = 1;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);

            // StatisticsLabel
            this.StatisticsLabel.AutoSize = true;
            this.StatisticsLabel.Location = new System.Drawing.Point(12, 360);
            this.StatisticsLabel.Name = "StatisticsLabel";
            this.StatisticsLabel.Size = new System.Drawing.Size(144, 13);
            this.StatisticsLabel.TabIndex = 2;
            this.StatisticsLabel.Text = "Total Books: 0, Total Sold: 0";

            // AddBookButton
            this.AddBookButton.Location = new System.Drawing.Point(220, 330);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 3;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);

            // DeleteBookButton
            this.DeleteBookButton.Location = new System.Drawing.Point(300, 330);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteBookButton.TabIndex = 4;
            this.DeleteBookButton.Text = "Delete Book";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);

            // TopSellingLabel
            this.TopSellingLabel.AutoSize = true;
            this.TopSellingLabel.Location = new System.Drawing.Point(12, 380);
            this.TopSellingLabel.Name = "TopSellingLabel";
            this.TopSellingLabel.Size = new System.Drawing.Size(101, 13);
            this.TopSellingLabel.TabIndex = 5;
            this.TopSellingLabel.Text = "Top Selling Book: -";

            // LeastSellingLabel
            this.LeastSellingLabel.AutoSize = true;
            this.LeastSellingLabel.Location = new System.Drawing.Point(12, 400);
            this.LeastSellingLabel.Name = "LeastSellingLabel";
            this.LeastSellingLabel.Size = new System.Drawing.Size(109, 13);
            this.LeastSellingLabel.TabIndex = 6;
            this.LeastSellingLabel.Text = "Least Selling Book: -";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 478);
            this.Controls.Add(this.LeastSellingLabel);
            this.Controls.Add(this.TopSellingLabel);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.StatisticsLabel);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.BooksDataGrid);
            this.Name = "Form1";
            this.Text = "Books Management";
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
