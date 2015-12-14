using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Library
{
    [Serializable]
    public class BookCard : ISerializable
    {
        [Serializable]
        public class ListOfStrings : List<string>
        {
            public override string ToString()
            {
                return String.Join(", ", this);
            }

            public ListOfStrings() : base()
            {

            }

            public ListOfStrings(string[] strs) : base(strs)
            {

            }
        }

        public string Title { get; set; }
        public ListOfStrings Authors { get; set; }
        public LCCN CatalogNumber { get; set; }
        public ListOfStrings SubjectHeadings { get; set; }
        public string Publisher { get; set; }
        private int yearOfPublication;
        public bool InCirulation { get; set; }

        // for Windows Forms DataGridView
        public string AuthorList { get { return Authors.ToString(); } }

        // for Windows Forms DataGridView
        public string SubjectHeadingList { get { return SubjectHeadings.ToString(); } }

        public BookCard()
            : this("", new ListOfStrings(), new LCCN(0), new ListOfStrings(), "", 0, false)
        {
        }

        public BookCard(string Title, ListOfStrings Authors, LCCN CatalogNumber, ListOfStrings SubjectHeadings, string Publisher, int YearOfPublication, bool InCirulation)
        {
            this.Title = Title;
            this.Authors = Authors;
            this.CatalogNumber = CatalogNumber;
            this.SubjectHeadings = SubjectHeadings;
            this.Publisher = Publisher;
            this.YearOfPublication = YearOfPublication;
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Authors", Authors);
            info.AddValue("CatalogNumber", (int) CatalogNumber);
            info.AddValue("SubjectHeadings", SubjectHeadings);
            info.AddValue("Publisher", Publisher);
            info.AddValue("YearOfPublication", YearOfPublication);
            info.AddValue("InCirulation", InCirulation);
        }

        public BookCard(SerializationInfo info, StreamingContext context)
            : this(
                  Title: (string)info.GetValue("Title", typeof(string)),
                  Publisher: (string)info.GetValue("Publisher", typeof(string)),
                  YearOfPublication: (int)info.GetValue("YearOfPublication", typeof(int)),
                  InCirulation: (bool)info.GetValue("InCirulation", typeof(bool)),
                  Authors: (ListOfStrings) info.GetValue("Authors", typeof(ListOfStrings)),
                  SubjectHeadings: (ListOfStrings)info.GetValue("SubjectHeadings", typeof(ListOfStrings)),
                  CatalogNumber: new LCCN((int) info.GetValue("CatalogNumber", typeof(int)))
              )
        {}
    }
}
