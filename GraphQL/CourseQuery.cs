using HotChocolate;
using HotChocolate.Data;
using Backoffice.Models;
using Microsoft.EntityFrameworkCore;
using Backoffice;

public class Query
{
    [UseDbContext(typeof(AppDbContext))]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Courses> GetCourses([Service(ServiceKind.Resolver)] IDbContextFactory<AppDbContext> contextFactory)
    {
        var context = contextFactory.CreateDbContext();
        return context.Courses;
    }
}
