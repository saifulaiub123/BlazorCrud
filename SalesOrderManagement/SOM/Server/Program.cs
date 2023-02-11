using Microsoft.EntityFrameworkCore;
using SOM.Core.Constant;
using SOM.DAL.DBContext;
using System.Text.Json.Serialization;
using System.Text.Json;
using FluentValidation.AspNetCore;
using System.Reflection;
using SOM.Bll.Dependency;
using SOM.DAL.Dependency;
using SOM.Core.Mapping;

IConfiguration Configuration;

var builder = WebApplication.CreateBuilder(args);

Configuration = builder.Configuration;


builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString(ConfigOption.DbConnName),
                            options => options.EnableRetryOnFailure())
                );
builder.Services.AddControllersWithViews()
                .AddJsonOptions(opt =>
                {
                    opt.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                })
                .AddFluentValidation(opt =>
                {
                    // Validate child properties and root collection elements
                    opt.ImplicitlyValidateChildProperties = false;
                    opt.ImplicitlyValidateRootCollectionElements = false;

                    // Automatic registration of validators in assembly
                    opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                });
builder.Services.AddAutoMapper(typeof(ElementMapping).Assembly);
builder.Services.AddServices();
builder.Services.AddRepositories();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sales Order Management");
});
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
