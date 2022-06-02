
Dictionary<string, int> adYas = new Dictionary<string, int>();
adYas.Add("Ali", 22);
adYas.Add("veli", 21);
adYas.Add("Hakan", 20);
var eleman = adYas.Count;
foreach (var item in adYas)
{
    Console.WriteLine(item);
}
adYas.Remove("Hakan");
Console.WriteLine(eleman.ToString());

foreach (var item in adYas)
{
    Console.WriteLine(item);
}

var elemans = adYas.Count;
Console.WriteLine(elemans.ToString());

{
    return;
}
