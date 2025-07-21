namespace Classes
{
    public class Program
    {
        
        public static CarsForSail CarsForSail = new CarsForSail();
        static CarsYouOwn carsYouOwn = new CarsYouOwn();
        static Car car1 = new Car("Ford", "Fusion", 2022);
        static Car car2 = new Car("Tesla", "Model 3", 2021);
        static Car car3 = new Car("Handai", "Lion", 2020);
        static Car car4 = new Car("Honda", "Civic", 2019);
        
        static void Main(string[] args)
        {
            carsYouOwn.Cars.Add(car1);
            carsYouOwn.Cars.Add(car2);
            carsYouOwn.Cars.Add(car3);
            carsYouOwn.Cars.Add(car4);
            Console.WriteLine("Welcome to the Car Lister!");
            ChooseAnAction();
            
        }
        
        static void CheckYourCars()
        {
            carsYouOwn.WhatCarsDoYouOwn();
            Console.WriteLine("Would you like to do anything else?");
            if (YesNo())
            {
                ChooseAnAction();
            }
            else
            {
                Console.WriteLine("Alright then.");
                Console.WriteLine("Goodbye.");
            }
            
        }

        static bool YesNo()
        {
            Console.WriteLine("Yes or No?");
            Console.WriteLine("");
            var userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "yes")
            {
                return true;
            }else if (userInput.ToLower() == "no"){
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that.");
                Console.WriteLine("Please try again.");
                Console.WriteLine("");
                return YesNo();
            }
        }

        static void WhatCarsHaveYouListed()
        {
            CarsForSail.WhatCarsAreUpForSail();
            Console.WriteLine("Would you like to do anything else today?");
            if (YesNo())
            {
                ChooseAnAction();
            }
            else
            {
                Console.WriteLine("See you later then");
            }
        }

        static void ListACar()
        {
            Console.WriteLine("What car would you like to list?");
            Console.WriteLine("");
            carsYouOwn.WhatCarsDoYouOwn(true);
            Console.WriteLine("");
            var userInput = Console.ReadLine();
            Console.WriteLine("");

            switch (userInput)
            {
                case "1":
                    case "car1":
                        case "Car1":
                            case "CAR1":
                                ListACar(car1);
                    break;
                
                case "2":
                     case "car2":
                         case "Car2":
                             case "CAR2":
                               ListACar(car2);
                    break;
                
                case "3":
                    case "car3":
                        case "Car3":
                            case "CAR3":
                               ListACar(car3);
                    break;
                case "4":
                    case "car4":
                        case "Car4":
                            case "CAR4":
                               ListACar(car4);
                    break;
                default:
                    Console.WriteLine("Sorry, I didn't understand that.");
                    Console.WriteLine("Please try again.");
                    ListACar();
                    break;
            }
            
        }

        static void ListACar(Car car)
        {
            if (car.CarIsListed)
            {
                Console.WriteLine("That car is already listed.");
                Console.WriteLine("Would you like to Unlist it");
                if (YesNo())
                {
                    car.Unlist();
                    CarsForSail.CarsListed.Remove(car);
                    Console.WriteLine("Unlist Successful!");
                    Console.WriteLine("Would you like to do anything else today?");
                    if (YesNo())
                    {
                        ChooseAnAction();
                    }
                }
                else
                {
                    Console.WriteLine("would you like to list a different one");
                    if (YesNo())
                    {
                        ListACar();
                    }
                    else
                    {
                        Console.WriteLine("Ok.");
                        ChooseAnAction();
                    }
                }
                
            }
            else
            {


                Console.WriteLine($"Would you like to list your {car.Make} {car.Model} {car.Year}?");
                if (YesNo())
                {
                    Console.WriteLine("List Successful!");
                    car.List();
                    CarsForSail.CarsListed.Add(car);
                    Console.WriteLine("Would you like to do anything else today?");

                    if (YesNo())
                    {
                        ChooseAnAction();
                    }
                    else
                    {
                        Console.WriteLine("Goodbye then.");
                    }


                }
                else
                {
                    Console.WriteLine("List Cancelled.");
                    Console.WriteLine("would you like to list another car?");
                    if (YesNo())
                    {
                        Console.WriteLine("");
                        ListACar();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ok.");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("");
                        ChooseAnAction();
                    }

                }
            }
        }
        
        static void ChooseAnAction()
        {
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("To List A Car");
            Console.WriteLine("Type: List");
            Console.WriteLine("");
            Console.WriteLine("To Check Your Cars");
            Console.WriteLine("Type: Check");
            Console.WriteLine("");
            Console.WriteLine("To See Listed Cars");
            Console.WriteLine("Type: Listed");
            Console.WriteLine("");
            Console.WriteLine("To Exit");
            Console.WriteLine("Type: Exit");
            Console.WriteLine("");
            
            var userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "list":
                    Console.WriteLine("");
                    ListACar();
                    break;
                case "check":
                    Console.WriteLine("");
                    CheckYourCars();
                    break;
                case "listed":
                    Console.WriteLine("");
                    WhatCarsHaveYouListed();
                    break;
                case "exit":
                    Console.WriteLine("");
                    Console.WriteLine("Goodbye then!");
                    break;
                default:
                    Console.WriteLine("Sorry, I didn't understand that.");
                    Console.WriteLine("Please try again.");
                    Console.WriteLine("");
                    ChooseAnAction();
                    break;
            }
            
        }
    }
}
