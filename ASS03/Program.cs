using System.Globalization;
using System.Text;

namespace ASS03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop statements
            ////freq and heard to maintainability
            //Console.WriteLine("1T");
            //Console.WriteLine("2T");
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);


            ////time 3*n+2 less performance and best to cleancode and maintainability
            //for(int i=1;i<=10;i++)
            //    Console.WriteLine($"{i} T");


            #endregion
            #region For _For each
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //continue
            //for (int i = 0; i < Numbers.Length; i++) {
            //    Numbers[i] += 10;
            // if (Numbers[i] == 5) break;
            //    Console.WriteLine(Numbers[i]);
            //}
            ////take copy from array
            //class implement interface iEnumerable
            //Array
            //foreach (int Num in Numbers) {
            //    //Num += 10;
            //    Console.WriteLine(Num + 10);
            //}     
            #endregion
            #region While_Do While
            //int Num;
            //bool flag=false;
            //do {
            //    Console.Write("Enter Even Number:");
            //   // Num = int.Parse(Console.ReadLine());
            //    flag =int.TryParse(Console.ReadLine(), out Num);
            //} while (Num%2==1 || !flag);
            //Console.WriteLine($"{Num} is Even ");
            //int Number = 3;
            //bool flag=false;
            //while (Number%2==1 || !flag)
            //{
            //    Console.Write("Enter Even Number: ");
            //    flag=int.TryParse(Console.ReadLine(),out Number);
            //}
            //Console.WriteLine($"{Number} Is Even");

            #endregion
            #region String
            //class => Reference  type
            //Immutable  data type
            //array of char
            //act as value
            //string Name;
            //Name = new string("Ahmed");
            //Name = "Ahmed";
            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //string Name01 = "Ahmed";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //Name01 = "Nada";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //string message = "Hello";
            //Console.WriteLine(message.GetHashCode());
            //message += "Route";
            //Console.WriteLine(message.GetHashCode());
            #endregion
            #region StringBuilder
            //linked list of char 
            //amenable 
            //StringBuilder sb = new StringBuilder("Hello");
            //sb = "ahmed";//to convert string
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append(" Route");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            #endregion
            #region stringBuilder method
            //StringBuilder sb = new StringBuilder("Welcome");
            //sb.Append("TO Route");
            //sb.AppendLine(" Mostafa");//append string + new line
            //sb.AppendLine("Hany");
            //sb.Remove(0,7);
            //sb.Insert(0,"Hello");
            //int age = 10;
            //string name = "Ali";
            //sb.AppendFormat("Name : {0}, Age : {1}",name,age);
            //sb.AppendJoin('/', "mostafa", "hany", "mohammed");
            //Console.WriteLine(sb);
            #endregion
            #region 1D array
            //int[] Numbers = new int[10];
            //int[] Numbers = new int[3] {1,2,3 };
            //int[] Numbers = new int[]{1,2,3};
            //int[] Numbers ={1,2,3};
            //int[] Numbers = new int[3];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter element {i+1}");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < Numbers.Length; i++) 
            //    Console.WriteLine(Numbers[i]);
            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);
            #endregion
            #region 2D array
            //int[,] Marks = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, {100,200,300,400,500 } };
            //int[,] Marks = new int[3, 5];
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    bool flag;
            //    Console.WriteLine($"Enter Date Student  {i + 1}: ");
            //    for (int j = 0; j < Marks.GetLength(1); )
            //    {
            //        Console.WriteLine($"Enter subject {j+1}: ");
            //       flag =int.TryParse(Console.ReadLine(),out Marks[i,j]);
            //        if (flag && Marks[i,j]>=0) j++;
            //    }

            //}
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($" Date Student  {i + 1}: ");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($" subject {j + 1}:{ Marks[i,j]}");

            //    }

            //}
            //Console.WriteLine(Marks.Rank);//2
            //Console.WriteLine(Marks.GetLength(0));
            //Console.WriteLine(Marks.GetLength(1));
            //for (int i=0;i<Marks.GetLength(0); i++)

            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1),i%Marks.GetLength(1)]);
            //}
            #endregion
            #region judged array
            //int[][] Numbers = new int[3][];
            //Numbers[0] = new int[3] { 1, 2, 3 };
            //Numbers[1] = new int[2] { 4, 5 };
            //Numbers[2] = new int[1] { 6 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(Numbers[i][j]);
            //        
            //        
            //    }
            //}
            //task method in array 
            #endregion
            #region Array Methods
            //int[] numbers = { 1, 2, 3 ,4,5};
            //string []Names = { "Nada", "Noura", "radwa", "nour", "aya" };
          
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

        }
    }
    }

