using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>

    /* Class: Class1
     * Author: Maxwell Chu
     * Purpose: Contains the main method used to answer #6 in PE4
     * Restrictions: None
     */
    static class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        /* Method: Main
         * Purpose: Alters the Mandelbrot project so that the user has more interaction to change what appears in the console
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //String variables initiated used for user interaction to replace the default start and end values
            string imagCoordStartInput, imagCoordEndInput, realCoordStartInput, realCoordEndInput;
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            //The console asks the user to implement their own values for the image
            Console.WriteLine("Please enter the start and end values for the image and real coordinates respectively. The default values are 1.2 to -1.2 and -0.6 to 1.77 respectively.");
            imagCoordStartInput = Console.ReadLine();
            imagCoordEndInput = Console.ReadLine();
            realCoordStartInput = Console.ReadLine();
            realCoordEndInput = Console.ReadLine();
            //Double variables are initaited to place the converted string values into actual numbers
            double imagCoordStartInputNum = Convert.ToDouble(imagCoordStartInput);
            double imagCoordEndInputNum = Convert.ToDouble(imagCoordEndInput);
            double realCoordStartInputNum = Convert.ToDouble(realCoordStartInput);
            double realCoordEndInputNum = Convert.ToDouble(realCoordEndInput);
            //While conditions checks to make sure that both sets are more/less than what they were and will repeat until condition is met
            while (imagCoordStartInputNum < imagCoordEndInputNum)
            {
                Console.WriteLine("Please input new start and end values for the image coordinates. The start has to be greater than the end.");
                imagCoordStartInput = Console.ReadLine();
                imagCoordEndInput = Console.ReadLine();
                imagCoordStartInputNum = Convert.ToDouble(imagCoordStartInput);
                imagCoordEndInputNum = Convert.ToDouble(imagCoordEndInput);
            }
            while (realCoordStartInputNum > realCoordEndInputNum)
            {
                Console.WriteLine("Please input new start and end values for the real coordinates. The start has to be less than the end.");
                realCoordStartInput = Console.ReadLine();
                realCoordEndInput = Console.ReadLine();
                realCoordStartInputNum = Convert.ToDouble(realCoordStartInput);
                realCoordEndInputNum = Convert.ToDouble(realCoordEndInput);
            }
            //Custom double variables are initiated to determine how many increments are needed based off user input
            double imagCoordIncrement = (imagCoordEndInputNum - imagCoordStartInputNum) / 48;
            double realCoordIncrement = (realCoordEndInputNum - realCoordStartInputNum) / 80;
            //The for loop conditions are changed so that the custom numbers from the user are put in
            for (imagCoord = imagCoordStartInputNum; imagCoord >= imagCoordEndInputNum; imagCoord += imagCoordIncrement)
            {
                for (realCoord = realCoordStartInputNum; realCoord <= realCoordEndInputNum; realCoord += realCoordIncrement)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}