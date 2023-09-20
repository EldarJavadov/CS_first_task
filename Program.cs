using System;

class Program
{
    private static void Main(string[] args)
    {

        #region

        //int end = 10;
        //int count = 0;

        //for (int number = 2; number <= end; number++)
        //{
        //    bool isPrime = true;

        //    for (int divisor = 2; divisor*divisor <= number; divisor++)
        //    {
        //        if (number % divisor == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }

        //    if (isPrime)
        //    {
        //        count++;
        //    }
        //}

        //Console.WriteLine(count);

        #endregion


        #region
        //int number = 1230;
        //int count = 0;

        //while (number != 0)
        //{
        //    number = number/10;
        //    count++;
        //}
        //Console.WriteLine(count);
        #endregion


        #region
        int number = 9;
        int number1 = 0;

        do
        {
            if (number1 == number)
            {
                Console.WriteLine("3ün qüvvətidir");
                break;
            }
            else
            {
                number1 = number / 3;
                //Console.WriteLine("3ün qüvvəti deyil");
            }
        } while (number1 * number1 <= number);


        
        #endregion

    }
}