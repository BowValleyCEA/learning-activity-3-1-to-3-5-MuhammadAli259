// See https://aka.ms/new-console-template for more information
LearningActivity31();
LearningActivity32();
LearningActivity33();
LearningActivity34();
LearningActivity35();

void LearningActivity31()
{
    Console.WriteLine("This is the function for Learning Activity 3.1!");

    // Function to convert temperature

     static double TemperatureConverter(double inputTemperature,string targetScale)

    {

        double convertedTemperature = 0;

        switch (targetScale.ToLower())

        {

            case "f":

                // Celsius to Fahrenheit

                convertedTemperature = (inputTemperature * 9 / 5) +

                32;

                break;

            case "c":

                // Fahrenheit to Celsius

                convertedTemperature = (inputTemperature - 32) * 5 /

                9;

                break;

        }

        return convertedTemperature;

    }

     static void Main(string[] args)

    {

        Console.WriteLine("Enter the temperature to convert:");

        double userTemperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Convert To Fahrenheit (f) or Celsius (C)?");

        string conversionScale = Console.ReadLine();

        double resultTemperature =

        TemperatureConverter(userTemperature, conversionScale);

        Console.WriteLine("Converted Temperature: " +

        resultTemperature);
    }
}


void LearningActivity32()
{
    Console.WriteLine("This is the function for Learning Activity 3.2!");
}
void LearningActivity33()
{
    Console.WriteLine("This is the function for Learning Activity 3.3!");
}

void LearningActivity34()
{
    int number;
    bool success = int.TryParse(Console.ReadLine(), out number); //example code
    Console.WriteLine("This is the function for Learning Activity 3.4!");
}

void LearningActivity35()
{
    int[] highScores = { 1272700, 1271100, 1243000, 1218000, 1214300, 1210800, 1210400, 1206800, 1178400 };
    Console.WriteLine("This is the function for Learning Activity 3.5!");
}

