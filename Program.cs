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

DateTime dt2 = new DateTime(2002,5,12, 12,30,40);
Console.WriteLine(dt2);                 // -> print default 5/12/2002 12:30:40 PM;
dt2 = dt2.AddDays(10);
Console.WriteLine(dt2);                 // -> print default 5/22/2002 12:30:40 PM;

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

