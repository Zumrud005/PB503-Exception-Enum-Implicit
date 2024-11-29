namespace PB503_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Mercedes";
            car1.Model = "e200";
            car1.Type = Type.sedan;


            Car car2 = new Car();
            car2.Brand = "BMW";
            car2.Model = "F30";
            car2.Type = Type.sport;


            Car car3 = new Car();
            car3.Brand = "Toyota";
            car3.Model = "Prius";
            car3.Type = Type.sedan; 

            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());

        }
    }
}
