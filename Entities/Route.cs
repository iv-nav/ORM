using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multipurposeOrm.Attributes;

namespace ORM
{
    class Route
    {
        [MyAttr("id")]
        private long id;
        public string number;
        public string name;
    }
}
