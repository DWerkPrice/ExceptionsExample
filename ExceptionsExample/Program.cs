using System;

namespace ExceptionsExample
{
    class Program
    {
        static void Main(string[] args) {

            var a = 1;
            var b = 1;

            try {
                var x = "ABC";
                x = null;
                var len = x.Length;
            }catch(NullReferenceException ex){
                var bce = new BootCampException("Boot camp exception" , ex);
                throw bce;
            }catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }

            try{
                var c = a / (b - b);
            }
            catch(DivideByZeroException ex){
                Console.WriteLine(ex.Message);
            }


            
//            var d = 1 / 0;  visual studio catches this one but not var c = a/(b-b);
        }
    }
}
