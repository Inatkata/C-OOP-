namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar supra = new SportCar(200, 10);
            supra.Drive(1);
            System.Console.WriteLine(supra.Fuel);
        }
    }
}
