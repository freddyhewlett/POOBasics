using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasPOO.Objects
{
    public abstract class ReceitaBase
    {
        public Guid Id { get; private set; }
        public string IngredienteBase { get; protected set; }
        public string IngredienteEssencial { get; protected set; }
        public string IngredienteReceita { get; protected set; }

        public ReceitaBase()
        {
            Id = Guid.NewGuid();
        }

        protected void SetIngredienteBase(string ingrediente)
        {
            IngredienteBase = ingrediente;
        }

        public virtual void SetIngrediente(string ingrediente)
        {
            IngredienteEssencial = ingrediente;
        }
    }
}
