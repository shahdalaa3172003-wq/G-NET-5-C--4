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
Traditional switch statement
A switch statement is used to select one case from multiple possible 
values instead of using many if-else conditions. It checks the value of a variable and executes the matching case.
string fileExtension = ".pdf";
string fileType;
switch (fileExtension)
{
    case ".pdf":
        fileType = "PDF Document";
        break;

    case ".doc":
    case ".docx":
        fileType = "Word Document";
        break;

    case ".xls":
    case ".xlsx":
        fileType = "Excel Spreadsheet";
        break;

    case ".jpg":
    case ".png":
    case ".gif":
        fileType = "Image File";
        break;

    default:
        fileType = "Unknown File Type";
        break;
}

Switch Expression
A switch expression is a modern and shorter way to write the same logic. It returns a value directly without writing many break statements.
  string fileType = fileExtension switch
{
    ".pdf" => "PDF Document",
    ".doc" or ".docx" => "Word Document",
    ".xls" or ".xlsx" => "Excel Spreadsheet",
    ".jpg" or ".png" or ".gif" => "Image File",
    _ => "Unknown File Type"
};
#endregion
