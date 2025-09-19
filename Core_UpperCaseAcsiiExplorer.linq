<Query Kind="Program">
  <Output>DataGrids</Output>
  <AutoDumpHeading>true</AutoDumpHeading>
</Query>

void Main()
{
    var uppercaseLetters = Enumerable.Range(65, 26)
        .Select(i => new AsciiChar(i));

    uppercaseLetters.Dump("Uppercase Letters: A to Z");
}

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
