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
            Console.WriteLine("{0}", docName);

            Console.WriteLine("Document Text");
            Console.WriteLine("Enter the text to be saved on the document:");
            docInfo = Console.ReadLine();
            Console.WriteLine("{0}", docInfo);

            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Text.txt");

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
                Console.WriteLine("{0} was successfully saved. The document contains [count] characters.", docName);
            }
        }
    }
}
