﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Kontract.Interface
{
    public interface IImageSwizzle
    {
        int Width { get; set; }
        int Height { get; set; }

        Point Get(Point point);
    }
}
