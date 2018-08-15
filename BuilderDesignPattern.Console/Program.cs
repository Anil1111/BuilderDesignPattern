using System;

namespace BuilderDesignPattern.Consoles
{
    class Program
    {
        static void Main(string[] args)
        {
            IEquipment equipment;
            Validator validator = new Validator();

            equipment = new StorageEquipment();
            equipment.AddValidation(getStrictvalidation());
            equipment.AddValidation(getSimplevalidation());


            Console.WriteLine(validator.Validate(equipment));

            Console.ReadKey();

            equipment = new RotaryEquipment();
            equipment.AddValidation(getStrictvalidation());
            equipment.AddValidation(getSimplevalidation());

            Console.WriteLine(validator.Validate(equipment));

            Console.ReadKey();
        }

        private static IValidation getSimplevalidation()
        {
            return new FoundationValidation
            {
                ValidationType = new ExternalValidationType
                {
                    Title = "simple",
                    NeedsRequirementAproval = false,
                    requirement = null,
                },
                ValidatedBySupervisor = true,
                ValidateByMaster = true
            };
        }

        private static IValidation getStrictvalidation()
        {
            return new FoundationValidation
            {
                ValidationType = new ExternalValidationType
                {
                    Title = "strict",
                    NeedsRequirementAproval = true,
                    requirement = new FoundationValidation(),
                },
                ValidatedBySupervisor = true
            };
        }
    }
}
