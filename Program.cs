using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("NOKIA");
Nokia nokia = new Nokia("123456", "modelo 1", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("--");

Console.WriteLine("iphone");
Iphone iphone = new Iphone("123456", "modelo 1", "1111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
