﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11._1._1
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public Author  Author { get; set; }

        public override string ToString()
        {
            return $"{Title} ({YearOfPublication})";
        }
    }
}
