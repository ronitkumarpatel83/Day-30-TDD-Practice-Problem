﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_30_TDD_PracticeProblem
{
    internal class CabInvoiceException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDE,
            INVALID_ID, INVALID_TYPE
        }
        public ExceptionType type;
        public CabInvoiceException(ExceptionType type, string message) : base(message) // Creating a constructor with parent class
        {
            this.type = type;// Assigning value
        }
    }
}
