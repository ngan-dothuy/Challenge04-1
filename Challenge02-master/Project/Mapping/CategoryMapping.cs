using System;
using Project.Entities;
using Library;

namespace Project.Mapping;

public static class CategoryMapping
{
    public static CategoryDto ToDto(this CategoryEntity category){
        return new CategoryDto(category.Id, category.Name);

    }

}
