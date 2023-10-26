using System;

namespace ExcepHand
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                int x = 1, y = 0;
    
                try
                {
                    int r = x / y;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("don't divide number by zero!"+e.StackTrace);
                    throw e;
                }
                catch
                {
                    Console.WriteLine("Catching general exception!");
                }
                finally
                {
                    Console.WriteLine("Inner Finally...");
                    if (y==0)
                        throw new DenominatorNotZero("invalid denominator!",new InvalidCastException());
                }
            }
            catch (DenominatorNotZero e)
                {
                    Console.WriteLine("Denominator should not be zero! & "+e.Message+" & "+e.Source+" & "+e.InnerException);
                }
            catch
            {
                Console.WriteLine("Re-throwing caught exception outside another try...!");
            }
            finally{
                Console.WriteLine("Outer Finally...");
            }
        }
        public class DenominatorNotZero : Exception{
            public DenominatorNotZero(){}
            public DenominatorNotZero(string msg):base(msg){}
            public DenominatorNotZero(string msg,Exception ine):base(msg,ine){}

        }
    }
}