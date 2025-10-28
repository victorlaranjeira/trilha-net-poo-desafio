using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "234r", imei: "5624556", memoria: 120);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "56398", modelo: "11", imei: "63987", memoria: 260);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");