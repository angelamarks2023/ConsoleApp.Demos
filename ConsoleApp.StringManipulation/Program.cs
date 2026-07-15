// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** - String manipulation - *****");

// Initialize with a regular string literal.
string s1 = "This is a literal string";
String s2 = "This is a literal string";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");

// Declare without initializing. (possible null exception).
string s3;
//Console.WriteLine($"{nameof(s3)}: {s3}); // syntax error. s3 needs a value before it can be used

// Initilize to null. (possible null exception)
string? s4 = null;
Console.WriteLine($"{nameof(s4)}: {s4}");

// Initialize as an empty string.
string s5 = string.Empty; // ""
string s6 = "";
Console.WriteLine($"{nameof(s5)}: {s5}");
Console.WriteLine($"{nameof(s6)}: {s6}");

// Escape sequences and characters.
// She said, "I have your phone".
string sentence = "She said, \"I have your phone\" \r\n This is the next line";
Console.WriteLine($"{nameof(sentence)}: {sentence}");

// Verbatim string literal.
string oldPath = "C:\\program files\\programforlder\\";
string newPath = @"C:\program files\programforlder\";
Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");

// Use a const string to prevent modification to a string.
const string path = "C:\\program files\\programforlder\\";
// path = "new value"; Illegal operation against a constant.
s1 = "A new string";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(path)}: {path}");

// Raw string literals.
string rawLiteral = """ She said, "I have your phone" """;
string rawLiteral1 = """
        She said, "I have your phone" 
        This is the next line
        And another one
        Path = "C:\program files\programforlder\"
        """;
Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)}: {rawLiteral1}");

// Review concatenation and interpolation.
s1 = s1 + s2;
s1 += s2;
Console.WriteLine($"{ nameof(s1)}: {s1}");

string newString = $"{s1} {s2} Some random literal text";
string newString1 = s1 + $"{s1} {s2} Some random literal text";
string newString2 = String.Format("Literal string {0} {1}", s1, s2);
Console.WriteLine($"{ nameof(newString)}: { newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");

/* String manipulation methods and properties. Sometimes it just assesment */

// Null or empty checks
// find the length of a string

Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
//Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}"); // will cause null
Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");

//if(string.IsNullOrEmpty(s4) == false)
if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}

if(string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has length of {s5.Length}");
}

// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)}: {subString}");
subString = newString1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)}: {subString}");

// Splitting strings
var splitStrings = s2.Split(' ');
for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine(splitStrings[i]);
}

// Replace
string replacements1 = s1.Replace('s', 'v');
Console.WriteLine($"{nameof(replacements1)}: {replacements1}");

string replacements2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacements2)}: {replacements2}");

// Convert to string
string salary = 4789654123.02.ToString();
int value = 74185296;
string strValue = value.ToString();

// Changing Formatting
Console.WriteLine($"{nameof(salary)}: {salary:C}");
Console.WriteLine(nameof(salary) + ": " + value.ToString("C"));




