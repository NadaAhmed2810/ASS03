namespace assignment03
{
    internal class Program
    {
       static string reversestring(string input)
        {
           char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            #region Q1: Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //bool flag = false;
            //int num;
            //do
            //{
            //    Console.Write("Enter a Number:");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write($"{i.ToString()} , ");
            //}
            #endregion

            #region  Q2:Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int num;
            //bool f = false;
            //do
            //{
            //    Console.Write("Enter a Number:");
            //    f = int.TryParse(Console.ReadLine(), out num);
            //} while (!f);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i*num);
            //}
            #endregion
            #region Q3:Write a program that allows to user to insert number then print all even numbers between 1 to this number
            // int num;
            //bool f = false;
            // do
            // {
            //     Console.Write("Enter a Number:");
            //     f = int.TryParse(Console.ReadLine(), out num);
            // } while (!f);
            // for(int i = 2; i <= num; i++)
            // {
            //     if(i%2==0)
            //         Console.WriteLine(i);
            // }
            #endregion
            #region  Q4: Write a program that takes two integers then prints the power.
            // int Base , power,res=1;
            // bool f ,f1= false;
            //  do
            //  {
            //      Console.Write("Enter a base:");
            //      f = int.TryParse(Console.ReadLine(), out Base);
            //  } while (!f);
            // do
            // {
            //     Console.Write("Enter a power:");
            //     f1 = int.TryParse(Console.ReadLine(), out power);
            // } while (!f1);
            // for (int i = 0; i < power; i++)
            //     res *= Base;
            //Console.WriteLine(res);
            #endregion
            #region Q5:Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter String");
            //string S=Console.ReadLine();
            //string x= reversestring(S);
            //Console.WriteLine(x);

            #endregion
        }
    }
}
