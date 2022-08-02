using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnterpriseLibraryExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseException();

            //DivideByZeroException();  

            FileNotFoundException();  
        }

        public static void BaseException()
        {
            try
            {
                string x = null;
                int a = 10;

                Console.WriteLine(int.Parse(x) + a);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        public static void DivideByZeroException()
        {
            try
            {
                int x = 5;
                int y = 0;
                int z = x / y;
            }
            catch (DivideByZeroException ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        public static void FileNotFoundException()
        {
            try
            {
                // Read in non-existent file.  
                using (StreamReader reader = new StreamReader("TextFile1.txt"))
                {
                    reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }
    }
}
