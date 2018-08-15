using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesignPattern
{
    public class Validator
    {
        public String Validate(IEquipment equipment)
        {
            return string.Join(",\n", equipment.GetConstructionStatus());
        }
    }
}
