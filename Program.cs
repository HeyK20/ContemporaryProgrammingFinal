using ContemporaryProgrammingFinal.Data;
using ContemporaryProgrammingFinal.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerDocument();

builder.Services.AddDbContext<TeamInfoContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("TeamMembersContext")));
builder.Services.AddScoped<ITeamMembersContextDAO, TeamMembersContextDAO>();
builder.Services.AddScoped<IBreakfastDAO, BreakfastContextDAO>();
//builder.Services.AddDbContext<BreakfastInfoContext>(options =>
//        options.UseSqlServer(builder.Configuration.GetConnectionString("TeamMembersContext")));
//builder.Services.AddScoped<IBreakfastDAO, BreakfastContextDAO>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<TeamInfoContext>();
    db.Database.Migrate();

    //var db2 = scope.ServiceProvider.GetRequiredService<BreakfastInfoContext>();
    //db2.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseOpenApi();
app.UseSwaggerUi3();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
