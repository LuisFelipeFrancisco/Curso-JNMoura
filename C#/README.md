# C# Programming Basics

--------

### Hello.cs
```cs
class Hello {
  // main method
  static void Main(string[] args)
  {
    // Output: Hello, world!
    Console.WriteLine("Hello, world!");
  }
}
```
Compiling and running (make sure you are in the project directory)
```shell script
$ dotnet run
Hello, world!
```


### Variables
```cs
int intNum = 9;
long longNum = 9999999;
float floatNum = 9.99F;
double doubleNum = 99.999;
decimal decimalNum = 99.9999M;
char letter = 'D';
bool @bool = true;
string site = "quickref.me";

var num = 999;
var str = "999";
var bo = false;
```


### Primitive Data Types 
| Data Type | Size             | Range                   |
| --------- | ---------------- | ----------------------- |
| `int`     | 4 bytes          | -2^31^ ^to^ 2^31^-1     |
| `long`    | 8 bytes          | -2^63^ ^to^ 2^63^-1     |
| `float`   | 4 bytes          | 6 ^to^ 7 decimal digits   |
| `double`  | 8 bytes          | 15 decimal digits       |
| `decimal` | 16 bytes         | 28 ^to^ 29 decimal digits |
| `char`    | 2 bytes          | 0 ^to^ 65535            |
| `bool`    | 1 bit            | true / false            |
| `string`  | 2 bytes per char | _N/A_                   |



### Comments
```cs
// Single-line comment

/* Multi-line 
   comment */

// TODO: Adds comment to a task list in Visual Studio

/// Single-line comment used for documentation

/** Multi-line comment 
    used for documentation **/

```


### Strings
```cs
string first = "John";
string last = "Doe";

// string concatenation
string name = first + " " + last;
Console.WriteLine(name); // => John Doe
```


### User Input
```cs
Console.WriteLine("Enter number:");
if(int.TryParse(Console.ReadLine(),out int input))
{
  // Input validated
  Console.WriteLine($"You entered {input}");
}
```


### Conditionals
```cs
int j = 10;

if (j == 10) {
  Console.WriteLine("I get printed");
} else if (j > 10) {
  Console.WriteLine("I don't");
} else {
  Console.WriteLine("I also don't");
}
```


### Arrays
```cs
char[] chars = new char[10];
chars[0] = 'a';
chars[1] = 'b';

string[] letters = {"A", "B", "C"};
int[] mylist = {100, 200};
bool[] answers = {true, false};
```


### Loops
```cs
int[] numbers = {1, 2, 3, 4, 5};

for(int i = 0; i < numbers.Length; i++) {
  Console.WriteLine(numbers[i]); // => 1 2 3 4 5
}
```
---
```cs
foreach(int num in numbers) {
  Console.WriteLine(num); // => 1 2 3 4 5
}
```

### Switch
```cs
int num = 2;

switch(num) {
  case 1:
    Console.WriteLine("One");
    break;
  case 2:
    Console.WriteLine("Two"); // => Two
    break;
  default:
    Console.WriteLine("None");
    break;
}
```

### While
```cs
int i = 0;
while(i < 10) {
  Console.WriteLine(i); // => 0 1 2 3 4 5 6 7 8 9
  i++;
}
```

### Do While
```cs
int i = 0;
do {
  Console.WriteLine(i); // => 0 1 2 3 4 5 6 7 8 9
  i++;
} while(i < 10); 
```

### Break
```cs
for(int i = 0; i < 10; i++) {
  if(i == 5) {
    break;
  }
  Console.WriteLine(i); // => 0 1 2 3 4
}
```

### Continue
```cs
for(int i = 0; i < 10; i++) {
  if(i == 5) {
    continue;
  }
  Console.WriteLine(i); // => 0 1 2 3 4 6 7 8 9
}
```

C# Strings
----------------

### String concatenation
```cs
string first = "John";
string last = "Doe";

string name = first + " " + last;
Console.WriteLine(name); // => John Doe
```

### String interpolation
```cs
string first = "John";
string last = "Doe";

string name = $"{first} {last}";
Console.WriteLine(name); // => John Doe
```

### String Members
| Member      | Description |
|------------ |-------------|
| Length      | A property that returns the length of the string.         |
| Compare()   | A static method that compares two strings.  |
| Contains()  | Determines if the string contains a specific substring. |
| Equals()    | Determines if the two strings have the same character data. |
| Format()    | Formats a string via the {0} notation and by using other primitives. |
| Trim()      | Removes all instances of specific characters from trailing and leading characters. Defaults to removing leading and trailing spaces. |
| Split()     | Removes the provided character and creates an array out of the remaining characters on either side. |
| IndexOf()   | Returns the index of the first occurrence of the provided character. |
| LastIndexOf() | Returns the index of the last occurrence of the provided character. |
| Replace()   | Replaces all instances of a character with another character. |
| ToLower()   | Converts all characters to lowercase. |
| ToUpper()   | Converts all characters to uppercase. |
| ToString()  | Converts the value of the current instance to its equivalent string representation. |
| Substring() | Returns a substring of the string. |
| Join()      | Concatenates the elements of an object array, using the specified separator between each element. |
| Copy()      | Copies a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters. |
| Insert()    | Inserts a string into this instance at a specified index position. |
| Remove()    | Removes the specified range of characters from this instance. |


### Verbatim strings
```cs {.wrap}
string longString = @"I can type any characters in here !#@$%^&*()__+ '' \n \t except double quotes and I will be taken literally. I even work with multiple lines.";
```


### Member Example
```cs
// Using property of System.String
string lengthOfString = "How long?";
lengthOfString.Length           // => 9

// Using methods of System.String
lengthOfString.Contains("How"); // => true
```