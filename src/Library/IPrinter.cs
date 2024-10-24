
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
         void PrintRecipe(IRecipeContent recipe);  // Cambio a IRecipe para el principio de Inversion de Dependencias
    }
}