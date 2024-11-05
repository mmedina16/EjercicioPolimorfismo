public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra: ¡Guau!");
    }

    public override void Moverse()
    {
        Console.WriteLine("El perro corre.");
    }
}