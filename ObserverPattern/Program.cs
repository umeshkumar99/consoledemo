using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM("IBM", 120);
            ibm.Attach(new Investor("Umesh"));
            ibm.Attach(new Investor("Lakshmi"));

            ibm.Price = 123;
            ibm.Price = 127;
            ibm.Price = 130;
            Console.ReadLine();
        }

        public abstract class Stock
        {
            private string _symbol;
            private double _price;
            private List<IInvestor> _investors = new List<IInvestor>();
            public Stock(string symbol, double price)
            {
                _symbol = symbol;
                _price = price;
            }
            public void Attach(IInvestor investor)
            {
                _investors.Add(investor);
            }
            public void Detach(IInvestor investor)
            {
                _investors.Remove(investor);
            }
            public void Notify()
            {
                foreach (IInvestor investor in _investors)
                {
                    investor.UpdateStock(this);
                }
                Console.WriteLine("");
            }
            public double Price
            {
                get { return _price; }
                set
                {
                    if (_price != value)
                    {
                         _price = value;
                        Notify();
                    }
                }
            }

            public string Symbol
            {
                get { return _symbol; }
            }
        }

        public class IBM: Stock
        {
            public IBM(string symbol, double price)
                :base(symbol,price)
            { }

        }
      public  interface IInvestor
        {
            void UpdateStock(Stock stock);
        }

        public class Investor: IInvestor
        {
            private string _name;
            private Stock _stock;
            public Investor(string name)
            {this. _name = name; }

            public void UpdateStock(Stock stock)
            {
                Console.WriteLine("Notified {0} of {1}'s " +
        "change to {2:C}", _name, stock.Symbol, stock.Price);
            }

            public Stock Stock
            {
                get { return _stock; }
                set { _stock = value; }
            }
        }
    }
}
