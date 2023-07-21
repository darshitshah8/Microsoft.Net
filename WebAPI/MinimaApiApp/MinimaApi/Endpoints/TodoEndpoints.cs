using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TodoLibrary.DataAccess;

namespace MinimaApi.Endpoints;

public static class TodoEndpoints
{
    public static void AddTodoEndpoitns(this WebApplication app)
    {
        app.MapGet("/api/Todos", GetAllTodos);
        app.MapPost("/api/Todos", CreateTodos).RequireAuthorization();
        app.MapDelete("/api/Todos{id}", DeleteTodos).RequireAuthorization();
    }
    [Authorize]
    private async static Task<IResult> GetAllTodos(ITodoData data)
    {
        var output = await data.GetAllAssigned(1);
        return Results.Ok(output);
    }
    private async static Task<IResult> CreateTodos(ITodoData data,[FromBody] string task)
    {
            var output = await data.Create(1, task);
            return Results.Ok(output);
        
    }    
    private async static Task<IResult> DeleteTodos(ITodoData data, int id)
    {
        await data.Delete(1, id);
        return Results.Ok();
    }
}
