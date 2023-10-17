using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    public class Calculator
    {
        private int price;
        private int cash;
        private int rest;

        public void setCash(int cash)
        {
            this.cash = cash;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        private void CalculatePayment()
        {
            rest = cash - price;
        }
        
        public int getRest()
        {
            CalculatePayment();
            return rest;
        }
    }
}
