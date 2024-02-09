using FluentValidation;
using FluentValidation.AspNetCore;
using Validators;
using Validators.Validators;

var builder = WebApplication.CreateBuilder(args);



// Register Our Fluentvalidation Service
builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<RegisterValidates>());

// Add services to the container.
builder.Services.AddTransient<IValidator<RegisterClass2>, RegisterValidates>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(); 
