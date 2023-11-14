using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class UserEntity
    {
        private string _name;
        private int     _age;
        private double _weight;
        private double _height;
        private string _physicalLevel;
        private string _objetive;
        private string _genre;
        private string _unitType;
        private string _id;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public double Height { get => _height; set => _height = value; }
        public string PhysicalLevel { get => _physicalLevel; set => _physicalLevel = value; }
        public string Objetive { get => _objetive; set => _objetive = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public string UnitType { get => _unitType; set => _unitType = value; }
        public string Id { get => _id; set => _id = value; }

        public UserEntity(string name, int age, double weight, double height, string physicalLevel, string objetive, string genre, string unitType, string id)
        {
                _name = name;
                _age = age;
                _weight = weight;
                _height = height;
                _physicalLevel = physicalLevel;
                _objetive = objetive;
                _genre = genre;
                _unitType = unitType;
                _id = id;
        }
    }
}

