using Microsoft.AspNetCore.Components.Authorization;
using SmartWorkout;
using SmartWorkout.Components;
using SmartWorkout.DataAccess;
using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using SmartWorkout.DataAccess.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();
builder.Services.AddDbContext<SmartWorkoutContext>();
builder.Services.AddScoped<IGenericRepository<Client>, ClientRepository>();
builder.Services.AddScoped<IGenericRepository<Exercise>, ExerciseRepository>();
builder.Services.AddScoped<IGenericRepository<Workout>,WorkoutRepository>();

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddAuthenticationCore();

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
