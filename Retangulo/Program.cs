class Program
{
    static void Main()
    {
        // Criando instâncias usando todos os construtores
        Retangulo retangulo1 = new Retangulo();
        Retangulo retangulo2 = new Retangulo(5);
        Retangulo retangulo3 = new Retangulo(4, 6);

        // Exibindo informações iniciais
        Console.WriteLine("Retângulo 1: Área = {0}, Perímetro = {1}", retangulo1.CalcularArea(), retangulo1.CalcularPerimetro());
        Console.WriteLine("Retângulo 2: Área = {0}, Perímetro = {1}", retangulo2.CalcularArea(), retangulo2.CalcularPerimetro());
        Console.WriteLine("Retângulo 3: Área = {0}, Perímetro = {1}", retangulo3.CalcularArea(), retangulo3.CalcularPerimetro());

        // Testando os métodos de redimensionamento
        retangulo3.Redimensionar(2);
        Console.WriteLine("Retângulo 3 Redimensionado: Área = {0}, Perímetro = {1}", retangulo3.CalcularArea(), retangulo3.CalcularPerimetro());

        retangulo2.Redimensionar(10, 15);
        Console.WriteLine("Retângulo 2 Redimensionado: Área = {0}, Perímetro = {1}", retangulo2.CalcularArea(), retangulo2.CalcularPerimetro());
    }
}

