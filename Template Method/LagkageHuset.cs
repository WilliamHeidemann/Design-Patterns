namespace Template_Method;

public class LagkageHuset : Bakery
{
    protected override void AddIngredients()
    {
        /*  Add flour
         *  Add eggs
         *  Add water
         *  Add salt
         *  Add sugar
         *  Add vanilla
         *  Add butter
         */
    }

    protected override void Mix()
    {
        // Mix furiously for 2 minutes at 05:00 in the morning
    }

    protected override void WaitForDoughToRise()
    {
        // Wait for 3 hours
    }

    protected override void BakeInOven()
    {
        // Place in oven at 200 *C for 1 hour
    }
}