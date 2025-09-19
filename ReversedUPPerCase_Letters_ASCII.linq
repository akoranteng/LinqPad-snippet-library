<Query Kind="Program" />

void Main()
{
    var input = "AbCdeFG123hiJK";

    // Show ASCII codes for each character
    var asciiMap = input
        .Select(c => new { Char = c, Code = (int)c })
        .ToList();

    asciiMap.Dump("ASCII Mapping of Input Characters");

    // Apply ASCII-based uppercase reversal
    var reversed = AsciiStringReversal.ReverseUppercaseAscii(input);

    input.Dump("Original Input");
    reversed.Dump("Reversed Uppercase Letters (ASCII)");
}

public static class AsciiStringReversal
{
    public static string ReverseUppercaseAscii(string input)
    {
        var stack = new Stack<char>();

        // Collect uppercase letters using ASCII range
        foreach (char c in input)
        {
            if (c >= 'A' && c <= 'Z')
                stack.Push(c);
        }

        // Rebuild string with reversed uppercase letters
        var result = new StringBuilder();
        foreach (char c in input)
        {
            if (c >= 'A' && c <= 'Z')
                result.Append(stack.Pop());
            else
                result.Append(c);
        }

        return result.ToString();
    }
}
