using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolerOOP.Objects.CoolerData;

namespace CoolerOOP.Objects.fruits
{
    public class Fruit : Objects.CoolerData.Cooler
    {
        public delegate void fruitExpired(string fruitName);
        public event fruitExpired onFruitExpiredEvent;
        public int remainingDaysUntilExpiration;
        private string fruitName;
        public Fruit(int expire, string fruitName)
        {
            this.remainingDaysUntilExpiration = expire;
            this.onFruitExpiredEvent = delegate { };
            this.fruitName = fruitName;
        }
        public void dayPass()
        {
            this.remainingDaysUntilExpiration -= 1;
            if (remainingDaysUntilExpiration == 0)
                this.onFruitExpiredEvent.Invoke(this.fruitName);
        }
    }
}
