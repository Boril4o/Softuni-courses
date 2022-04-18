using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGamesCount = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());

            var headsetTrashesCount = 0;
            var mouseTrashesCount = 0;
            var keyboardTrashesCount = 0;
            //var SecondTrashesKeyboard = 0;
            var displayTrashesCount = 0;


            for (int i = lostGamesCount; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    headsetTrashesCount++;
                    if (i % 3 == 0)
                    {
                        mouseTrashesCount++;
                        keyboardTrashesCount++;
                        //SecondTrashesKeyboard++;
                        if (keyboardTrashesCount % 2 == 0)
                        {
                            displayTrashesCount++;
                            
                        }
                    }
                }
                else if (i % 3 == 0)               
                {
                    mouseTrashesCount++;
                }


            }

            double headsetSum = headsetTrashesCount * headsetPrice;
            double mouseSum = mouseTrashesCount * mousePrice;
            double keyboardSum = keyboardTrashesCount * keyboardPrice;
            double displaySum = displayTrashesCount * displayPrice;
            double totalSum = headsetSum + mouseSum + keyboardSum + displaySum;

            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
