using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia01 = new Nokia(numero: "412", modelo: "Modelo 1", imei: "00000001", memoria: 512);
nokia01.Ligar();
nokia01.InstalarAplicativo("Instagram");
nokia01.ReceberLigacao();

Console.WriteLine("\n");

Nokia nokia02 = new Nokia(numero: "5242", modelo: "Modelo 80", imei: "04234001", memoria: 256);
nokia02.ReceberLigacao();
nokia02.InstalarAplicativo("Facebook");
nokia02.Ligar();

Console.WriteLine("\n");

Iphone iphone01 = new Iphone(numero: "123", modelo: "Modelo 13", imei: "00000013", memoria: 1024);
iphone01.ReceberLigacao();
iphone01.InstalarAplicativo("Twitter");
iphone01.Ligar();

Console.WriteLine("\n");

Iphone iphone02 = new Iphone(numero: "987", modelo: "Modelo 21", imei: "00000021", memoria: 128);
iphone02.Ligar();
iphone02.InstalarAplicativo("Reddit");
iphone02.ReceberLigacao();

