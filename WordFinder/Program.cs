// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
string col = "cwindtabscwind";
Console.WriteLine(Regex.Matches(col, "cwind").Count);

Dictionary<string, int> wordsRepeated = new Dictionary<string, int>
    {
        {"testes", 2 }, {"test", 4 }, {"sdsdf", 5 }, {"ewew", 7 },
        {"ee323", 5 }, {"sdfsdf",9 }, { "cvxcv", 10 } ,{"asdasd",12 }, {"tesere",12 }};
foreach(var keyValue in wordsRepeated.OrderByDescending(e => e.Value).Select(e => e.Key))
{
    Console.WriteLine(keyValue);
}
