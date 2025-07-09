using DesafioPOO.Models;
using System;

Console.WriteLine("martphone Nokia");
Nokia nokia = new Nokia("12982827603", " Nokia Noshit", "797946123123","64" );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine($"{nokia.IMEI}, Modelo: {nokia.Modelo}, Memória: {nokia.Memoria}GB");
Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("987654321", "iPhone 15 Pro Max", "999888777666555", "256");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine($"IMEI: {iphone.IMEI}, Modelo: {iphone.Modelo}, Memória: {iphone.Memoria}GB");
Console.WriteLine("\n");



