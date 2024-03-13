using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CoolerOOP.Objects.CoolerData
{
    public abstract class CoolerObject
    {
        protected Dictionary<string,int> MapFruit = new Dictionary<string, int>();
        protected abstract void onExpireDate(string fruitName);
    }
}