class Program
{
    static void Main(string[] args)
    {
        List<Animal> animales = new List<Animal>
        {
            new Perro(),
            new Gato(),
            new Pajaro()
        };

        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
            animal.Moverse();
            Console.WriteLine();
        }
    }
}