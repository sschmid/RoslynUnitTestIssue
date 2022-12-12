using System;
using MyAttributes;

namespace MyClasslib
{
    [Obsolete("My Reason"), MyTest("My Test")]
    public class MyClass
    {
    }
}
