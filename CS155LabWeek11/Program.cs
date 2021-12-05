using System;

namespace CS155LabWeek11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lab11 - Classes with Document objects!");

            string keyword1, keyword2;

            //FIRST EXAMPLE.,

            String s = "I am doing fine. How are you?";
            Document myDoc = new Document(s);
            Email myEmail = new Email (s, "Balaji", "Mark", "Just checking in..");
            File myFile = new File(s, "C:\\temp\\T.txt");

            Console.WriteLine("Checking for keywordS in the Document objects...");
            Console.WriteLine("");

            Console.WriteLine("Document Object #1");
            Console.WriteLine("------------------");
            Console.WriteLine(myDoc.ToString());
            Console.WriteLine(""); 
            keyword1 = "fine";
            if (ContainsKeyword(myDoc, keyword1))
                Console.WriteLine("\t\tThe Document object Has value \"" + keyword1 + "\"");
            else
                Console.WriteLine("\t\tThe Document object Does not have value \"" + keyword1 + "\"");

            keyword2 = "Fine";
            if (ContainsKeyword(myDoc, keyword2))
                Console.WriteLine("\t\tThe Document object Has value \"" + keyword2 + "\"");
            else
                Console.WriteLine("\t\tThe Document object Does not have value \"" + keyword2 + "\"");
            Console.WriteLine("");



            Console.WriteLine("Email Object #1");
            Console.WriteLine("---------------");
            Console.WriteLine(myEmail.ToString());
            Console.WriteLine("");
            keyword1 = "Sender";
            if (ContainsKeyword(myEmail, keyword1))
                Console.WriteLine("\t\tThe Email object Has value \"" + keyword1 + "\"");
            else
                Console.WriteLine("\t\tThe Email object Does not have value \"" + keyword1 + "\"");

            keyword2 = "Subject";
            if (ContainsKeyword(myEmail, keyword2))
                Console.WriteLine("\t\tThe Email object Has value" + keyword2 + "\"");
            else
                Console.WriteLine("\t\tThe Email object Does not have value \"" + keyword2 + "\"");
            Console.WriteLine("");


            Console.WriteLine("File Object #1");
            Console.WriteLine("--------------");
            Console.WriteLine(myFile.ToString());
            Console.WriteLine("");
            keyword1 = "Path";
            if (ContainsKeyword(myFile, keyword1))
                Console.WriteLine("\t\tThe File object Has value \"" + keyword1 + "\"");
            else
                Console.WriteLine("\t\tThe File object Does not have value \"" + keyword1 + "\"");

            keyword2 = "PATH";
            if (ContainsKeyword(myFile, keyword2))
                Console.WriteLine("\t\tThe File object Has value \"" + keyword2 + "\"");
            else
                Console.WriteLine("\t\tThe File object Does not have value \"" + keyword2 + "\"");
            Console.WriteLine("");


            //SECOND EXAMPLE.,

            s = "The semester is ending. When are you done with the lab?";
            myDoc = new Document(s);
            myEmail = new Email(s, "Dan", "Gina", "Hello there..");
            myFile = new File(s, "C:\\temp\\G.txt");

            Console.WriteLine("Document Object #2");
            Console.WriteLine("------------------");
            Console.WriteLine(myDoc.ToString());
            Console.WriteLine("");
            keyword1 = "semester";
            if (ContainsKeyword(myDoc, keyword1))
                Console.WriteLine("\t\tThe Document object Has value \"" + keyword1 + "\"");
            else
                Console.WriteLine("\t\tThe Document object Does not have value \"" + keyword1 + "\"");

            keyword2 = "Semester";
            if (ContainsKeyword(myDoc, keyword2))
                Console.WriteLine("\t\tThe Document object Has value \"" + keyword2 + "\"");
            else
                Console.WriteLine("\t\tThe Document object Does not have value \"" + keyword2 + "\"");
            Console.WriteLine("");



            Console.WriteLine("Email Object #2");
            Console.WriteLine("---------------");
            Console.WriteLine(myEmail.ToString());
            Console.WriteLine("");
            keyword1 = "Recipient";
            if (ContainsKeyword(myEmail, keyword1))
                Console.WriteLine("\t\tThe Email object Has value \"" + keyword1 + "\"");
            else
                Console.WriteLine("\t\tThe Email object Does not have value \"" + keyword1 + "\"");

            keyword2 = "receiver";
            if (ContainsKeyword(myEmail, keyword2))
                Console.WriteLine("\t\tThe Email object Has value" + keyword2 + "\"");
            else
                Console.WriteLine("\t\tThe Email object Does not have value \"" + keyword2 + "\"");
            Console.WriteLine("");


            Console.WriteLine("File Object #2");
            Console.WriteLine("--------------");
            Console.WriteLine(myFile.ToString());
            Console.WriteLine("");
            keyword1 = "lab";
            if (ContainsKeyword(myFile, keyword1))
                Console.WriteLine("\t\tThe File object Has value \"" + keyword1 + "\"");
            else
                Console.WriteLine("\t\tThe File object Does not have value \"" + keyword1 + "\"");

            keyword2 = "Lab";
            if (ContainsKeyword(myFile, keyword2))
                Console.WriteLine("\t\tThe File object Has value \"" + keyword2 + "\"");
            else
                Console.WriteLine("\t\tThe File object Does not have value \"" + keyword2 + "\"");
            Console.WriteLine("");

        }

        public static bool ContainsKeyword(Document docObject, string keyword)

        {

            if (docObject.ToString().IndexOf(keyword, 0) >= 0)

            {

                return true;

            }

            return false;

        }
    }
}
