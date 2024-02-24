using GetTutorsOnline.Components;
using GTO.IModels.IModelRepos;
using GTO.Infrastructure.Data;
using GTO.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<GTODbContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("SimpleBookCatalogConnection"));
    options.UseSqlite(builder.Configuration.GetConnectionString("GTODbSqLiteConnection"));
    //options.UseSqlServer(builder.Configuration.GetConnectionString("DifriPediaSQLDb"));
});

builder.Services.AddScoped<ISubjectNameRepo, SubjectNameRepo>();
builder.Services.AddScoped<IRegionRepo, RegionRepo>();
builder.Services.AddScoped<IAssessmentMonthRepo, AssessmentMonthRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
