using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class Exercise
    {
        private string _exerciseName;
        private int _series;
        private int _repetitions;
        private string _movement;
        private double _rm;
        private string _implements;

        public string ExerciseName { get => _exerciseName; set => _exerciseName = value; }
        public int Series { get => _series; set => _series = value; }
        public int Repetitions { get => _repetitions; set => _repetitions = value; }
        public string Movement { get => _movement; set => _movement = value; }
        public double RM { get => _rm; set => _rm = value; }
        public string Implements { get => _implements; set => _implements = value; }
     
        public Exercise(string exerciseName, int series,int repetitions, string movement, double rm,string implements)
        {
            _exerciseName = exerciseName;
            _series = series;
            _repetitions = repetitions;
            _movement = movement;
            _rm = rm;
            _implements = implements;

        }
    }
}
