using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingAgility.AnaPal
{
    /// <summary>
    /// This class will evaluate a string to see if it is an anagram of a palindrome.
    /// </summary>
    public class AnaPal
    {
        public string Text;

        public AnaPal(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Check if a word is an anagram of a palindrome.
        /// </summary>
        public int IsAnagramOfPalindrome
        {
            get
            {
                Dictionary<char, int> frequencies = new Dictionary<char, int>();

                foreach (char c in Text)
                {
                    int count = 1;
                    if (frequencies.ContainsKey(c))
                    {
                        count = frequencies[c] + 1;
                    }

                    frequencies[c] = count;
                }

                int odds = frequencies.Count(kvp => kvp.Value % 2 != 0);

                return (odds == 0 || odds == 1) ? 1 : 0;
            }
        }

        /// <summary>
        /// Build the frequency distribution list from the data in TestData.
        /// </summary>
        public static void PrintFrequencyDistribution()
        {
            foreach (string s in TestData)
            {
                Dictionary<char, int> frequencies = new Dictionary<char, int>();

                foreach (char c in s)
                {
                    int count = 1;
                    if (frequencies.ContainsKey(c))
                    {
                        count = frequencies[c] + 1;
                    }

                    frequencies[c] = count;
                }

                Console.WriteLine(string.Format("Word: {0}", s));
                foreach (KeyValuePair<char, int> kvp in frequencies)
                {
                    Console.WriteLine(string.Format("Key: {0} | Count: {1}", kvp.Key, kvp.Value));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        // this is a list of known palindromes pulled from http://www.palindromelist.net/palindromes-d/
        // wanted a more diverse set of data to confirm frequency distribution of palindromes
        // for a word to be a palindrome, the frequency count of the letters must match the pattern below
        // the frequency for each letter must be divisible by 2, the exception is that the frequency for ONE letter can be odd
        public static readonly string[] TestData = new string[]
                                       {
                                           "daedalusninepeninsuladead",
                                           "dammitimmad",
                                           "decafanddnafaced",
                                           "deesawaseed",
                                           "deified",
                                           "degasarewenotdrawnonwardnoinuniondrawnonwardtonewerasaged",
                                           "deleveled",
                                           "deliasawiwasailed",
                                           "denimaxesexamined",
                                           "dennisandednadinesaidiasenidandednasinned",
                                           "dennisandednasinned",
                                           "dennissinned",
                                           "dennisevesawedenifasafinedewasevesinned",
                                           "dennisnellednaleonnedraanitarolfnoraalicecarolleojanereeddenadalebasilraepennylanadavedennylenaidabernadettebenraylilaninajoiramarasaramariojaninalilyarnebettedanrebadianelynnedevadanalynnepearlisabeladaneddeerenajoelloracecilaaronfloratinaardennoelandellensinned",
                                           "dentistsitned",
                                           "depardieugorazzarogueidraped",
                                           "dessertsidesirenotsolongnolostonerisedistressed",
                                           "dessertsistressed",
                                           "dessertssissensuousnessisstressed",
                                           "detartrated",
                                           "devilneverevenlived",
                                           "devoved",
                                           "dewed",
                                           "diallaid",
                                           "didhannahseebeeshannahdid",
                                           "didiciteoperasarepoeticidid",
                                           "dididoogoddidiasisaididdogoodidid",
                                           "dididrawdellatootalledwardidid",
                                           "didmompopmomdid",
                                           "didiwonstrawwartsnowidid",
                                           "dogeeseseegod",
                                           "dogoodinoevilanonideliverimaimninemoreheromeninsaginawsanitaryswordatuckcarolilorackcutadrowsyratinaswanigasninemoreheromeninmiamireviledinonaliveonidoogod",
                                           "doninemeninterpretninemeninod",
                                           "donotbobtonod",
                                           "doofferreffood",
                                           "doogodnoevildeedliveondogood",
                                           "docnoteidissentafastneverpreventsafatnessidietoncod",
                                           "dogdoogoodgod",
                                           "dognopoopongod",
                                           "dogmainmyhymniamgod",
                                           "dogmaiam",
                                           "dontnod",
                                           "doommood",
                                           "drawkward",
                                           "drabasafoolaloofasabard",
                                           "dratsaddammaddastard",
                                           "dratsuchcustard",
                                           "drawkwanawkward",
                                           "drawninemeninward",
                                           "drawocaesareraseacoward",
                                           "drawpupilslipupward",
                                           "drawward",
                                           "drawocoward",
                                           "drawersreward",
                                           "drawnonward",
                                           "drawnisitserenerestisinward",
                                           "dubyawonnowaybud",
                                           "dumbmud"
                                       };
    }
}
