namespace _1_POO_Les_constructeurs;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the height of the building in meters: ");
        double height = double.Parse(Console.ReadLine());

        Building building = new Building(height);
        Console.WriteLine($"There will be {building.GetFloorCount()} floors of {building.GetFloorMaxSize()} meters");
    }
}
