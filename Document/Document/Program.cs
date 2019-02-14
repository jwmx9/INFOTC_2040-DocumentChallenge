using System;
using System.IO;

namespace Document
{

    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            string docName = "";
            string docInfo = "";

            Console.WriteLine("Document");
            Console.Write("Enter a name for the document: ");
            docName = Console.ReadLine();
            Console.WriteLine("{0}.txt", docName);

            Console.WriteLine("");
            Console.WriteLine("Enter the text to be saved on the document:");
            docInfo = Console.ReadLine();

            //function that counts characters in a string not including spaces
            int CountNonSpaceChars(string value)
            {
                int result = 0;
                foreach (char c in value)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        result++;
                    }
                }
                return result;
            }

            //Console.WriteLine(CountNonSpaceChars(docInfo));

            try
            {
                /*
                // Get the current directory.
                string path = Directory.GetCurrentDirectory();
                string target = @"c:\temp";
                Console.WriteLine("The current directory is {0}", path);
                if (!Directory.Exists(target))
                {
                    Directory.CreateDirectory(target);
                }
                */

                //The current directory is / Users / JohnWilliams / Documents / IT2040 / Document / Document / bin / Debug


                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(docName + ".txt");

                //Write a line of text
                sw.WriteLine("{0}", docInfo);

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("{0}.txt was successfully saved. The document contains {1} characters.", docName, CountNonSpaceChars(docInfo));
            }
        }
    }
}
