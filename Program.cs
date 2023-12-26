using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("987654321","modelo 1","1111111111",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone:");
Smartphone iphone = new Iphone("912345678","modelo 2","2222222222",64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");