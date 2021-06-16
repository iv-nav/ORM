using multipurposeOrm.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    [AgeValidation(18)]
    class Person
    {
        public string name;
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{name} age {Age}";
        }
    }
}
