using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasPOO.Objects
{
    //Herança
    internal class Milanesa : ReceitaBase
    {
        public string IngredienteMilanesa { get; private set; }
        public Milanesa(string ingredienteBase, string ingredienteEssencial) //Ex: Farinha de rosca, ovo
        {
            SetIngredienteBase(ingredienteBase);
            base.SetIngrediente(ingredienteEssencial);
        }

        //Encapsulamento --> Poderia ser privado e ficar setado em SetIngrediente (public)
        public void SetMilanesa(string ingredienteMilanesa)
        {
            IngredienteMilanesa = ingredienteMilanesa;
            base.IngredienteReceita = IngredienteMilanesa;
        }

        //Polimorfismo
        public override void SetIngrediente(string ingredienteMilanesa)
        {
            SetMilanesa(ingredienteMilanesa);
        }
    }
}
