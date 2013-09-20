using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnitTestCases
{
    public class Support
    {
        Person p2 = new Person();

        
        
 

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
