using System;
using System.Collections.Generic;

namespace BuilderDesignPattern
{
    public abstract class Equipment : IEquipment
    {
        protected List<IValidation> Validations = new List<IValidation>();

        public void AddValidation(IValidation validation) => Validations.Add(validation);

        public IEnumerable<string> GetConstructionStatus()
        {
            foreach (var item in GetValidationStatus())
            {
                yield return $"{this.GetType().Name} - " +
                             $"{item.ValidationType?.Title} - " +
                             $"{item.ValidationType?.ValidationSeverity} - " +
                             $"{item.ValidationType?.requirement?.ValidationType?.Title} -" +
                             $"{item.ValidationType?.NeedsRequirementAproval} - " +
                             $"supervisor {item.ValidatedBySupervisor} - master {item.ValidateByMaster} on {item.ValidationDate}";
            }
        }

        public abstract IEnumerable<IValidation> GetValidationStatus();
    }
}
