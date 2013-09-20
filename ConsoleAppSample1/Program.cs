using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppSample1
{

    public delegate int Multiply(int x, int y);

    public class Program
    {        

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your username?");
            string response = Console.ReadLine();

            //var httpClient = new HttpClient();
            //var json = httpClient.GetStringAsync("http://graph.facebook.com/" + response).Result;

            Console.WriteLine("Here's your profile info");
            //Console.Write(json);
            Console.Write(GetProfile(response));

            Console.ReadLine();            
        }

        public static string GetProfile(string username)
        {
            var httpClient = new HttpClient();

            var json = httpClient.GetStringAsync("http://graph.facebook.com/" + username).Result;

            return json;
        }

     
    }
}