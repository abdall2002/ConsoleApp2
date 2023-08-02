// See https://aka.ms/new-console-template for more information

using NestedType;
using System;


//Student st;
//st.Show();

Digitalize size = new Digitalize(60000);

Console.WriteLine(size.Bit);          // -> print 60,000 Bit;
Console.WriteLine(size.Byte);         // -> print 7,500  Bit;
Console.WriteLine(size.KB);           // -> print 7     Bit;
Console.WriteLine(size.MB);           // -> print 0     Bit;
Console.WriteLine(size.GB);           // -> print 0     Bit;
Console.WriteLine(size.TB);           // -> print 0     Bit;





class A
{
    private int x;
    class B                     // -. Nested Class;
    {
        void s()
        {
            A a = new A();     
            a.x = 1;           // -> Can Access private member;
        }
    }
}

