﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module05tp02Pizzas
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Pate { get; set; }
        public List<string> Ingredients { get; set; }

        //public static List<Ingredient> IngredientsDisponibles => new List<Ingredient>
        //{
        //    new Ingredient{Id=1,Nom="Mozzarella"},
        //    new Ingredient{Id=2,Nom="Jambon"},
        //    new Ingredient{Id=3,Nom="Tomate"},
        //    new Ingredient{Id=4,Nom="Oignon"},
        //    new Ingredient{Id=5,Nom="Cheddar"},
        //    new Ingredient{Id=6,Nom="Saumon"},
        //    new Ingredient{Id=7,Nom="Champignon"},
        //    new Ingredient{Id=8,Nom="Poulet"}
        //};

        //public static List<Pate> PatesDisponibles => new List<Pate>
        //{
        //    new Pate{ Id=1,Nom="Pate fine, base crême"},
        //    new Pate{ Id=2,Nom="Pate fine, base tomate"},
        //    new Pate{ Id=3,Nom="Pate épaisse, base crême"},
        //    new Pate{ Id=4,Nom="Pate épaisse, base tomate"}
        //};
    }
}
