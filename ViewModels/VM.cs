using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace WPF_MVVM.ViewModels
{
    public class VM : BaseVM
    {
        public VM()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }
        //==================== Properties =============================

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }
        int _number;

        //==================== Fields ================================= 

        Random _random = new Random();

        //==================== Methods ================================
        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Number = _random.Next(0, 101);
        }

        
        
    }
}
