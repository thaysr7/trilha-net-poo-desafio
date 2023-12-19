using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(numero: "999999999", modelo: "Nokia G21", imei: "1234", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "Facebook");

Iphone iphone = new Iphone(numero: "988888888", modelo: "Iphone 12", imei: "5678", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "Instagram");