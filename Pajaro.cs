public class Pajaro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El pájaro canta: ¡Pío pío!");
    }

    public override void Moverse()
    {
        Console.WriteLine("El pájaro vuela.");
    }
}