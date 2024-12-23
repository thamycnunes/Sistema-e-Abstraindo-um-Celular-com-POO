using SistemaCelulares.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456", "Nokia 3310", "001", 64);
        Iphone iphone = new Iphone("987654", "iPhone 13", "002", 128);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("Fim do programa.");
    }
}
