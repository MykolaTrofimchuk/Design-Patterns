﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    interface IObserver
    {
        void HandleEvent(string eventName);
    }
}
