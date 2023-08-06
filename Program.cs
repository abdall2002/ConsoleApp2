// See https://aka.ms/new-console-template for more information

using NestedType;
using System;


//Student st;
//st.Show();

//Digitalize size = new Digitalize(60000);

//size= size.AddBit(8);   // -> print  8 - 1 - 0 - 0 - 0 - 0; 

//Digitalize size2 = size.AddBit(8);

//Console.WriteLine(size.Bit);          // -> print 60,000 Bit;
//Console.WriteLine(size.Byte);         // -> print 7,500  Bit;
//Console.WriteLine(size.KB);           // -> print 7      Bit;
//Console.WriteLine(size.MB);           // -> print 0      Bit;
//Console.WriteLine(size.GB);           // -> print 0      Bit;
//Console.WriteLine(size.TB);           // -> print 0      Bit;

//Console.WriteLine("--------------------------------------------");

//Console.WriteLine(size2.Bit);          // -> print 8  Bit;
//Console.WriteLine(size2.Byte);         // -> print 1  Bit;
//Console.WriteLine(size2.KB);           // -> print 0  Bit;
//Console.WriteLine(size2.MB);           // -> print 0  Bit;
//Console.WriteLine(size2.GB);           // -> print 0  Bit;
//Console.WriteLine(size2.TB);           // -> print 0  Bit;

//////////////////////////////////////////////////////////////////

//DateTime dt = new DateTime();
//Console.WriteLine(dt);                 // -> print default 1/1/0001 12:00:00 AM;

//DateTime dt2 = new DateTime(2002,5,12, 12,30,40);      // -> store date and time;
//Console.WriteLine(dt2);                 // -> print default 5/12/2002 12:30:40 PM;
//dt2 = dt2.AddDays(10);
//Console.WriteLine(dt2);                 // -> print default 5/22/2002 12:30:40 PM;

//dt2.AddDays(10);
//Console.WriteLine(dt2);

//class A
//{
//private int x;
//class B                     // -. Nested Class;
//{
//void s()
//{
//    A a = new A();     
//      a.x = 1;           // -> Can Access private member;
//    }
//  }
//}
/////////////////////////////////////////////////////////////

/* Enums */

//Console.WriteLine(Month.Feb);           // -> print Feb;
//Console.WriteLine((int)Month.Feb);      // -> print 1;

//var day = "Feb";
//Console.WriteLine(Enum.Parse(typeof(Month), day)) ;        // -> print Feb;
//Console.WriteLine(Enum.IsDefined(typeof(Month), day)) ;    // -> print True;

//foreach (var month in Enum.GetNames(typeof(Month)))
//{
//  Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month),month)}");
//}
//foreach (var month in Enum.GetValues(typeof(Month)))
//{
//  Console.WriteLine($"{month.ToString()} = {(int)month}");
//}

///////////////////////////////////////////////////////////

/* Inheritance */

//Eagle e = new Eagle();
//e.Move();
//Animal a = e;         // -> point to Eagle; tread with Class Animal only; (Up Casting)
//Eagle e2 = (Eagle)a;  // -> (Down Casting); treat with Move() and Fly();
//Console.WriteLine(e);
//e2.Move();      // -> print "Moving";
//e2.Fly();       // -> print "Flying";
//e.Move();    // -> print Movings, The Eagle;

///////////////////////////////////////////////////////////

/* Constructor and Inheritance */

//Subclass sc = new Subclass(123);
//Console.WriteLine(sc);            // -> print "NestedType.Subclass";
//Console.WriteLine(sc.x);          // -> print 123;






////////////////////////////////////////////////

/* Interface */

//ILoader v3 = new Caterpiller("sad", "adsf", 2000);
//v3.Load();

///////////////////////////////////////////////

/* Generics */
// Generic Method

//print(1);            // -> print System.Int32, 1;
//print("Abdallah");   // -> print System.String, "Abdallah";
//print('A');          // -> print System.Char, 'A';
//void print<T>(T value)
//{
//  Console.WriteLine($"DataType : {typeof(T)}");
//Console.WriteLine($"DataType : {value}");
//}

// Generic class

//var numbers = new Any<int>();
//numbers.Add(1);                
//numbers.Add(2);                
//numbers.Add(3);                
//numbers.DisplayList();              // -> print [1, 2, 3];
//numbers.RemoveAt(0); 
//numbers.DisplayList();              // -> print [2, 3];
//Console.WriteLine($"Length : {numbers.Count} items");             // -> print 2 items;
//Console.WriteLine($"Empty : {numbers.IsEmpty}");                  // -> false;

///////////////////////////////////////////////////////

/* Generic Delegate*/

//IEnumerable<int> list1 = new int[] { 2, 5, 6, 7, 9, 1, 3, 4, 8 };
//Console.WriteLine("Number less than 6");
//PrintNumber(list1,n => n < 6); 
//PrintNumber(list1,n => n < 6, () => Console.WriteLine("Number less than 6"));   // or 

//Console.WriteLine("Number less than 7");
//PrintNumber(list1,n => n < 7, () => Console.WriteLine("Number less than 7"));   // or
//Console.WriteLine("Even Numbers");
//PrintNumber(list1, n => n % 2 == 0, () => Console.WriteLine("Even Numbers"));   // or

//IEnumerable<decimal> list2 = new decimal[] { 2.5m, 5.3m, 6.33m, 7.5m, 9.44m, 1.5m, 3.8m, 4.25m, 8.75m };
//Console.WriteLine("Numbers are Greater than 6.33 ");
//PrintNumber(list2, n => n >= 6.33m, () => Console.WriteLine("Numbers are Greater than 6.33"));    // or 


// delegate in subclass.cs;

//void PrintNumber<T>(IEnumerable<T> numbers, Filter<T> filter)
//or void PrintNumber<T>(IEnumerable<T> numbers, Predicate<T> filter)    // او دي
//or void PrintNumber<T>(IEnumerable<T> numbers, Func<T, bool> filter)   // او دي

//{
//foreach (var n in numbers)
//{
//if(filter(n))
//  {
//Console.WriteLine(n);
//    }
//  }
//}

// Acrion && Func and Predicate;

void Print(string name) => Console.WriteLine(name);
int Add(int n1, int n2) => n1 + n2; 
bool IsEven(int n) => n % 2 == 0;

Action<string> action = Print;        // -> call Method;  
action("Abdallah");                   // -> print "Abdallah"
Func<int, int, int> addd = Add;       // -> 2 firstly input, lastly output;
Console.WriteLine(addd(2,2));         // -> print 4  
Predicate<int> predicate = IsEven;    // -> store 1 parameter only;
Console.WriteLine(predicate(3));      // -> print false;

