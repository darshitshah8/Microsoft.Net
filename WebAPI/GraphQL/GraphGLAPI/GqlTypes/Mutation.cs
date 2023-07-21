using GraphGLAPI.Context;
using GraphGLAPI.Models;
using HotChocolate.Subscriptions;

namespace GraphGLAPI.GqlTypes
{
    public class Mutation
    {
        public async Task<Chocolate> AddChocolateAsync([Service] ChocolateDbContext context, Chocolate newChocolate)
        {
            context.Chocolates.Add(newChocolate);
            await context.SaveChangesAsync();
            return newChocolate;
        }
        public async Task<Chocolate> UpdateChocolateAsync([Service] ChocolateDbContext context, Chocolate updateChocolate)
        {
            context.Chocolates.Update(updateChocolate);
            await context.SaveChangesAsync();
            return updateChocolate;
        }
        public async Task<string> DeleteChocolateAsync([Service] ChocolateDbContext context,int id)
        {
            var chocolateDelete = await context.Chocolates.FindAsync(id);
            if(chocolateDelete == null) 
            {
                return "invalid oparation";
            }
            context.Chocolates.Remove(chocolateDelete);
            await context.SaveChangesAsync();
            return "success";
        }
    }
}






//mutation($Chocolate: ChocolateInput!){
//    addChocolate(newChocolate:$Chocolate){
//        id
//        name
//      price
//    }

//}

//{
//    "Chocolate":{
//        "id":0,
//    "name" :"Kitkat",
//    "price" : 45
//    }