using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gym
{
    public class Diet
    {
        private double _caloriesNumber;
        private string _suggestedFood;
        private string _restriction;
        private string _supplements;

        public double CaloriesNumber { get => _caloriesNumber; set => _caloriesNumber= value; }
        public string SuggestedFood { get => _suggestedFood; set => _suggestedFood = value; } 
        public string Restriction { get => _restriction; set => _restriction = value; }  
        public string Supplements  { get => _supplements; set => _supplements = value; }

        public Diet(double caloriesNumber, string suggestedFood, string restriction, string supplements)
        {
            _caloriesNumber = caloriesNumber;
            _suggestedFood = suggestedFood;
            _restriction = restriction;
            _supplements = supplements;

        }
    }
}
