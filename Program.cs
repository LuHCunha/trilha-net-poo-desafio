using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1111111", Modelo: "Modelo 1", Imei: "1111111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "4567892", Modelo: "Iphone 15", Imei: "17183373b1", Memoria: 129);
iphone.Ligar();
iphone.InstalarAplicativo("Kindle");