using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesignPattern
{
    public class StorageEquipment : Equipment, IEquipment
    {
        /// <summary>
        /// this method verifies just the validation which are approved by one of the persons
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<IValidation> GetValidationStatus()
        {
            return this.Validations.Where(v => v.ValidatedBySupervisor || v.ValidateByMaster).ToList();
        }
    }
}
