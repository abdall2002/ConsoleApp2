// See https://aka.ms/new-console-template for more information

using NestedType;
using System;



var p = new Person();



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

