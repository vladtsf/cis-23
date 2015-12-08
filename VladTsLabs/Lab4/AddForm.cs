using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            string splitPattern = ",\\s{0,}";

            Library.BookCard book = new Library.BookCard(
                Title: bookTitle.Text,
                Authors: new List<string>(Regex.Split(bookAuthors.Text, splitPattern)),
                CatalogNumber: new Library.LCCN((int) bookLccn.Value),
                SubjectHeadings: new List<string>(Regex.Split(bookSubjectHeadings.Text, splitPattern)),
                Publisher: bookPublisher.Text,
                YearOfPublication: (int) bookYear.Value,
                InCirulation: bookCirculating.Checked
            );

            Program.BookLibrary.Add(book);
            this.Close();
        }
    }
}
