﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_arv
{
    class FalseBlock : Block
    {
        public FalseBlock()
        {
            fallThrough = true;
        }

    }
}
