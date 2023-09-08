namespace csharp_oop_shop
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           Prodotto pasta = new Prodotto("Spaghetti", 1.10f, 5);
            Console.Write($"Ti presentiamo il prodotto { pasta.Name }, ");
            Console.Write($"codice prodotto {pasta.Code},");
            Console.Write($"lo puoi trovare solo per questa settimana al magico prezzo di {pasta.GetTaxedPrice()} euro, ");
            Console.WriteLine("");
            Console.Write($"l'iva applicata sul prodotto è del {pasta.Iva}%, ");
            Console.Write($"il prezzo del prodotto senza iva è di {pasta.Price} euro.");
            Console.WriteLine("");
            Console.WriteLine($"Il nome intero del prodotto è  {pasta.GenerateFullName()}");




        }
    }
}