# Roslyn Unit Test Issue

## Setup

- One classlib project `MyClasslib` which contains one class [MyClass.cs](https://github.com/sschmid/RoslynUnitTestIssue/blob/main/MyClasslib/MyClass.cs), which has an attribute `[Obsolete("My Reason")]`
- One console project `MyConsoleApp` which contains [Helper.cs](https://github.com/sschmid/RoslynUnitTestIssue/blob/main/MyConsoleApp/Helper.cs) which uses Roslyn to get the attributes from [MyClass.cs](https://github.com/sschmid/RoslynUnitTestIssue/blob/main/MyClasslib/MyClass.cs) 
- One unit test project `Tests` which also uses [Helper.cs](https://github.com/sschmid/RoslynUnitTestIssue/blob/main/MyConsoleApp/Helper.cs), but prints a different result which is unexpected!

## Issue

Using Roslyn to get the attributes of [MyClass.cs](https://github.com/sschmid/RoslynUnitTestIssue/blob/main/MyClasslib/MyClass.cs) works as expected, but the same code fails whe running it in a unit test.

### Expected output:
`System.ObsoleteAttribute("My Reason")`

### Unit test output:
`Obsolete`

Why? Please help!

See https://github.com/sschmid/RoslynUnitTestIssue/issues/1
