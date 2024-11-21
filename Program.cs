using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Luminia", imei: "11111111111", memoria: 28);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "7891011", modelo: "14 Pro Max", imei: "22222222", memoria: 240);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone