using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        protected int sugar;
        protected int money;
        protected int piecesOfSweet;
        protected int piecesOfCandy;
        protected int piecesOfLollipop;
        protected int priceOfSweet;
        protected int priceOfCandy;
        protected int priceOfLollipop;
        protected int sugarNeededForSweets;

        public CandyShop(int sugar)
        {
            this.sugar = sugar;
        }

        public CandyShop()
        {
        }

        public virtual void CreateSweets()
        {
            piecesOfSweet = piecesOfSweet + 1;
            sugar = sugar - sugarNeededForSweets;
        }

        public virtual void Sell()
        {
            piecesOfSweet = piecesOfSweet - 1;
            money = money + priceOfSweet;
        }

        public virtual void Raise(int increasePercentage)
        {
            priceOfSweet = priceOfCandy * (1 + increasePercentage /100);
        }

        public void BuySugar(int boughtSugar)
        {
            money = money - (boughtSugar /1000) * 100;
            sugar = sugar + boughtSugar;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Inventory: {piecesOfCandy} candies, {piecesOfLollipop} lollipops, Income: {money}, Sugar: {sugar}");
        }
    }
}
