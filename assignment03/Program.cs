using static System.Runtime.InteropServices.JavaScript.JSType;

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
        static void Prime(int num)
        {
            bool f = false;
            if (num <= 1) return;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    f = true;
                    break;
                }

            }
            if (!f)
                Console.WriteLine(num);
        }
        static void ToBinary(int num)
        {
            char[] bits = new char[32];
            int index = 0;

            
            while (num > 0)
            {
                if (num%2 == 0) bits[index++] = '0';
                else bits[index++] = '1';
                num /= 2;                
                
            }
            Array.Reverse(bits);
            Console.WriteLine(new string(bits));

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
            #region Q6:Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int num1, num2;
            //Console.WriteLine("Test Data");
            //bool f = false;
            //do
            //{
            //    Console.Write("Input starting number of range: ");
            //    f = int.TryParse(Console.ReadLine(), out num1);
            //} while (!f);
            //f = false;
            //do
            //{
            //    Console.Write("Input ending number of range: ");
            //    f = int.TryParse(Console.ReadLine(), out num2);
            //} while (!f);
            //for (int i = num1; i <= num2; i++)
            //{
            //  Prime(i);
            //}
            #endregion
            #region Q7 Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int num1;
            //Console.WriteLine("Test Data");
            //bool f = false;
            //do
            //{
            //    Console.Write("Enter a number to convert : ");
            //    f = int.TryParse(Console.ReadLine(), out num1);
            //} while (!f);
            //ToBinary(num1);
            #endregion
            #region Q8: Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int num1;
            //bool f = false;
            //do
            //{
            //    Console.Write("Enter size of matrix  : ");
            //    f = int.TryParse(Console.ReadLine(), out num1);
            //} while (!f);
            //int[,] Matrix = new int[num1, num1];

            //for(int i = 0; i < num1; i++)
            //{
            //    for(int j = 0; j < num1; j++)
            //    {
            //        if (i == j)
            //            Matrix[i, j] = 1;
            //        else Matrix[i, j] = 0;  
            //    }
            //}
            //for(int i = 0;i < Matrix.Length; i++)
            //{
            //    Console.Write(Matrix[i/Matrix.GetLength(1),i%Matrix.GetLength(1)]);
            //    if ((i+1) % Matrix.GetLength(1) == 0 && i!=0) Console.WriteLine();
            //}
            #endregion
            #region Q9:Write C# program that Extract a substring from a given string.
            //Console.Write("Enter the  string: ");
            //string S = Console.ReadLine();
            //bool f = false;
            //int sIndex;
            //do {
            //    Console.Write("Enter the starting index: ");
            //    f = int.TryParse(Console.ReadLine(),out sIndex);
            //} while(!f);

            //int length;
            //do
            //{
            //    Console.Write("Enter the length of the substring: ");
            //    f = int.TryParse(Console.ReadLine(), out length);
            //} while (!f);
            //try
            //{
            //   Console.WriteLine (S.Substring(sIndex, length));
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion
            #region Q10:Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter the first String: ");
            //string s1=Console.ReadLine();
            //Console.Write("Enter the Second String: ");
            //string s2 = Console.ReadLine();
            //Console.WriteLine($"{s1}{s2}");    
            #endregion
            #region Q11:
            //Solve in Q8
            #endregion
            #region Q12: Write a program in C# Sharp to find the sum of all elements of the array.
          
                //int size;
            
                //bool f = false;
                //do
                //{
                //  Console.Write("Enter the size of the array: ");
                //   f = int.TryParse(Console.ReadLine(), out size);
                //} while (!f || size<=0);
                //int[] arr = new int[size];

                //f = false;
                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < size;)
                //{
                //    Console.Write($"Enter Element {i+1} : ");
                //    f = int.TryParse(Console.ReadLine(), out arr[i] );
                //    if (f) i++;
                
                //}

                //int sum = 0;
                //foreach (int num in arr)
                //{
                //    sum += num;
                //}
               
                //Console.WriteLine($"The sum of all elements in the array is: {sum}" );
            
        #endregion

    }
    }
    }

