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
            info.AddValue("Books", this.ToArray<BookCard>());
        }

        public Library(SerializationInfo info, StreamingContext context)
        {
            _deserializedBooks = (BookCard[]) info.GetValue("Books", typeof(BookCard[]));
        }

        // used for deserialization
        private BookCard[] _deserializedBooks;

        [OnDeserialized]
        private void RestoreBooks(StreamingContext context) {
            foreach (BookCard book in _deserializedBooks)
            {
                this.Add(book);
            }
            _deserializedBooks = null;
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