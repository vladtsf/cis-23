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
        private Form1 parent;

        public AddForm(Form1 parentForm) : this()
        {
            parent = parentForm;
        }
        public AddForm()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            string splitPattern = ",\\s{0,}";

            Library.BookCard book = new Library.BookCard(
                Title: bookTitle.Text,
                Authors: new Library.BookCard.ListOfStrings(Regex.Split(bookAuthors.Text, splitPattern)),
                CatalogNumber: new Library.LCCN((int) bookLccn.Value),
                SubjectHeadings: new Library.BookCard.ListOfStrings(Regex.Split(bookSubjectHeadings.Text, splitPattern)),
                Publisher: bookPublisher.Text,
                YearOfPublication: (int) bookYear.Value,
                InCirulation: bookCirculating.Checked
            );

            Program.BookLibrary.Add(book);
            parent.RefreshTable();
            this.Close();
        }
    }
}
