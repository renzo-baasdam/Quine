using FluentAssertions;
using NUnit.Framework;
using System.IO;

namespace Quine;

public class ProgramCs
{
    [Test]
    public void Replicates_itself()
    {
        // Arrange 
        /// Program.cs
        string fileContents = File.ReadAllText("../../../Program.cs");
        /// Capture console output
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        /// Run Program.cs
        var entryPoint = typeof(Program).Assembly.EntryPoint!;
        entryPoint.Invoke(null, [Array.Empty<string>()]);

        // Assert
        consoleOutput.ToString().Should().Be(fileContents);
    }
}