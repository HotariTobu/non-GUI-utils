int length = args.Length;
var random = new Random();
for (int i = 0; i < 10000; i++)
{
    int from = random.Next(0, length);
    int to = random.Next(0, length);
    (args[from], args[to]) = (args[to], args[from]);
}
Console.WriteLine(String.Join(" ", args));