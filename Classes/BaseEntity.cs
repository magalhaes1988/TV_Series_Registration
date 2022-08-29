using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Series_Registration.Interfaces
{
    public abstract class BaseEntity
    {
        private int id;

        public int Id { get => id; set => id = value; }
    }
}