using System;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = new Weight();
            weight.Add(WeightUnit.Kilogram, 2);
            weight.Add(WeightUnit.Pound, 1);

            Console.WriteLine(weight.GetWeight(WeightUnit.Kilogram) + " kg");
            Console.WriteLine(weight.GetWeight(WeightUnit.Pound) + " pounds");


            Console.ReadKey();
        }
    }
}
