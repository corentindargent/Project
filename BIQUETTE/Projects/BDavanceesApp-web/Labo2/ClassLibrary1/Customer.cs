﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary1
{
    public class Customer
    {
        public double AccountBalance { get; set; }

        public string AdresseLine1 { get; set; }

        public string AdresseLine2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public long id { get; set; }

        public string Name{ get; set; }

        public string PostCode { get; set; }

        public string Remark { get; set; }

        //Add Optimistic Concurency
        [Timestamp]
        public byte[] RowVersion{ get; set; }
    }
}
