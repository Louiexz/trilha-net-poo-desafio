using DesafioPOO.Models;

Nokia cellNokia = new Nokia(numero: "1", modelo: "1", imei: "123", memoria: 1);
Iphone cellIphone = new Iphone(numero: "2", modelo: "SE", imei: "321", memoria: 2);

Console.Clear();

cellNokia.Ligar();
cellNokia.ReceberLigacao();
cellNokia.InstalarAplicativo("Angry Birds");
Console.Write(cellNokia.ToString());

Console.WriteLine("\n");

cellIphone.Ligar();
cellIphone.ReceberLigacao();
cellIphone.InstalarAplicativo("Duolingo");
Console.WriteLine(cellIphone.ToString());