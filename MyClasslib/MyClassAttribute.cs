using System;

namespace MyClasslib
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute
    {
        public readonly string Name;

        public MyClassAttribute(string name)
        {
            Name = name;
        }
    }
}
