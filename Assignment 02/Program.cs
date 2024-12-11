using System;
using System.Globalization;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //int Num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter a number : ");
            //    flag = int.TryParse(Console.ReadLine(), out Num);
            //    if (!flag)
            //    {
            //        Console.WriteLine("Please Enter a Valid Number");
            //    }
            //} while (!flag);
            //Console.WriteLine(Num);


            #endregion

            #region Q2

            //string Text = "Ahmed Ali";

            //// with Parse
            //int TextToIntParse = int.Parse(Text);
            //Console.WriteLine(TextToIntParse);
            //// an exception (runtime error) happens. The input string 'Ahmed Ali' was not in a correct format.

            //// with TryParse
            //int TextToIntTryParse;
            //bool Flag = int.TryParse(Text, out TextToIntTryParse);
            //Console.WriteLine(TextToIntTryParse); // 0
            //// the output is 0 because the coversion was unsuccessful

            //// with Convert
            //int TextToIntConvert = Convert.ToInt32(Text);
            //Console.WriteLine(TextToIntConvert);
            //// an exception (runtime error) happens. The input string 'Ahmed Ali' was not in a correct format.

            #endregion

            #region Q3
            //// using double
            //double ResultDouble = 2.5 + 3.2;
            //Console.WriteLine(ResultDouble); // 5.7

            //// using float 
            //float ResultFloat = 2.5f + 3.2f;
            //// we have to use 'f' after the numbers to convert it to float cause it's double by default
            //Console.WriteLine(ResultFloat); // 5.7

            //// using decimal
            //decimal ResultDecimal = 2.5m + 3.2m;
            //// we have to use 'm' after the numbers to convert it to decimal cause it's double by default
            //Console.WriteLine(ResultDecimal); 

            #endregion

            #region Q4

            //// static string

            //string Name = "Ahmed Ali";
            //string SubStringName = Name.Substring(0, 5);
            //Console.WriteLine(SubStringName);

            //// dynamic string

            //Console.WriteLine("Enter the your string:");
            //string input = Console.ReadLine();


            //bool IndexFlag;
            //int startIndex;
            //do
            //{
            //    Console.WriteLine("Enter the starting index:");
            //    IndexFlag = int.TryParse(Console.ReadLine(), out startIndex);
            //    if (!IndexFlag)
            //    {
            //        Console.WriteLine("Please Enter a valid starting index");
            //    }
            //} while (!IndexFlag);

            //bool LengthFlag;
            //int length;
            //do
            //{
            //    Console.WriteLine("Enter the length of the substring:");
            //    LengthFlag = int.TryParse(Console.ReadLine(), out length);
            //    if (!LengthFlag)
            //    {
            //        Console.WriteLine("Please enter a valid substring length.");
            //    }
            //} while (!LengthFlag);

            //if (startIndex >= 0 && startIndex < input.Length && length >= 0 && startIndex + length <= input.Length)
            //{
            //    string substring = input.Substring(startIndex, length);
            //    Console.WriteLine($"Substring : {substring}");
            //}
            //else
            //{
            //    Console.WriteLine("The starting index or length is out of range.");
            //}

            #endregion

            #region Q5

            //int Num01 = 5, Num02 = Num01;
            //// When we assign Num01 to Num02 we're making a copy of the value

            //Console.WriteLine($"Num01 =  {Num01}"); // 5
            //Console.WriteLine($"Num02 =  {Num02}"); // 5

            //Num01 = 10;
            //// Modifying Num01 does not affect Num02. This is because value types are passed by value not refernce

            //Console.WriteLine("=============================");

            //Console.WriteLine($"Num01 =  {Num01}"); // 10
            //Console.WriteLine($"Num02 =  {Num02}"); // 5

            #endregion

            #region Q6

            //Person Person01 = new Person();
            //Person01.FName = "Ahmed";
            //Person01.LName = "Ali";

            //Person Person02 = Person01;
            //// When we assign Person01 to Person02, we're copying the reference (the memory address) of the object that Person01 points to.
            //// Both Person01 and Person02 now refer to the same Person object in memory.

            //Console.WriteLine($"Person01 First Name : {Person01.FName}, Person01 Last Name : {Person01.LName}"); // Ahmed, Ali
            //Console.WriteLine($"Person02 First Name : {Person02.FName}, Person02 Last Name : {Person02.LName}"); // Ahmed, Ali

            //Person01.FName = "Rana";
            //Person01.LName = "Mohammed";

            //// Since both variables reference the same object, modifying the object through person1 also affects person2
            //// because they are both pointing to the same memory location.

            //Console.WriteLine("==============================================");

            //Console.WriteLine($"Person01 First Name : {Person01.FName}, Person01 Last Name : {Person01.LName}"); // Rana, Mohammed
            //Console.WriteLine($"Person02 First Name : {Person02.FName}, Person02 Last Name : {Person02.LName}"); // Rana, Mohammed

            #endregion

            #region Q7

            //Console.WriteLine("Enter the first string : ");
            //string FirstString = Console.ReadLine();

            //Console.WriteLine("Enter the second string : ");
            //string SecondString = Console.ReadLine();

            //string CombinedString = $"{FirstString} {SecondString}";
            //Console.WriteLine($"Combined String : {CombinedString}");

            #endregion

            #region Q8

            //double principal;
            //bool PrincipalFlag;
            //do
            //{
            //    Console.WriteLine("Enter the principal amount:");
            //    PrincipalFlag = double.TryParse(Console.ReadLine(), out principal);
            //    if (!PrincipalFlag)
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }
            //} while (!PrincipalFlag);

            //double rate;
            //bool RateFlag;
            //do
            //{
            //    Console.WriteLine("Enter the rate of interest:");
            //    RateFlag = double.TryParse(Console.ReadLine(), out rate);
            //    if (!RateFlag)
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }
            //} while (!RateFlag);

            //double time;
            //bool TimeFlag;
            //do
            //{
            //    Console.WriteLine("Enter the time:");
            //    TimeFlag = double.TryParse(Console.ReadLine(), out time);
            //    if (!TimeFlag)
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }
            //} while (!TimeFlag);

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine($"The interest = {interest}");


            #endregion

            #region Q9

            //double Weight;
            //bool WeightFlag;
            //do
            //{
            //    Console.WriteLine("Enter your weight:");
            //    WeightFlag = double.TryParse(Console.ReadLine(), out Weight);
            //    if (!WeightFlag)
            //    {
            //        Console.WriteLine("Please enter a valid weight.");
            //    }
            //} while (!WeightFlag);

            //double Height;
            //bool HeightFlag;
            //do
            //{
            //    Console.WriteLine("Enter your height:");
            //    HeightFlag = double.TryParse(Console.ReadLine(), out Height);
            //    if (!HeightFlag)
            //    {
            //        Console.WriteLine("Please enter a valid height.");
            //    }
            //} while (!HeightFlag);

            //double BMI = Weight / (Height * Height);

            //Console.WriteLine($"BMI = {BMI}");

            #endregion

            #region Q10

            //double Temperature;
            //bool TempFlag;
            //do
            //{
            //    Console.WriteLine("Enter the temperature:");
            //    TempFlag = double.TryParse(Console.ReadLine(), out Temperature);
            //    if (!TempFlag)
            //    {
            //        Console.WriteLine("Please enter a valid degree number.");
            //    }
            //} while (!TempFlag);

            //string Result = (Temperature < 10) ? "Just Cold" : (Temperature > 30) ? "Just Hot" : "Just Good";

            //Console.WriteLine($"Temperature is {Result}");

            #endregion

            #region Q11


            //int Day;
            //bool DayFlag;
            //do
            //{
            //    Console.WriteLine("Enter the day:");
            //    DayFlag = int.TryParse(Console.ReadLine(), out Day);
            //    if (!DayFlag || Day <= 0 || Day > 31)
            //    {
            //        Console.WriteLine("Please enter a valid day (1–31).");
            //    }
            //} while (!DayFlag || Day <= 0 || Day > 31);

            //int Month;
            //bool MonthFlag;
            //do
            //{
            //    Console.WriteLine("Enter the month:");
            //    MonthFlag = int.TryParse(Console.ReadLine(), out Month);
            //    if (!MonthFlag || Month <= 0 || Month > 12)
            //    {
            //        Console.WriteLine("Please enter a valid month (1–12).");
            //    }
            //} while (!MonthFlag || Month <= 0 || Month > 12);

            //int Year;
            //bool YearFlag;
            //do
            //{
            //    Console.WriteLine("Enter the year:");
            //    YearFlag = int.TryParse(Console.ReadLine(), out Year);
            //    if (!YearFlag || Year <= 0)
            //    {
            //        Console.WriteLine("Please enter a valid year (greater than 0).");
            //    }
            //} while (!YearFlag || Year <= 0);

            //Console.WriteLine($"Today’s date: {Day}, {Month}, {Year}");
            //Console.WriteLine($"Today's date: {Day} / {Month} / {Year}");
            //Console.WriteLine($"Today's date: {Day} – {Month} – {Year}");


            #endregion

            #region Q12

            //DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //// c) The event is on 06/14/2024

            #endregion

            #region Q13

            //int d;
            //d = Convert.ToInt32(!(30 < 20)); // true // 1

            //// f) A value 1 will be assigned to d.

            #endregion

            #region Q14

            //Console.WriteLine(13 / 2 + " " + 13 % 2); // 6 1
            //// 6.5 -> 6 cause the default is int , 1 cause 13 is odd

            //// d) 6 1


            #endregion

            #region Q15

            //int num = 1, z = 5;


            //if (!(num <= 0)) // true
            //    Console.WriteLine(++num + z++ + " " + ++z); // 2 + 5 , 7 = 7 7
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //// d) 7 7
            #endregion

        }
    }
}
