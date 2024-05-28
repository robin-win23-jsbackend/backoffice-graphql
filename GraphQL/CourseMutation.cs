using Backoffice.Models;
using Backoffice;
using Microsoft.EntityFrameworkCore;

public class Mutation
{
    [UseDbContext(typeof(AppDbContext))]
    public async Task<Courses> CreateCourseAsync(
        CreateCourseInput input,
        [Service(ServiceKind.Resolver)] IDbContextFactory<AppDbContext> contextFactory)
    {
        var context = contextFactory.CreateDbContext();
        var course = new Courses
        {
            Title = input.Title,
            Ingress = input.Ingress,
            Price = input.Price,
            Hours = input.Hours,
            ImageUrl = input.ImageUrl
        };

        context.Courses.Add(course);
        await context.SaveChangesAsync();
        return course;
    }
}
