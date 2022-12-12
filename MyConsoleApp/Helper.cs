using System.IO;
using System.Linq;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace MyConsoleApp;

public static class Helper
{
    private static readonly string MyProjectPath = Path.Combine(
        Directory.GetCurrentDirectory(),
        "..", "..", "..", "..", "MyClasslib", "MyClasslib.csproj"
    );

    public static AttributeData[] GetAttributes()
    {
        if (!MSBuildLocator.IsRegistered) MSBuildLocator.RegisterDefaults();
        using var workspace = MSBuildWorkspace.Create();

        var symbols = workspace
            .OpenProjectAsync(MyProjectPath).Result
            .GetCompilationAsync().Result
            .GetSymbolsWithName(name => true, SymbolFilter.Type)
            .OfType<INamedTypeSymbol>();

        var symbol = symbols.Single(c => c.ToDisplayString() == "MyClasslib.MyClass");

        return symbol
            .GetAttributes()
            .ToArray();
    }
}
