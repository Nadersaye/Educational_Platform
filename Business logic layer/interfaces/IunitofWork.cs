﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_layer.interfaces
{
   public interface IunitofWork
    {
        Task<int> Save();
    }
}
