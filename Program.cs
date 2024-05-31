using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de um objeto Iphone
            Console.WriteLine("SMARTPHONE IPHONE");
            Smartphone iphone = new Iphone("123456789", "iPhone 12", "123456789012345", 128);
            iphone.Ligar();
            iphone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Criação de um objeto Nokia
            Console.WriteLine("SMARTPHONE NOKIA");
            Smartphone nokia = new Nokia("987654321", "Nokia 3310", "543210987654321", 32);
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Telegram");
        }
    }
}
