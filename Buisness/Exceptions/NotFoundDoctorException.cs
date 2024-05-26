﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Exceptions
{
    public class NotFoundDoctorException : Exception
    {
        public string PropertyName { get; set; }
        public NotFoundDoctorException(string propName, string? message) : base(message)
        {
            PropertyName = propName;
        }
    }
}
