using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BookSwearWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookPath = @"C:\Users\Scott\Documents\themartain.txt";
            string bookText = System.IO.File.ReadAllText(bookPath);
            string bookName = Path.GetFileName(bookPath);
            List<string> bookwords = bookText.Split(',').ToList<string>();
            List<string> swearWords = "shit,fuck,fucking,motherfucking,fuck-off,ass,damn,hell,bastard,bitch,bullshit".Split(',').ToList<string>();
            var sCount = 0;
            var fCount = 0;
            var aCount = 0;
            var dCount = 0;
            var hCount = 0;
            var baCount = 0;
            var biCount = 0;
            var bsCount = 0; 


            foreach (string word in bookwords)
            {
                //Console.WriteLine(word);
                string testWord = word.ToLower();
                foreach (string sw in swearWords)
                {
                    if (testWord.Equals(sw))
                        switch(sw)
                        {
                            case "shit":
                                sCount += 1;
                                break;
                            case "fuck":
                                fCount += 1;
                                break;
                            case "motherfucking":
                                fCount += 1;
                                break;
                            case "motherfucker":
                                fCount += 1;
                                break;
                            case "fuck-off":
                                fCount += 1;
                                break;
                            case "fucking":
                                fCount += 1;
                                break;
                            case "ass":
                                aCount += 1;
                                break;
                            case "damn":
                                dCount += 1;
                                break;
                            case "hell":
                                hCount += 1;
                                break;
                            case "bastard":
                                baCount += 1;
                                break;
                            case "bith":
                                biCount += 1;
                                break;
                            case "bullshit":
                                bsCount += 1;
                                break;
                            default:
                                break;

                        }
                }
                //if (testWord.Equals())
            }

            Console.WriteLine($"Total swear word counts in {bookName}: s-word {sCount} f-word {fCount} a-word {aCount} d-word {dCount} h-word {hCount} ba-word {baCount} bi-word {biCount} bs-word {bsCount}" );
            Console.WriteLine("Press any key to escape...");
            Console.ReadKey();
        }
    }
}
