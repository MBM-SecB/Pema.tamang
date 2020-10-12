

//  using System;
// using System.Diagnostics;
// using System.Threading;
// using System.Threading.Tasks; 

// namespace ParallelAndAsync
// {
//     class Program
//     {
//         static void Main()
//         {
//             // TPL - Task Parallel Library

//             int[] numbers = { 23, 45, 12, 56, 78, 43, 54, 65, 32, 21 };
//             Stopwatch stopwatch = new Stopwatch();
//             //Sequential
//             stopwatch.Start();
//             foreach(var num in numbers)
//             {
//                 Compute(num);
//             }
//             Console.WriteLine($"Time taken (Sequential): {stopwatch.ElapsedMilliseconds} ms");

//             // Parallel
//             stopwatch.Restart();
//             Parallel.ForEach(numbers, num => {
//                 Compute(num);
//             });
//             Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapsedMilliseconds} ms");

//         }

//         static void Compute(int x)
//         {
//             Thread.Sleep(100);
//             Console.WriteLine($"Computed for {x}");
//         }
//     }
// }
// /* comment */
//
//
static void Main()
{
    //Example : maing breakfast
    
    //make Tea
    // -Turn on burner(2s)
    //-Put on kettle(1s)
    //-Add water(2s)
    //-Boil it(3min)
    //-Grid teas masala(10s)
    //-Add sugar and masalas(2s)
    //-Add milk(2s)
    //-Boil it (2min)

    //Fry eggs
    //-turn on burner(2s)
    //-Put on pan(1s)
    //-Add oil(2s)
    //-Crack eggs and stir it(2min)
    //-Fry it(1min)

    //Everything ready : Serve it

    //Sequential
    TurnOnBurner();
    Console.WriteLine("Burner turn on.");

    PutOnKettle();
    Console.WriteLine("Put kettel on burner.");

    Add("water");
    Console.WriteLine("Added water on kettle.");

    BoilIt();
    Console.WriteLine("Water boiled.");
    
    GrindTeaMasala();
    Console.WriteLine("Grinded tea masala.");

    Add(sugar);
    Console.WriteLine("added sugar.");

    Add("masala");
    Console.WriteLine("Added masala.");

    Add("Milk);
    Console.WriteLine("Added milk.");

    Boil("Milk);
    Console.WriteLine("boil milk.");

    TurnOnBurner();
    Console.WriteLine("Burner2 Turned on");

    PutOn("Pan");
    Console.WriteLine("Put on pan");

    Add ("Oil");
    Console.WriteLine("Added oil");

    CrackAndStirEggs();
    Console.WriteLine("Cracked and stired eggs");

    FryEggs();
    Console.WriteLine("Fried eggs");

    Serve();
    Console.WriteLine("");



    
}
private static void TurnOnBurner()
{
    Thread.Sleep(2000);
}

private static void FryEggs()
{
    Task.delay(1000);
}

private static void CrackAndEggs()
{
    Task.delay(2000);
}


























