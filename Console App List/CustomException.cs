﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_List
{
    class CustomException:Exception
    {
        public CustomException(string message):base(message)
        {
            
        }
    }
}
