// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<String> inköpslista = new List<String>();

inköpslista.Add("mjölk");
inköpslista.Add("fil");
inköpslista.Add("ost");
inköpslista.Add("bröd");

// skriv ut inköpslista
foreach (String vara in inköpslista)
{
    Console.WriteLine(vara);
}


