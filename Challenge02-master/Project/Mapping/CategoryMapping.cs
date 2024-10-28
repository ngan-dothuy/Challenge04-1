using System;
using Project.Dtos;
using Project.Entities;

namespace Project.Mapping;

public static class CategoryMapping
{
    public static CategoryDto ToDto(this CategoryEntity category){
        return new CategoryDto(category.Id, category.Name);

    }

}
