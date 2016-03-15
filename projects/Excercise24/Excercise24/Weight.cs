using System.Collections.Generic;

namespace Exercise24
{
    public class Weight
    {
        // This field will always contain the weight in kg
        private double weightKg;

        // Convertion constants
        private readonly Dictionary<WeightUnit, double> convertValues;

        public Weight()
        {
            // The dictionary contains values mapped to a conversion constant
            convertValues = new Dictionary<WeightUnit, double>
            {
                {WeightUnit.Kilogram, 1},
                {WeightUnit.Gram, 1000},
                {WeightUnit.Pound, 2.20462},
                {WeightUnit.Tonne, 0.001},
                
            };
        }

        public void SetWeight(WeightUnit unit, double weight)
        {
            //weightKg = weight / convertValues[unit];
            weightKg = weight / GetFactor(unit);
        }

        public double GetWeight(WeightUnit unit)
        {
            //return weightKg*convertValues[unit];
            return weightKg * GetFactor(unit);
        }

        public void Add(WeightUnit unit, double weight)
        {
            //weightKg += weight / convertValues[unit];
            weightKg += weight / GetFactor(unit);
        }

        private double GetFactor(WeightUnit unit)
        {
            var result = 0.0;

            switch (unit)
            {
                case WeightUnit.Pound:
                    result = 2.20462;
                    break;
                case WeightUnit.Kilogram:
                    result = 1.0;
                    break;
                case WeightUnit.Gram:
                    result = 1000.0;
                    break;
                case WeightUnit.Tonne:
                    result = 0.001;
                    break;
            }

            return result;
        }
    }
}