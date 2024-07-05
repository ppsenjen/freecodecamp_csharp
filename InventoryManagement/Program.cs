using InventoryManagement;

//accessing the static method using the class name
Product.ChangeStockThreshold(10);
Product.StockThreshold = 10;

//Price samplePrice = new Price(10, Currency.Euro);
//using object initializers t replace the above code soo a constructor is not needed for price class
Price samplePrice = new Price(){ItemPrice = 10, Currency = Currency.Dollar};

//Product p1 = new Product(1,"Sugar", "Salt",samplePrice,UnitType.PerKg,100);
//using object initializers
Product p1 = new Product(1){Name ="Sugar", Description ="Good for you", Price = samplePrice,UnitType = UnitType.PerKg};
p1.IncreaseStock(10);
p1.Description = "Sample description";

//Product p2 = new Product(2,"Beans", "Flour",samplePrice,UnitType.PerKg,200);
Product p2 = new Product(2){Name ="Beans", Description ="Good for you", Price = new Price(){ItemPrice = 8, Currency = Currency.Euro }, UnitType= UnitType.PerBox};

Product p3 = new Product(3){Name ="Chapati", Description ="Good for you", Price = new Price(){ItemPrice = 8, Currency = Currency.Euro }, UnitType= UnitType.PerBox};