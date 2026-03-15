#region Q1
// Why the code is inefficient
// The code is inefficient because strings in C# are immutable, which means they cannot be changed after creation. Every time the program uses += to add text, 
// a new string object is created in memory, and the old content is copied to it.
// When this happens thousands of times in a loop, it consumes more memory and slows down performance, making the program less efficient.

// Using StringBuilder instead
// A better solution is to use StringBuilder, which is designed for situations where a string is modified many times. 
// Instead of creating a new object each time, 
// it modifies the same memory buffer, making the process much faster and more memory-efficient.
// using System.Text;

// StringBuilder productList = new StringBuilder();

// for (int i = 1; i <= 5000; i++)
// {
//     productList.Append("PROD-" + i + ",");
// }

// string result = productList.ToString();

// Measuring performance with Stopwatch
// To compare the performance between the normal string method and StringBuilder, 
// we can use Stopwatch. It measures the execution time of each method so we can see which one is faster. 
// Usually, the result shows that StringBuilder performs significantly faster when many string operations are required.
#endregion
#region Q2
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter age: ");
//         int age = int.Parse(Console.ReadLine());

//         Console.Write("Enter day of week (1-7): ");
//         int day = int.Parse(Console.ReadLine());

//         Console.Write("Student ID? (yes/no): ");
//         string student = Console.ReadLine();

//         double price = 0;
//         if (age < 5)
//             price = 0;
//         else if (age <= 12)
//             price = 30;
//         else if (age <= 59)
//             price = 50;
//         else
//             price = 25;

//       if ((day == 6 || day == 7) && price > 0)
//             price += 10;

//         if (student.ToLower() == "yes" && price > 0)
//             price *= 0.8;

//         Console.WriteLine("Final Price: " + price + " LE");
//     }
// }
#endregion
#region Q3
// (a) Traditional switch statement
// string fileExtension = ".pdf";
// string fileType;

// switch (fileExtension)
// {
//     case ".pdf":
//         fileType = "PDF Document";
//         break;

//     case ".doc":
//     case ".docx":
//         fileType = "Word Document";
//         break;

//     case ".xls":
//     case ".xlsx":
//         fileType = "Excel Spreadsheet";
//         break;

//     case ".jpg":
//     case ".png":
//     case ".gif":
//         fileType = "Image File";
//         break;

//     default:
//         fileType = "Unknown File Type";
//         break;
// }
// (b) Switch expression
// string fileExtension = ".pdf";

// string fileType = fileExtension switch
// {
//     ".pdf" => "PDF Document",

//     ".doc" or ".docx" => "Word Document",

//     ".xls" or ".xlsx" => "Excel Spreadsheet",

//     ".jpg" or ".png" or ".gif" => "Image File",

//     _ => "Unknown File Type"
// };
#endregion
#region Q4
// int temperature = 35;

// string weatherAdvice =
//     temperature < 0 ? "Freezing! Stay indoors." :
//     temperature < 15 ? "Cold. Wear a jacket." :
//     temperature < 25 ? "Pleasant weather." :
//     temperature < 35 ? "Warm. Stay hydrated." :
//     "Hot! Avoid sun exposure.";
// Is the ternary version more readable?
// No, usually if/else is clearer when there are many or complex conditions.

// When would you choose one over the other?
// Use the ternary operator (?:) when the condition is simple and short.
// Use if/else when the conditions are many or complex, because it is easier to read and maintain.

#endregion
#region Q5
// using System;

// class Program
// {
//     static void Main()
//     {
//         int attempts = 0;
//         bool valid;

//         do
//         {
//             Console.Write("Enter password: ");
//             string password = Console.ReadLine();

//             bool hasUpper = false;
//             bool hasDigit = false;
//             bool hasSpace = false;

//             foreach (char c in password)
//             {
//                 if (char.IsUpper(c))
//                     hasUpper = true;

//                 if (char.IsDigit(c))
//                     hasDigit = true;

//                 if (char.IsWhiteSpace(c))
//                     hasSpace = true;
//             }

//             valid = password.Length >= 8 && hasUpper && hasDigit && !hasSpace;

//             if (!valid)
//             {
//                 Console.WriteLine("Invalid password:");

//                 if (password.Length < 8)
//                     Console.WriteLine("- Must be at least 8 characters");

//                 if (!hasUpper)
//                     Console.WriteLine("- Must contain an uppercase letter");

//                 if (!hasDigit)
//                     Console.WriteLine("- Must contain a digit");

//                 if (hasSpace)
//                     Console.WriteLine("- No spaces allowed");

//                 attempts++;

//                 if (attempts == 5)
//                 {
//                     Console.WriteLine("Account locked");
//                     return;
//                 }
//             }

//         } while (!valid);

//         Console.WriteLine("Password accepted!");
//     }
// }
#endregion
