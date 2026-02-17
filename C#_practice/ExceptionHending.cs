using System;

namespace C__practice
{
    public class ExceptionHending
    {
        public void TestMethod(int value)
        {
            try // OUTER TRY → application-level handling
            {
                int i = 100;
                int j = 0;

                try // INNER TRY → risky operation handling
                {
                    int k = 100;
                    int l = 0;
                    int m = k / l; // DivideByZeroException

                    Console.WriteLine(m);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Inner catch: Division by zero");
                    throw; // rethrow to outer catch (correct)
                }

                if (value < 10)
                {
                    throw new ArgumentException("Value is less than 10");
                }

                int result = i / j; // Another risky operation
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Outer catch: Division by zero handled - " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Outer catch: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer catch: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
