using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipe)  // Cambio a IRecipe para el principio de Inversion de Dependencias
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}