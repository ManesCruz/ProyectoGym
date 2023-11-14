using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class RegularUser : UserEntity
    {
        public RegularUser(string name, int age, double weight, double height, string physicalLevel, string objetive, string genre, string unitType) :
            base(name, age, weight, height, physicalLevel, objetive, genre, unitType)
        {

        }
    }
}
