
using ReceitasPOO.Objects;

string ingredienteBase = string.Empty;
string ingredienteEssencial = string.Empty;
string ingredienteReceita = string.Empty;
int select = 5;
ReceitaBase receitaBase;

Console.WriteLine("Olá");
Console.WriteLine();

while (select != 0)
{
    Console.WriteLine("Pressione 1 para preparar Milanesa ou 2 para preparar Sopa (ou 0 para SAIR):");
    select = int.Parse(Console.ReadLine());

    switch (select)
    {
        case 1:
            ingredienteBase = "Farinha de trigo";
            ingredienteEssencial = "Ovos";
            ingredienteReceita = "Bife";
            //polimorfismo
            receitaBase = new Milanesa(ingredienteBase, ingredienteEssencial);
            receitaBase.SetIngrediente(ingredienteReceita);
            Console.WriteLine($"\n Ingrediente base: {receitaBase.IngredienteBase} \n Ingrediente essencial: {receitaBase.IngredienteEssencial} \n Ingrediente receita: {receitaBase.IngredienteReceita}\n");
            break;
        case 2:
            ingredienteBase = "Agua";
            ingredienteEssencial = "Legumes";
            ingredienteReceita = "Frango";
            //polimorfismo
            receitaBase = new Sopa(ingredienteBase, ingredienteEssencial);
            receitaBase.SetIngrediente(ingredienteReceita);
            Console.WriteLine($"\n Ingrediente base: {receitaBase.IngredienteBase} \n Ingrediente essencial: {receitaBase.IngredienteEssencial} \n Ingrediente receita: {receitaBase.IngredienteReceita}\n");
            break;
        case 0:
            break;
        default:
            Console.WriteLine("\n Escolha invalida. Tente novamente:\n");
            break;
    }
}




