using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("NIS", "Nissan");
            stocks.Add("AMA", "Amazon");
            stocks.Add("APP", "Apple");

            string GM = stocks["GM"];
            Console.WriteLine(GM);


        List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

        purchases.Add((ticker: "GE", shares: 150, price: 23.21));//3481.50
        purchases.Add((ticker: "GE", shares: 80, price: 19.02));//1521.60
        purchases.Add((ticker: "AMA", shares: 32, price: 17.87));//571.84
        purchases.Add((ticker: "APP", shares: 150, price: 23.21));//3481.50
        purchases.Add((ticker: "GM", shares: 32, price: 17.87));//571.84
        purchases.Add((ticker: "GM", shares: 80, price: 19.02));//1521.60
        purchases.Add((ticker: "NIS", shares: 32, price: 17.87));//571.84
        purchases.Add((ticker: "CAT", shares: 150, price: 23.21));//3481.50
        purchases.Add((ticker: "CAT", shares: 80, price: 19.02));//1521.60

            //Define a new Dictionary to hold the aggregated purchase information.
            Dictionary<string, double> aggregated = new Dictionary<string, double>();

            //- The key should be a string that is the full company name.
            //- The value will be the valuation of each stock (price*amount)

            // var total = 0.00;
            foreach(var stock in stocks)
            {
                foreach(var purchase in purchases) 
                {
                    if(stock.Key == purchase.ticker)
                    {
                        aggregated[stock.Value] = (purchase.shares*purchase.price);
                    }                    
                }
            }

            
            // foreach(var k in aggregated)
            // {
            //     foreach(var purchase in purchases) 
            //     {
            //         if(k.Key == purchase.ticker)
            //         {

            //             aggregated[k.Key] = k.Value +(purchase.shares*purchase.price);
                        
            //         }
            //     }          
            // }

            foreach(var agg in aggregated)
            {
                Console.WriteLine($"{agg.Key}: {agg.Value}");
            }
            
            
            // aggregated[KEY] = TOTAL
            /*{
                "General Electric": 35900,
                "AAPL": 8445,
                ...
            }   
            */

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?

                // If it does, update the total valuation

                // If not, add the new key and set its value
            }
        }
    }
}
