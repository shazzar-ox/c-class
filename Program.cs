// See https://aka.ms/new-console-template for more information
//Camel Case 
//Pascal Case 
//Hungarian Case

/*
 * primitive Data Types
 * Get values from the console
 * Operators
 * for loop
*/



//string intNumber
//string IntNumber
//string strIntNum
/*
Console.WriteLine("Please input Your FirstName");
string firstName = Console.ReadLine();
Console.WriteLine("Please input your LastName");
string lastName = Console.ReadLine();

Console.WriteLine("Your firstName is " + firstName + ", your lastname is " + lastName + ".");

Console.WriteLine("Welcome to this year Competition");
Console.WriteLine("Age should be above 18");
Console.WriteLine("Pls input your age");

int ageInput = Convert.ToInt32(Console.ReadLine());
if (ageInput < 18)
{
    Console.WriteLine("You are not qualified to register");
}
else
{
    Console.WriteLine("You registration is complete");
}
*/
/*Operators
Arithmetic Operators + 
prefix a++
postfix ++a
Logiacl Operators && ||
Assignment Operators = += -= *= /= 
Comparison Operators < > >= <= == !=
Bitwise Operators & |
*/

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//int a = 20;
//int b = ++a;

//int c = 20;
//int d = c++;

//Console.WriteLine(d);

//for (int i = 0; i <= 20; i++)
//{
//    if (i % 2 == 1)
//    {
//        double num = i + 0.5;
//        Console.WriteLine(num);
//    }
//}

//Console.WriteLine("Enter your Firstname: ");
//string firstName = Console.ReadLine();
//Console.WriteLine("Enter your Lastname: ");
//string lastName = Console.ReadLine();
//Console.WriteLine("Enter Your Year Of Birth: ");
//int yearOfBirth = Convert.ToInt32(Console.ReadLine());
//int currentYear = 2023;
//int age = currentYear - yearOfBirth;

//Console.WriteLine("Your first name is " + firstName + ", your last name is " + lastName + ". And Your age is " + age);

/*DataTypes
primitive types
 * 
Integral Types
real number 
character
Boolean

* refrence types


*/
// Real Numbers
//float firstNumber = 23.039475678930f;
//decimal secondNumber = 30.0946579856399876543212m;
//double thirdNumber = 30.4332345609839876543212;
//Console.WriteLine("This is the float: "+ firstNumber);
//Console.WriteLine("This is the decimal: " + secondNumber);
//Console.WriteLine("This is the double: " + thirdNumber);

//Console.WriteLine("This is decimal maxvalue: " + decimal.MaxValue);
//Console.WriteLine("This is float maxvalue: " + float.MaxValue);
//Console.WriteLine("This is double maxvalue: " + double.MaxValue);
//string spaceOne = Console.ReadLine();
//Console.WriteLine("This is Decimal minvalue: " + decimal.MinValue);
//Console.WriteLine("This is float minvalue: " + float.MinValue);
//Console.WriteLine("This is double minvalue: " + double.MinValue);


// Integral Numbers
//byte
//sbyte
//int
//long
//ulong
//string spaceThree = Console.ReadLine();
//Console.WriteLine("This is byte maxValue: " + byte.MaxValue);
//Console.WriteLine("This is sByte maxvalue: " + sbyte.MaxValue);
//Console.WriteLine("This is int maxValue: " + int.MaxValue);
//Console.WriteLine("This is long maxvalue: " + long.MaxValue);
//Console.WriteLine("This is ulong maxvalue: " + ulong.MaxValue);
//string spaceTwo = Console.ReadLine();
//Console.WriteLine("This is byte minvalue: " + byte.MinValue);
//Console.WriteLine("This is sbyte minvalue: " + sbyte.MinValue);
//Console.WriteLine("This is int minvalue: " + int.MinValue);
//Console.WriteLine("This is long minvalue: " + long.MinValue);
//Console.WriteLine("This is ulong minvalue: " + ulong.MinValue);


//Char
//char letter = 'T';
//Console.WriteLine(letter);
//Console.WriteLine(char.MinValue);
//Console.WriteLine(char.MaxValue);


//Boolean
//bool yes = true;
//bool no = false;


// datatypes redeclaration
//int numOne; //Initialise
//numOne = 2; // Assign

//int numTwo = 30;
//numTwo = 40;

//Constant // standard way to declare a constant is Pascal Case
//const int Constant = 20;

// How not to declare a variable
//int first Number = 10;  You cant declare a variable with space in it
//int 1first = 20; You cant declare a variable with a number at the biginning
//var while = 20; You cant use a reserved keyword

//for(int i = 20; i > 20; ++i)
//{
//    Console.WriteLine(i);
//}


//int num = 20;

//if (!(!(!(num != 20))))
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}


//for (int i = 0; i <= 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        double rend = i + 0.5;
//        Console.WriteLine(num);
//    }
//}

// Assignment
/*
 * Create a new console application.
 * Prompt the user to enter the total number of values they want to input
 * Use a loop to iterate through the numbers of values specified by the user.
 * Inside the loop, prompt the user to enter each value and store it in a variable
 * Use an if statement to compare the current value with the maximum and minimum values encountered so far.
   (cont.) Update the maximum and minimum variables accordingly
 * After the loop ends, display the maximum and minimum values entered by the user.

   Example:
    Enter the total number of values: 5;
    Enter value 1: 10
    Enter value 2: 5;
    Enter value 3: 8;
    Enter value 4: 2;
    Enter value 5: 15;

    Maximum value:15
    Minimum value:2
 */


Console.ReadLine();