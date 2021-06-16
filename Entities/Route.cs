using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multipurposeOrm.Attributes;
using multipurposeOrm.Entities;
using multipurposeOrm.Interfaces;

namespace ORM
{
    class Route : BaseEntity
    {
        private long _id;
        private string _number;
        private string _name;

        public long Id { get => _id; set => SetProperty(ref _id, value); }
        public string Number { get => _number; set => SetProperty(ref _number, value); }
        public string Name { get => _name; set => SetProperty(ref _name, value); }
    }
}
