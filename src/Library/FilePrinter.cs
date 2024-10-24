using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipe)  // Cambio a IRecipe para el principio de Inversion de Dependencias
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}