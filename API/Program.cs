using Application.DTOs;
using Application.Interfaces;
using Application.IRepositories;
using Application.Repositories;
using Domain;
using HotelListing.Core.Repository;
using Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Presistance;
using System.Data;
using System.Security.Principal;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));
builder.Services.AddControllers(opt =>
{
    //To authorize our endpoints
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    opt.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddAutoMapper(typeof(Program));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddOptions();
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(_IGenericRepository<>), typeof(_GenericRepository<>));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IJWTGenerator, JWTGenerator>();


var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:key"]));
builder.Services.AddAuthentication(t =>
{
    t.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    t.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(opt =>
    {
        opt.RequireHttpsMetadata= false;
        opt.SaveToken = false;
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = key,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            ValidAudience = builder.Configuration["JWT:Audience"],
            
        };
    });

builder.Services.AddIdentity<Users, IdentityRole>()
        .AddEntityFrameworkStores<DataContext>()
        .AddSignInManager<SignInManager<Users>>();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    builder.Services.AddHttpContextAccessor();
    builder.Services.AddTransient<IPrincipal>(provider => provider.GetService<IHttpContextAccessor>().HttpContext.User);

});

builder.Services.AddScoped<IUserAccessor, UserAccessor>();
builder.Services.AddScoped<DbInitializer>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

DbInitializer.SeedData(app).Wait();

app.Run();
