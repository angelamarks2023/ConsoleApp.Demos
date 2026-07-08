// See https://aka.ms/new-console-template for more information

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
    Math operations and operators
*/

// Add numbers
int sum = num1 + num2;
// mutiply
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// Subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("********* Math Results *********");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("********** End Math Results **********");

/*
    Logic Operations and Operators
*/

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("********* Logic Results *********");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"IsEqualTo: {isEqualTo}");
Console.WriteLine($"Is Greater Than or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal To: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("********* End Logic Results *********");

/*
    Assignment Operations and Operators
 */
Console.WriteLine("Enter Random Value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
//int increasedValue = num1 + randomValue;

Console.WriteLine("********* Assignment Results *********");
Console.WriteLine();
//num1 = num1 + randomValue;
num1 += randomValue;
Console.WriteLine($"Num1 increased by {randomValue}: {num1}");
//num1 = num1 - randomValue;
num1 -= randomValue;
Console.WriteLine($"Num1 reduced by {randomValue}: {num1}");
// num1 * randomValue;
num1 *= randomValue;
Console.WriteLine($"Num1 multiplied by {randomValue}: {num1}");
// num1 / randomValue;
num1 /= randomValue;
Console.WriteLine($"Num1 devided by {randomValue}: {num1}");
// num1 % randomValue;
num1 %= randomValue;
Console.WriteLine($"Numone mod by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("********* End Assignment Results *********");