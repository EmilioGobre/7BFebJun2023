using static System.Console;
// variables ...
// Primitive variables
// Primitive variables have a default version .... by default duh ...

#region Default Values
// Index Format
// WriteLine("Default value of int is : {0}", arg0: default(int));
// WriteLine("Default value of float is : {0}", arg0: default(float));
// WriteLine("Default value of decimal is : {0}", arg0: default(decimal));
// WriteLine("Default value of bool is : {0}", arg0: default(bool));
// WriteLine("Default value of char is : {0}", arg0: default(char));
// WriteLine("Default value of string is : {0}", arg0: default(string);
#endregion

#region Min Max values
// format {value, margin : format }
// WriteLine("Min value of int is : {0} \n Max value of int is : {1}", arg0: int.MinValue, arg1: int.MaxValue);
// WriteLine("Min value of Uint is : {0} \n Max value of Uint is : {1}", arg0: uint.MinValue, arg1: uint.MaxValue);
// WriteLine("Min value of decimal is : {0} \n Max value of decimal is : {1}", arg0: decimal.MinValue, arg1: decimal.MaxValue);
// WriteLine("Min value of float is : {0:N0} \n Max value of float is : {1:N0}", arg0: float.MinValue, arg1: float.MaxValue);
// WriteLine("Min value of double is : {0:N0} \n Max value of double is : {1:N0}", arg0: double.MinValue, arg1: double.MaxValue);
// WriteLine("Min value of long is : {0} \n Max value of long is : {1}", arg0: long.MinValue, arg1: long.MaxValue);
#endregion

#region Primitive Variables
// decimal number1 = 10.2M;
// decimal number6 = .3M;
// float number2 = 1.2F;
// float number5 = .7F;
// double number4 = 12;
// int number3 = 1;
// char digit = '!';
#endregion

// Complex variables
// string firstName = "Ramon";

#region Interpolation format and margin
// Interpolation format
// WriteLine($"Number 1 is {number1}");
// WriteLine($"Number 2 is {number2}");
// WriteLine($"Number 3 is {number3}");
// WriteLine($"Number 4 is {number4}");
// WriteLine($"Digit is {digit}");
// WriteLine($"Me llamo {firstName}");

// WriteLine($"{(number2 + number5),8} And theres something else ... look {firstName}");
// WriteLine($"{(number1 + number6),-20}Volteo a la derehca y uuuy ya te vi ... {number3}");    
#endregion

string Fruit = "Fruit";
string No = "No";
string Apples = "Apples";
int NumberOfApples = 13;
WriteLine($"{Fruit,-20}{No,20}");
WriteLine($"{Apples,-20}{NumberOfApples,20}");
WriteLine("{0,-20}{1,20}", arg0: "Bananas", arg1: "130");
WriteLine("{0,-20}{1,20}", arg0: "Avocados", arg1: "1000");