Retangulo re1 = new Retangulo();
Retangulo re2 = new Retangulo(5);
Retangulo re3 = new Retangulo(4,6);
System.Console.WriteLine($"Retângulo 1 Area{re1.CalcularArea()} e Perimetro {re1.CalcularPerimetro}");
System.Console.WriteLine($"Retângulo 2 Area{re2.CalcularArea()} e Perimetro {re2.CalcularPerimetro}");
System.Console.WriteLine($"Retângulo 3 Area{re3.CalcularArea()} e Perimetro {re3.CalcularPerimetro}");

re3.Redimensionar(2);
System.Console.WriteLine($"Retângulo 3 Area redimencionada {re3.CalcularArea()} e Perimetro: {re3.CalcularPerimetro()}");

re2.Redimensionar(10,15);
System.Console.WriteLine($"Retângulo 3 Area redimencionada {re2.CalcularArea()} e Perimetro: {re2.CalcularPerimetro()}");