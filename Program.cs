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

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;
// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}" + "\n");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message + "\n");

// string first1 = "5";
// string second1 = "7";
// int sum = int.Parse(first1) + int.Parse(second1);
// Console.WriteLine(sum + "\n");

// string value = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value) * Convert.ToInt32(value2);
// Console.WriteLine(result + "\n");

// int value3 = (int)1.5m; 
// Console.WriteLine(value3);
// int value4 = Convert.ToInt32(1.5m); 
// Console.WriteLine(value4 + "\n");

// string value5 = "bad";
// int result1 = 0;
// if (int.TryParse(value5, out result)) {
// Console.WriteLine($"Measurement: {result1}");
// } else {
// Console.WriteLine("Unable to report the measurement." + "\n");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}" + "\n");

 string[] values = { "12.3", "45", "ABC", "11", "DEF" };
 string message = "";
 double total = 0;

 foreach (string value in values) {
 if (double.TryParse(value, out double numericValue)) {
 total += numericValue;
 } else {
 message += value;
   }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");