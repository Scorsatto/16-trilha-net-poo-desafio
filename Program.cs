using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "66 99999-9999", modelo: "2280", imei: "6548913548", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "66 88888-8888", modelo: "iPhone 4", imei: "9816548756", memoria: 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Tinder");