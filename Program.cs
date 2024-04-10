string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");
var result = "";
foreach (var word in words)
{
    result += String.Join("", word.Reverse());
    result += String.Join("", " ");
}

Console.WriteLine(result);