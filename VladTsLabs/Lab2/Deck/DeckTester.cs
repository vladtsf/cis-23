using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Deck
{
    class DeckTester
    {
        public static void RunTests()
        {

            Console.WriteLine("Testing the Deck class");

            Deck d = new Deck();
            Deck dc = d.Clone();
            
            for (int i = 0; i < 20; i++)
            {
                d.shuffle();

                Console.WriteLine("Shuffle {0}:", i + 1);
                Console.WriteLine("Original:" + Environment.NewLine + dc.ToString());
                Console.WriteLine("Shuffled:" + Environment.NewLine + d.ToString());
                Console.WriteLine("Returned to original order: {0}", d.Equals(dc));
                Console.WriteLine("-----------------------");

                if (d.Equals(dc))
                {
                    return;
                }
            }


        }
    }
}


/*

Testing the Deck class
Shuffle 1:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC 6C 3C 7H 10C AD 10H 2D 8S 5H 9S JS 10D
9D 4D QS KH 3D 4S 2H 6D JD 8D AS 8C 6H
2S 5C 2C QD 9C KD JC 3S 7S 8H 9H AH 4C
KS QC 7C QH 4H JH 5S 5D AC 6S 7D 3H 10S

Returned to original order: False
-----------------------
Shuffle 2:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC 2S 6C 5C 3C 2C 7H QD 10C 9C AD KD 10H
JC 2D 3S 8S 7S 5H 8H 9S 9H JS AH 10D 4C
9D KS 4D QC QS 7C KH QH 3D 4H 4S JH 2H
5S 6D 5D JD AC 8D 6S AS 7D 8C 3H 6H 10S

Returned to original order: False
-----------------------
Shuffle 3:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC 9D 2S KS 6C 4D 5C QC 3C QS 2C 7C 7H
KH QD QH 10C 3D 9C 4H AD 4S KD JH 10H 2H
JC 5S 2D 6D 3S 5D 8S JD 7S AC 5H 8D 8H
6S 9S AS 9H 7D JS 8C AH 3H 10D 6H 4C 10S

Returned to original order: False
-----------------------
Shuffle 4:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC JC 9D 5S 2S 2D KS 6D 6C 3S 4D 5D 5C
8S QC JD 3C 7S QS AC 2C 5H 7C 8D 7H 8H
KH 6S QD 9S QH AS 10C 9H 3D 7D 9C JS 4H
8C AD AH 4S 3H KD 10D JH 6H 10H 4C 2H 10S

Returned to original order: False
-----------------------
Shuffle 5:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC KH JC 6S 9D QD 5S 9S 2S QH 2D AS KS
10C 6D 9H 6C 3D 3S 7D 4D 9C 5D JS 5C 4H
8S 8C QC AD JD AH 3C 4S 7S 3H QS KD AC
10D 2C JH 5H 6H 7C 10H 8D 4C 7H 2H 8H 10S

Returned to original order: False
-----------------------
Shuffle 6:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC 8S KH 8C JC QC 6S AD 9D JD QD AH 5S
3C 9S 4S 2S 7S QH 3H 2D QS AS KD KS AC
10C 10D 6D 2C 9H JH 6C 5H 3D 6H 3S 7C 7D
10H 4D 8D 9C 4C 5D 7H JS 2H 5C 8H 4H 10S

Returned to original order: False
-----------------------
Shuffle 7:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC 10C 8S 10D KH 6D 8C 2C JC 9H QC JH 6S
6C AD 5H 9D 3D JD 6H QD 3S AH 7C 5S 7D
3C 10H 9S 4D 4S 8D 2S 9C 7S 4C QH 5D 3H
7H 2D JS QS 2H AS 5C KD 8H KS 4H AC 10S

Returned to original order: False
-----------------------
Shuffle 8:
Original:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Shuffled:
KC 3C 10C 10H 8S 9S 10D 4D KH 4S 6D 8D 8C
2S 2C 9C JC 7S 9H 4C QC QH JH 5D 6S 3H
6C 7H AD 2D 5H JS 9D QS 3D 2H JD AS 6H
5C QD KD 3S 8H AH KS 7C 4H 5S AC 7D 10S

Returned to original order: True
-----------------------


*/