using System;

namespace MyAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyTestAttribute : Attribute
    {
        public readonly string Name;

        public MyTestAttribute(string name)
        {
            Name = name;
        }
    }
}
