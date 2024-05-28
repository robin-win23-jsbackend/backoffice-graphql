using Backoffice.Models;

public class CourseType : ObjectType<Courses>
{
    protected override void Configure(IObjectTypeDescriptor<Courses> descriptor)
    {
        descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
        descriptor.Field(x => x.Title).Type<NonNullType<StringType>>();
        descriptor.Field(x => x.Ingress).Type<NonNullType<StringType>>();
        descriptor.Field(x => x.Price).Type<NonNullType<DecimalType>>();
        descriptor.Field(x => x.Hours).Type<NonNullType<IntType>>();
        descriptor.Field(x => x.ImageUrl).Type<StringType>();
    }
}
