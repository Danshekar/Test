﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailsDemo.CS
{
    public class MasterPageItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
