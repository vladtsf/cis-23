using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Library
{
    [Serializable]
    public class Library : List<BookCard>, ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Books", this.ToList());
        }

        public Library(SerializationInfo info, StreamingContext context)
        {
            List<BookCard> books = (List<BookCard>) info.GetValue("Books", typeof(List<BookCard>));

            foreach(BookCard book in books)
            {
                this.Add(book);
            }
        }

        public Library() : base() { }

        public Library SearchBySubject(string subject)
        {
            Library found = new Library();

            foreach (BookCard card in this)
            {
                foreach (string _subject in card.SubjectHeadings)
                {
                    if (_subject.Contains(subject))
                    {
                        if(!found.Contains(card))
                        {
                            found.Add(card);
                        }
                    }
                }
            }

            return found;
        }

        public override string ToString()
        {
            string result = "Title\tAuthor\tLCCN";

            foreach (BookCard card in this)
            {
                result += String.Format(Environment.NewLine + "{0}\t{1}\t{2}", 
                    card.Title, 
                    String.Join(", ", card.Authors),
                    card.CatalogNumber);
            }

            return result;
        }
    }
}


/*
Testing the Library class
Title   Author  LCCN
C# 5.0 in a Nutshell: The Definitive Reference  Joseph Albahari, Ben Albahari   12-34560
Microsoft Visual C# 2013 Step by Step (Step by Step Developer)  John Sharp  12-34561
*/