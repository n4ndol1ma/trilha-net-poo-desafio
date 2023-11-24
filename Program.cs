using System.Net;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1234567", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "678910", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");