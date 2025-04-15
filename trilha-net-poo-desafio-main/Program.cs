using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Não é possível instanciar Smartphone diretamente devido a ser abstrata
        // Smartphone meuSmart = new Smartphone("123456", "Genérico", "1111222233334444", 128);

        Nokia meuNokia = new Nokia("987654", "Tijolão", "5555666677778888", 64);
        Iphone meuIphone = new Iphone("112233", "X", "9999000011112222", 256);

        Console.WriteLine("Nokia:");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine();

        Console.WriteLine("iPhone:");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("Instagram");
        Console.WriteLine();
    }
}