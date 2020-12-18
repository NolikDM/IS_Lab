using System.Collections.Generic;
using System.Linq;

namespace lab_1
{
    class AutoClassResolver
    {
        private int checkedNumber = 0;
        List<int> checkedCriterion;
        Dictionary<string, double> autos = new Dictionary<string, double>();
        public AutoClassResolver(List<int> data)
        {
            checkedNumber = data.Count;
            checkedCriterion = data;
        }
        public List<string> valideClasses()
        {
            List<string> validClass = new List<string>();
            autos.Clear();
            autos.Add("Class_A", 0);
            autos.Add("Class_B", 0);
            autos.Add("Class_C", 0);
            autos.Add("Class_D", 0);
            autos.Add("Class_E", 0);
            autos.Add("Class_F", 0);
            autos.Add("Class_J", 0);
            autos.Add("Class_M", 0);
            autos.Add("Class_S", 0);
            autos.Add("Class_H", 0);
            autos.Add("Class_G", 0);

            if (checkedCriterion.IndexOf(1) > -1)
            {
                autos["Class_A"] += 1 / checkedNumber;
                autos["Class_B"] += 1 / checkedNumber;
                autos["Class_C"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(2) > -1)
            {
                autos["Class_C"] += 1 / checkedNumber;
                autos["Class_D"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_M"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(3) > -1)
            {
                autos["Class_J"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(4) > -1)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_F"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_S"] += 1 / checkedNumber;
                autos["Class_H"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(5) > -1)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_S"] += 1 / checkedNumber;
                autos["Class_H"] += 1 / checkedNumber;
                autos["Class_G"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(6) > -1)
            {
                autos["Class_A"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(7) > -1)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_F"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_M"] += 1 / checkedNumber;
                autos["Class_G"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(8) > -1)
            {
                autos["Class_A"] += 1 / checkedNumber;
                autos["Class_B"] += 1 / checkedNumber;
                autos["Class_C"] += 1 / checkedNumber;
                autos["Class_D"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(9) > -1)
            {
                autos["Class_D"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(10) > -1)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_F"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_S"] += 1 / checkedNumber;
                autos["Class_G"] += 1 / checkedNumber;
            }

            double max = autos.Values.Max();
            foreach (var x in autos)
                if (x.Value == max) validClass.Add(x.Key);
            return validClass;
        }
    }
}
