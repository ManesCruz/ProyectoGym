using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class UserPremium : UserEntity
    {
        private double _caloriesCounter;
        private string _paymentMethod;
        private string _gift;
        private string _personalTrainer;

        public double CaloriesCounter { get => _caloriesCounter; set => _caloriesCounter = value; }
        public string PaymentMethod { get => _paymentMethod; set => _paymentMethod = value; }
        public string Gift { get => _gift; set => _gift = value; }
        public string PersonalTrainer { get => _personalTrainer; set => _personalTrainer = value; }

        public UserPremium(JObject json)
        {
            Id = (string)json["Id"];
            Name = (string)json["Name"];
            Age = (int)json["Age"];
            Weight = (double)json["Weight"];
            Height = (double)json["Height"];
            PhysicalLevel = (string)json["PhysicalLevel"];
            Objetive = (string)json["Objetive"];
            Genre = (string)json["Genre"];
            UnitType = (string)json["UnitType"];
        }

            public UserPremium(string name, int age, double weight, double height, string physicalLevel, string objetive, string genre, string unitType,string id)
            :base( name, age, weight, height, physicalLevel, objetive, genre, unitType,id)
        {   
            
        }

        public void SetCaloriesCounter(double caloriesCounter) {
            _caloriesCounter = caloriesCounter;
        }
        public void SetPaymentMethod(string paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public void SetGift(string gift)
        {
            _gift = gift;
        }
        public void SetPersonalTrainer(string personalTrainer)
        {
            _personalTrainer = personalTrainer;
        }

    }
}

