//int first = 2;
//string second = "4";
//string result = first + second;
//Console.WriteLine(result + "\n");

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}" + "\n");

//decimal myDecimal = 3.14m;
//Console.WriteLine($"decimal: {myDecimal}");
//int myInt = (int)myDecimal;
//Console.WriteLine($"int: {myInt}" + "\n");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}" + "\n");

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message + "\n");

int value = (int)1.5m; 
Console.WriteLine(value);
int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);