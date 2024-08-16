


using System;

class Program
{
    static void Main()
    {
        // 1. Adım: 10 adet tam sayı verisi alacak bir dizi tanımlanır.
        int[] numbers = new int[10];

        // 2. Adım: Diziyi bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
        Console.WriteLine("Lütfen 10 adet tam sayı girin:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDizi elemanları (foreach döngüsü ile):");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // 3. Adım: Kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        Console.Write("\nLütfen yeni bir tam sayı girin (11. eleman): ");
        int newNumber = int.Parse(Console.ReadLine());

        // Dizi boyutunu 11'e çıkarmak için yeni bir dizi oluşturulur ve eski dizinin elemanları yeni diziye kopyalanır
        int[] newNumbers = new int[numbers.Length + 1];
        for (int i = 0; i < numbers.Length; i++)
        {
            newNumbers[i] = numbers[i];
        }
        newNumbers[newNumbers.Length - 1] = newNumber;

        // 4. Adım: Diziyi büyükten küçüğe sıralayıp ekrana yazdırınız.
        Array.Sort(newNumbers); // Önce artan sıralama yapar
        Array.Reverse(newNumbers); // Büyükten küçüğe sıralama için ters çevirir

        Console.WriteLine("\nDizi elemanları büyükten küçüğe sıralanmış olarak:");
        foreach (int number in newNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
