using M02.ResourceFilters.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<TenantValidationFilter>();//Global Filter Registrations
});

var app = builder.Build();

app.MapControllers();

app.Run();


