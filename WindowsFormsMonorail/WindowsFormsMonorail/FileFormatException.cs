﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMonorail
{
    class FileFormatException : Exception
    {
        public FileFormatException() : base("Неверный формат файла")
        {

        }
    }
}