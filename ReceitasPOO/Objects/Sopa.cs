using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasPOO.Objects
{
    //Herança
    internal class Sopa : ReceitaBase
    {
        public string IngredienteSopa { get; private set; }
        public Sopa(string ingredienteBase, string ingredienteEssencial) //Ex: Agua, legumes
        {
            SetIngredienteBase(ingredienteBase);
            base.SetIngrediente(ingredienteEssencial);
        }

        //Encapsulamento --> Poderia ser privado e ficar setado em SetIngrediente (public)
        public void SetSopa(string ingredienteSopa)
        {
            IngredienteSopa = ingredienteSopa;
            base.IngredienteReceita = IngredienteSopa;
        }

        //Polimorfismo
        public override void SetIngrediente(string ingredienteSopa)
        {
            SetSopa(ingredienteSopa);
        }
    }
}
