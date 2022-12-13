namespace Template_Method;

public record Bread;

public class Bakery
{
    // The template method
    public Bread FollowRecipe()
    {
        AddIngredients();
        Mix();
        WaitForDoughToRise();
        BakeInOven();
        return new Bread();
    }

    // Methods to be overriden
    protected virtual void AddIngredients()
    {
        /*  Add flour
         *  Add eggs
         *  Add water
         *  Add salt 
         */
    }
    
    protected virtual void Mix()
    {
        // Stir for 1 minute
    }

    protected virtual void WaitForDoughToRise()
    {
        // Wait for 2 hours
    }

    protected virtual void BakeInOven()
    {
        // Place in oven at 230 *C for 30 minutes
    }

    
}