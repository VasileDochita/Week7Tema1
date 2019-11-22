using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

//Write a program that downloads a file from the Internet(e.g.Ninja image) and stores it the current directory.
//    Find in Google how to download files in C#. 
//    Be sure to catch all exceptions and to free any used resources in the finally block.

namespace Tema1Week7Ex2
{
    class Ex2 //:IDisposable
    {
        static void Main(string[] args)
        {
            using (WebClient download = new WebClient())
            {
                try
                {
                    Console.WriteLine("Attempting download");

                    download.DownloadFile("https://wantsome.ro/wp-content/uploads/2018/09/Wantsome_Logo_Light_cropped.png", "logo WantSome");

                    Console.WriteLine("Download sucessful!");
                }
                catch(ArgumentException argEx)
                {
                    Console.WriteLine("You entered an empty link", argEx.Message);


                }
                catch(WebException webEx)
                {
                    Console.WriteLine("invalid link", webEx.Message);
                }
                finally
                {
                    if (download != null)
                    {
                        download.Dispose();  //Console.WriteLine("Done");

                    }

                }
            }

        }

        //private static void Dispose(WebClient download)
        //{
             
        //}

        //void IDisposable.Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
