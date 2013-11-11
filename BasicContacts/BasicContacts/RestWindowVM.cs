using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicContacts
{
   public class RestWindowVM: BaseVM
   {
       public RestWindowVM()
       {
          // var client = new HttpClient();
           //client.BaseAddress = new Uri("https://apistackexchange.com/2.1/");
           //Log = clent.GetStringAsync("question").Result;
       }
       private string _Log;
       public string Log
       {
           get { return _Log; }
           set { _Log = value; OnPropertyChanged(); }
       }
   }
 }
