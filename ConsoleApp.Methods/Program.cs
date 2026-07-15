Console.WriteLine("***** - Methods - *****");
// void methods - completes a task without returning a value
void PrintName()
{
    // Method code
    Console.WriteLine("Angela");
 }

// value returning methods = returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}

// methods with parameters - represent data being passed into a method.
void PrintNameWithParams(string name)
{
    // Method code
    Console.WriteLine("Your name is: " + name);
}
int GetYearDifferenceWithParams(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}

// methods with optional parameters - parameter is not required..also has a default value
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// methods with nullable parameters
void PrintNameNullableParam(string? name, int? count = 0)
{
    //if(string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}

    //if(!count.HasValue)
    //{
    //    count = 1;
    //}

    // The null-coalescing assignment operator ??= assigns the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null.
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
    name ??= "Default Name";
    count ??= 1;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
 }

/* Function Calls */
//PrintName();
//int fiveYearsAgo = GetFiveYearsAgo();
//Console.WriteLine("Five Years Ago was: " + fiveYearsAgo);

//Console.WriteLine("Enter your name");
//string name1 = Console.ReadLine();
//PrintNameWithParams(name1);

//Console.WriteLine("Enter a year");
//int pastYear = Convert.ToInt32(Console.ReadLine());
//int yearsAgo = GetYearDifferenceWithParams(2015);
//Console.WriteLine("This was: " + yearsAgo + "year ago");

//Console.WriteLine("Enter number of year in the future or past");
//int numberOfYears = Convert.ToInt32(Console.ReadLine());

//var pastYear1 = GetFutureOrPastYear();
//Console.WriteLine("The year is: " + pastYear1);

//var pastYear2 = GetFutureOrPastYear(numberOfYears);
//Console.WriteLine("The year is: " + pastYear2);

PrintNameNullableParam(null, null);
PrintNameNullableParam("Chester", 5);
