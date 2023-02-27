using z5;

class Program
{
    static void Main()
    {
        
        Store groshik = new Store();
        Product milk = new Product("Молоко", "Грошик", 2.08);
        Product bread = new Product("Хлеб купаловский", "Грошик", 0.49);
        Product candy = new Product("Конфеты бешенные пчёлки", "Грошик", 3.28);
        Product[] products = new Product[3];
        products[0] = milk;
        products[1] = bread;
        products[2] = candy ;
        groshik.setTmp(products);
        groshik.printInformation();
        
      
        

    }

}