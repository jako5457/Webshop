﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Dto
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
