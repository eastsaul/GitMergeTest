namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beta
            string userInput = string.Empty;
            ConsoleApp1.WriteLine("이 프로그램은 츠dmf inch로 변환하는 프로그램");
            ConsoleApp1.Write("cm 값을 입력 :");
            userInput = ConsoleApp1.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            // Beta
            ruler.Run();
        }
    }

    public class Ruler 
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch 
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run() 
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }
    }

}