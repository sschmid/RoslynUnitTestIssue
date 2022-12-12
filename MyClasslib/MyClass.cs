using System;
using MyAttributes;

namespace MyClasslib
{
    [Obsolete("My Reason"), MyClass("My Class"), MyTest("My Test")]
    public class MyClass
    {
    }
}
