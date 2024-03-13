using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoolerOOP.Objects.fruits;

namespace CoolerOOP.Objects.CoolerData
{
    public class Cooler : CoolerObject
    {
        public void addFruit(string name, int expireDay)
        {
            if(base.MapFruit.TryGetValue(name, out int value))
                base.MapFruit[name] += 1;
            else
                base.MapFruit[name] = 1;

            Fruit fruit = new Fruit(expireDay, name);
            fruit.onFruitExpiredEvent += onExpireDate;
            new Thread(() =>
            {
                while (true)
                {
                    if (fruit.remainingDaysUntilExpiration == 0)
                        break;
                    Thread.Sleep(1000);
                    Console.WriteLine("day passed");
                    fruit.dayPass();
                }
            }).Start();
        }
        public void printFruits()
        {
            int[] values = new int[1];
            int index = 0;
            foreach (int value in base.MapFruit.Values)
            {
                values[index] = value;
                Array.Resize(ref values, 1);
                index++;
            }
            index = 0;
            foreach (var key in base.MapFruit.Keys)
            {
                Console.WriteLine($"{values[index]} units of {key}");
                index++;
            }
        }
        protected override void onExpireDate(string fruitName)
        {
            Console.WriteLine($"1  unit of {fruitName} has been removed due expire day");
            base.MapFruit[fruitName] -= 1;
        }
    }
}
