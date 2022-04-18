using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>(capacity);
        }

        public List<Fish> Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count => Fish.Count;

        public string AddFish(Fish fish)
        {
            if (fish.FishType == null || fish.FishType == " " || fish.Lenght <= 0 || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }
            else if (Count == Capacity)
            {
                return "Fishing net is full.";
            }

            this.Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Fish[i].Weight == weight)
                {
                    Fish.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public Fish GetFish(string fishType)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Fish[i].FishType == fishType)
                {
                    return Fish[i];
                }
            }

            return null;
        }

        public Fish GetBiggestFish()
        {
            Fish biggestFish = null;
            foreach (var item in Fish)
            {
                if (biggestFish == null)
                {
                    biggestFish = item;
                }

                if (item.Lenght > biggestFish.Lenght)
                {
                    biggestFish = item;
                }
            }

            return biggestFish;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Into the {Material}");
            foreach (var item in Fish.OrderByDescending(f => f.Lenght))
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
