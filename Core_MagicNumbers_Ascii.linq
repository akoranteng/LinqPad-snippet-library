<Query Kind="Expression" />

// Title: Magic Numbers and ASCII Explorer
// Category: Core Utilities
// Description: Demonstrates method encapsulation, ASCII character mapping, and reusable class structure in LINQPad.
// Author: Alex
// Date: 2025-09-16

void Main()
{
    // Basic method call with arithmetic
    var result = GetMagicNumber() + 200;
    result.Dump("Magic Number Result");

    // ASCII character listing using a custom class
    var asciiLetters = Enumerable.Range(65, 26).Select(i => new AsciiChar(i));
    asciiLetters.Dump("Uppercase ASCII Letters");

    // Custom class usage for modular logic
    var calc = new MagicCalculator();
    calc.GetMagicNumber().Dump("MagicCalculator Output");
}

// Simple method returning a constant
public int GetMagicNumber()
{
    return 42;
}

// Custom class for extensibility
public class MagicCalculator
{
    public int GetMagicNumber() => 42;
}

// ASCII wrapper class for structured output
public class AsciiChar
{
    public int Code { get; set; }
    public char Character => (char)Code;

    public AsciiChar(int code)
    {
        Code = code;
    }

    public override string ToString() => $"{Code} => {Character}";
}
