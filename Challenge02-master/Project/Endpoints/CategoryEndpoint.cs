using System;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Dtos;
using Project.Mapping;

namespace Project.Endpoints;

public static class CategoryEndpoint
{
/*    private static readonly List<CategoryDto> categories = [
    new (1, "Kids and Family"),
    new (2, "Eco-Friendly Living")
];*/

    public static RouteGroupBuilder MapCategoryEndpoint(this WebApplication app)
    {
        var group = app.MapGroup("categories");
        group.MapGet("/", (ProjectContext dbContext) => 
        dbContext.Categories
                    .Select(category => category.ToDto())
                    .AsNoTracking()
                    .ToList());
        return group;

    }


}
