﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP2._1.ViewModel
{
        public partial class BaseViewModel : ObservableObject
        {
            [ObservableProperty]
            public bool _isBusy;
            [ObservableProperty]
            public string _title;
        }
    }

