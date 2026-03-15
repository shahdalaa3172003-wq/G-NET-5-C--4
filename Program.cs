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

