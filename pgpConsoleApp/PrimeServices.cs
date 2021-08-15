using System;

namespace Prime.Services
{
    public class PrimeService
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("selec * from tabela where id='"+args[0]+"'");
            Console.ReadKey();
        }
        
        static void InserindoDuplicidadeDeCodigo(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("selec * from tabela where id='"+args[0]+"'");
            Console.ReadKey();
        }        
        

        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }

            throw new NotImplementedException("Please create a test first.");
        }
         
    }
}
