using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _06._Store_Boxes
{
    class Box
    {
        private string SerialNumber_;
        private string Item_;
        private int ItemQuantity_;
        private double PriceForBox_;

        public Box(string serialNumber, string item, int itemQuantity, double priceForBox)
        {
            this.SerialNumber_ = serialNumber;
            this.Item_ = item;
            this.ItemQuantity_ = itemQuantity;
            this.PriceForBox_ = priceForBox;
            BoxPrice = itemQuantity * priceForBox;
        }

        public string SerialNumber { get => SerialNumber_; set => SerialNumber_ = value; }

        public string Item { get => Item_; set => Item_ = value; }

        public int ItemQuantity { get => ItemQuantity_; set => ItemQuantity_ = value; }

        public double PriceForBox { get => PriceForBox_; set => PriceForBox_ = value; }

        public double BoxPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] boxInfo = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                double price = double.Parse(boxInfo[3]);

                Box box = new Box(serialNumber, itemName, itemQuantity, price);
                boxes.Add(box);

                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(box => box.BoxPrice).ToList();
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - ${box.PriceForBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }
}
