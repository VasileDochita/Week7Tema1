using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters the file name along with its full file path(e.g.C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console.Find in MSDN how to use System.IO.File.ReadAllText(...).
//Be sure to catch all possible exceptions and print user-friendly error messages.

namespace Tema1Week7
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileAdress = "C:\\Windows\\win.ini";

            try
            {
                Console.WriteLine("Attempt to read file content :");

                using (StreamReader reader = new StreamReader(fileAdress))
                {
                    Console.WriteLine(File.ReadAllText(fileAdress));
                }

                Console.WriteLine("Reading successful");
            }
            //catch(ArgumentException argEx)
            //{
            //    Console.WriteLine(argEx.Message);
            //}
            catch(ArgumentNullException argNullEx)
            {
                Console.WriteLine(argNullEx.Message);
            }
            
            catch(DriveNotFoundException dnfex)
            {
                Console.WriteLine(dnfex.Message);
            }
            catch (DirectoryNotFoundException dnf)
            {
                 Console.WriteLine(dnf.Message);
            }
            catch(EndOfStreamException endStream)
            {
                Console.WriteLine(endStream.Message);
                Console.WriteLine(endStream.StackTrace);
            }
            catch(FileNotFoundException fileNotFound)
            {
                Console.WriteLine(fileNotFound.Message);
            }
            catch(FileLoadException fileLoadEx)
            {
                Console.WriteLine(fileLoadEx.Message);
            }
            catch(UnauthorizedAccessException access)
            {
                Console.WriteLine(access.Message);
            }
            catch(PathTooLongException path)
            {
                Console.WriteLine(path.Message);
            }
            finally
            {
                Console.WriteLine("ok");
            }
        }
    }
}
