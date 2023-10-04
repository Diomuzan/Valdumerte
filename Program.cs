// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result + "\n");

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}" + "\n");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");
// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}" + "\n");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}" + "\n");

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message + "\n");

string first1 = "5";
string second1 = "7";
int sum = int.Parse(first1) + int.Parse(second1);
Console.WriteLine(sum + "\n");

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result + "\n");

int value3 = (int)1.5m; 
Console.WriteLine(value3);
int value4 = Convert.ToInt32(1.5m); 
Console.WriteLine(value4 + "\n");

string value = "bad";
int result1 = 0;
if (int.TryParse(value, out result)) {
    Console.WriteLine($"Measurement: {result}");
} else {
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };


