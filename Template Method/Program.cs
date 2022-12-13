using Template_Method;

var standardBakery = new Bakery();
var lagkageHuset = new LagkageHuset();

var bread = standardBakery.FollowRecipe();
var expensiveBread = lagkageHuset.FollowRecipe();