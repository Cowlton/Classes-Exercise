namespace Classes;

public class CarsYouOwn
{
    public List<Car> Cars { get; set; } = new List<Car>();
    
    public CarsYouOwn()
    {
        
    }
    public CarsYouOwn(List<Car> Cars)
    {
        
    }

    public void WhatCarsDoYouOwn(bool Listing)
    {
        Console.WriteLine("The cars you own are:");
        Console.WriteLine("");
        // list all cars you own

       for (int i = 0; i < Cars.Count; i++)
       {
           if (Cars[i].CarIsListed)
           {
               Console.Write($"Car{i+1}: ");
               if (Listing) {Console.ForegroundColor = ConsoleColor.Red;}
               Console.Write("Listed ");
               Console.ResetColor();
               Console.WriteLine($"{Cars[i].Make} {Cars[i].Model} {Cars[i].Year}");
           }else{
               
               Console.Write($"Car{i+1}: ");
               if (Listing){ Console.ForegroundColor = ConsoleColor.Green;}
               Console.Write("Unlisted ");
               Console.ResetColor();
               Console.WriteLine($"{Cars[i].Make} {Cars[i].Model} {Cars[i].Year}");
           }
       }
    }

    public void WhatCarsDoYouOwn()
    {
        Console.WriteLine("The cars you own are:");
        Console.WriteLine("");
        // list all cars you own

        for (int i = 0; i < Cars.Count; i++)
        {
            Console.WriteLine($"Car{i+1}: {Cars[i].Make} {Cars[i].Model} {Cars[i].Year}");
        }
        
    }
}