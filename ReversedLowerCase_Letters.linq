<Query Kind="Program" />

void Main()
{
    var input = "abcdefghijk675lmnopz";
    var reversed = AsciiStringReversal.ReverseLowercaseAscii(input);

    input.Dump("Original Input");
    reversed.Dump("Reversed Lowercase Letters with Test harness (ASCII)");
}


public static class AsciiStringReversalReve
{
    public static string ReverseLowercaseAscii(string input)
    {
        var stack = new Stack<char>();

        // Push lowercase letters (ASCII range: 97–122)
        foreach (char c in input)
        {
            if (c >= 'a' && c <= 'z')
                stack.Push(c);
        }

        // Rebuild string with reversed lowercase letters
        var result = new StringBuilder();
        foreach (char c in input)
        {
            if (c >= 'a' && c <= 'z')
                result.Append(stack.Pop());
            else
                result.Append(c);
        }

        return result.ToString();
    }
}
