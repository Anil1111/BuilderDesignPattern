using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesignPattern
{
    public class RotaryEquipment : Equipment, IEquipment
    {
        /// <summary>
        /// this method requires all full restricted validation and it's approval
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<IValidation> GetValidationStatus()
        {
            return this.Validations.Where(
                v =>
                    (v.ValidationType.requirement == null ||
                    !v.ValidationType.NeedsRequirementAproval)
                    &&
                    (v.ValidateByMaster && 
                    v.ValidatedBySupervisor) 
               ).ToList();
        }
    }
}
