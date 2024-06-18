using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WPF_MVVM.Models;
using WPF_MVVM.Entity;
using Timer = System.Timers.Timer;

namespace WPF_MVVM.ViewModels
{
    public class VM : BaseVM
    {
        public VM()
        {
            _server = new Server();
            _server.EventTradeDelegate += _server_EventTradeDelegate;

        }

        
        //==================== Fields =================================
        
        Server _server;

        //==================== Properties =============================

        public decimal Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                OnPropertyChanged(nameof(Volume));
            }
        }
        decimal _volume;

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        decimal _price;

        public DateTime DateTimeTrade
        {
            get => _dateTimeTrade;
            set
            {
                _dateTimeTrade = value;
                OnPropertyChanged(nameof(DateTimeTrade));
            }
        }
        DateTime _dateTimeTrade;

        public Side TradeSide
        {
            get => _tradeSide;
            set
            {
                _tradeSide = value;
                OnPropertyChanged(nameof(TradeSide));
            }
        }
        Side _tradeSide;

        public decimal Summ
        {
            get => _summ;
            set
            {
                _summ = value;
                OnPropertyChanged(nameof(Summ));
            }
        }
        decimal _summ;

        //==================== Methods =============
        private void _server_EventTradeDelegate(Trade trade)
        {
            Volume = trade.Volume;
            Price = trade.Price;
            DateTimeTrade = trade.DateTime;
            Summ += Volume;
            TradeSide = trade.Side;
            
        }





    }
}
