using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Library
{
    class LibraryTester
    {
        public static void RunTests()
        {
            Console.WriteLine("Testing the Library class");

            Library l = new Library
            {
                new BookCard(
                    Title: "C# 5.0 in a Nutshell: The Definitive Reference", 
                    Authors: new List<string> {"Joseph Albahari", "Ben Albahari"}, 
                    CatalogNumber: new LCCN(1234560), 
                    SubjectHeadings: new List<string> {"Programming", "C#", "Microsoft"}, 
                    Publisher: "O'Reilly Media", 
                    YearOfPublication: 2012, 
                    InCirulation: true
                ),

                new BookCard(
                    Title: "Microsoft Visual C# 2013 Step by Step (Step by Step Developer)", 
                    Authors: new List<string> {"John Sharp"}, 
                    CatalogNumber: new LCCN(1234561), 
                    SubjectHeadings: new List<string> {"Programming", "C#", "Microsoft"}, 
                    Publisher: " Microsoft Press", 
                    YearOfPublication: 2013, 
                    InCirulation: true
                ),

                new BookCard(
                    Title: "Java: A Beginner's Guide, Sixth Edition", 
                    Authors: new List<string> {"Herbert Schildt"}, 
                    CatalogNumber: new LCCN(1234562), 
                    SubjectHeadings: new List<string> {"Programming", "Java"}, 
                    Publisher: "McGraw-Hill Education", 
                    YearOfPublication: 2014, 
                    InCirulation: false
                ),
            };

            Console.WriteLine(l.SearchBySubject("C#"));
            Console.WriteLine();
        }
    }
}
