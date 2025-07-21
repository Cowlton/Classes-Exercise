namespace Classes;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public bool CarIsListed { get; set; } = false;
    
    public Car()
    {
        
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        
    }

    public void List()// put a car up for sail
    {
        Console.WriteLine($"Your {Year} {Model} {Make} is up for sail!");
        CarIsListed = true;
        // add your car to cars for sail
    }
    public void Unlist()// remove a car from sail
    {
        Console.WriteLine($"Your {Year} {Model} {Make} is no longer up for sail!");
        CarIsListed = false;
        // remove your car from cars for sail
    }
}