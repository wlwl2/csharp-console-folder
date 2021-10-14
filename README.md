# Basic C# Console App (In Folder)

Basic C# Console App in a folder template.

A sample project called "HelloWorld", and a sample class called "MyClass.cs" have already been created with the instructions below.

You can delete the "HelloWorld" folder and create new projects with this template.

.gitignore file deals with VS Code and Visual Studio.

## Getting Started

**You cannot run the sample project if you open VS Code in the folder/directory this README.md file is in.**
To test out the sample project, **open the "HelloWorld" project folder provided- with VS Code.**

## New projects

1. **Create a folder for the new project**.

2. **In that folder** run `dotnet new console` in the VS Code Integrated Terminal.

3. For .NET Core 1.x, type `dotnet restore`. Starting with .NET Core 2.0 SDK, you don't have to run `dotnet restore`. It's still a valid command in certain scenarios where doing an explicit restore makes sense, such as continuous integration builds in Azure DevOps Services or in build systems that need to explicitly control the time at which the restore occurs.

4. To run the program run `dotnet run` in the folder.

Source: https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code

## Adding a class

1. Add a new .cs file in the same folder as the project created in "New projects".

2. Include the correct namespace so you can reference it from your Program.cs

```cs

// MyClass.cs

using System;

namespace YourProjectName 
{
    public class MyClass 
    {
        public string ReturnMessage() 
        {
            return "Happy coding!";
        }
    }
}
```

```cs

// Program.cs

using System;

namespace HelloWorld 
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"Hello World! {myClass.ReturnMessage()}");
        }
    }
}

```

## Commands

- `dotnet new`
- `dotnet build`
- `dotnet run`

Source: https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22


