namespace Classes;

public class CarsForSail
{
    public List<Car> CarsListed { get; set; } = new List<Car>();
    public CarsForSail()
    {
        
    }
    public CarsForSail(List<Car> carsListed)
    {
        this.CarsListed = carsListed;
    }
    public void WhatCarsAreUpForSail()
    {
        if (CarsListed.Count == 1)
        {
            Console.WriteLine("The only car you have up for sail is:");
            Console.WriteLine($"Car1: {CarsListed[0].Make} {CarsListed[0].Model} {CarsListed[0].Year}");
        }else if (CarsListed.Count > 1)
        {
            Console.WriteLine("The cars you have up for sail are:");
            for (int i = 0; i < CarsListed.Count; i++)
            {
                Console.WriteLine($"Car{i+1}: {CarsListed[i].Make} {CarsListed[i].Model} {CarsListed[i].Year}");
            }
        }else {
            Console.WriteLine("You have no cars up for sail.");
        }
        
    }
}