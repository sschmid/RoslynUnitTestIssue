using System;
using MyConsoleApp;
using NSpec;

namespace NspecTests
{
    public class Tests : nspec
    {
        void when_testing()
        {
            it["prints all attributes"] = () =>
            {
                foreach (var attribute in Helper.GetAttributes())
                    Console.WriteLine(attribute.ToString());
            };
        }
    }
}
