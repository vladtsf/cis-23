using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Library
{
    class BookCard
    {
        public string Title;
        public List<string> Authors;
        public LCCN CatalogNumber;
        public List<string> SubjectHeadings;
        public string Publisher;
        private int yearOfPublication;
        public bool InCirulation;

        public BookCard()
            : this("", new List<string>(), new LCCN(0), new List<string>(), "", 0, false)
        {
        }

        public BookCard(string Title, List<string> Authors, LCCN CatalogNumber, List<string> SubjectHeadings, string Publisher, int yearOfPublication, bool InCirulation)
        {
            this.Title = Title;
            this.Authors = Authors;
            this.CatalogNumber = CatalogNumber;
            this.SubjectHeadings = SubjectHeadings;
            this.Publisher = Publisher;
            this.yearOfPublication = yearOfPublication;
            this.InCirulation = InCirulation;
        }

        public int YearOfPublication
        {
            get
            {
                return yearOfPublication;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                yearOfPublication = value;
            }
        }
    }
}
