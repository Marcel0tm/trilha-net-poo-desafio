using DesafioPOO.Models;

Console.WriteLine("\n");

Nokia nokia = new Nokia("123","Nokia Tijolão", "733849", 1024);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Memes do Facebook");

Console.WriteLine("\n");

Iphone iphone = new Iphone("763920", "iPhone 20 Pro Ultra Max Plus", "10203040", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Rotas Malucas do Waze");
