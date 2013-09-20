using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnitTestCases
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Support s = new Support();
            MainClass mc = new MainClass();
            var names = new[] { "Bessie", "Vashti", "Frederica", "Nisha", "Kendall", "Magdalena", "Brendon", "Eve", "Manda", "Elvera", "Miquel", "Tyra", "Lucie", "Marvella", "Tracee", "Ramiro", "Irene", "Davina", "Jeromy", "Siu" };
            string[] all=new string[names.Length];
            
            p.Name = names;
            all=mc.AllNames(p.Name);
             Console.WriteLine("Create a list of Persons, each with one of the names");
            foreach (string b in (string[])all.ToArray())
            {
                Console.WriteLine(b);
            }
            s.FirstLetterM(p.Name);
            s.NameUpper(p.Name);
            s.LengthEachName(p.Name);
            s.FirstThreeLetters(p.Name);

           
            Console.ReadKey();

        }
        public string[] AllNames(string[] a)
        {

            //task 1
            /* Console.WriteLine("Create a list of Persons, each with one of the names");
             foreach (string s in (string[])a.ToArray())
             {
                 Console.WriteLine(s);
             }*/
            return a;
        }
        public void FirstLetterM(string[] a)
        {
            /*Console.WriteLine("Create a list of Persons, each with one of the names");
            foreach (string s in (string[])names.ToArray())
            {
                Console.WriteLine(s);
            }*/
            Console.WriteLine("Create the same list then get a subset with only people whose names start with M");
            var mStarts = from s in a.ToList() where s.StartsWith("M") select s;
            foreach (string s in (string[])mStarts.ToArray())
            {
                Console.WriteLine(s);
            }
        }

        public void NameUpper(string[] a)
        {
            //3
            Console.WriteLine("Create the same list then get a list everyone’s names in uppercase ");
            var upper = a.Select(x => x.ToUpper()).ToArray();
            foreach (string s in (string[])upper.ToArray())
            {
                Console.WriteLine(s);
            }

        }
        public void LengthEachName(string[] a)
        {
            //4
            Console.WriteLine("Create the same list then get a and array if int with the length of each name");
            foreach (string s in (string[])a.ToArray())
            {
                Console.WriteLine(s + " --> " + s.Length);
            }
        }
        public void FirstThreeLetters(string[] a)
        {
            //5
            Console.WriteLine("Create the same list then get a list with only the name shortened to the first three letters ordered by name");
            var strfirst3charorder = a.Select(x => x.Substring(0, 3)).OrderBy(x => x);
            foreach (string s in (string[])strfirst3charorder.ToArray())
            {
                Console.WriteLine(s);
            }

        }
    }

}