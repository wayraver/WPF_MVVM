using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WPF_MVVM.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Timer = System.Timers.Timer;

namespace WPF_MVVM.Models
{
    public class Server
    {
        public Server() 
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }
        //==================== Fields ================================= 

        Random _random = new Random();

        //==================== Methods ================================
        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Trade trade = new Trade();

            trade.Volume = _random.Next(-10, 10);   
            trade.Price = _random.Next(50000, 60000);
            trade.DateTime = DateTime.Now;  

            EventTradeDelegate?.Invoke(trade);


            //Number = _random.Next(0, 101);
        }
        //=================== Events =====================================
        public delegate void tradeDelegate(Trade trade);
        public event tradeDelegate EventTradeDelegate;
    }
}
