
using System.Runtime.InteropServices;

var Rng = new Random(90500);

var lista = Enumerable.Range(1, 500000000).Select(x => Rng.Next()).ToList();

var agora = DateTime.Now;


Console.WriteLine("Foreach\nInício: " + agora);

foreach (var item in lista)
{

}

Console.WriteLine($"Duração: {DateTime.Now - agora}\n\n");



lista = Enumerable.Range(1, 100000000).Select(x => Rng.Next()).ToList();
agora = DateTime.Now;

Console.WriteLine("CollectionsMarshal\nInício: " + agora);

var asSpan = CollectionsMarshal.AsSpan(lista);

foreach (int item in CollectionsMarshal.AsSpan(lista))
{
    
}

Console.WriteLine($"Duração: {DateTime.Now - agora}\n\n");



