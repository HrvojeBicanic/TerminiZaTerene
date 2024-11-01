﻿using Microsoft.EntityFrameworkCore;
using TerminiZaTerene.Data;
using TerminiZaTerene.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dodavanje baze podataka
builder.Services.AddDbContext<BazaTermina>(opcije =>
{

    opcije.UseSqlServer(builder.Configuration.GetConnectionString("Baza"));
});

// Svi se od svuda na sve moguæe naèine mogu spojitina naš API
// Čitati https://code-maze.com/aspnetcore-webapi-best-practices/
builder.Services.AddCors(opcije =>
{
    opcije.AddPolicy("CorsPolicy",
        builder =>
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    );

});

// automapper
builder.Services.AddAutoMapper(typeof(TerminiZaTereneMappingProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwagger();
    app.UseSwaggerUI(o => {

        o.ConfigObject.AdditionalItems.Add("requestSnippetsEnabled", true);
        o.EnableTryItOutByDefault();

    });
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// za potrebe produkcije
app.UseStaticFiles();
app.UseDefaultFiles();
app.MapFallbackToFile("index.html");

app.UseCors("CorsPolicy");

app.Run();
