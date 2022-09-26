using FilterDemoApp;

var builder = WebApplication.CreateBuilder(args) ;

// Add services to the container.

builder.Services.AddControllers(options =>
{
    //This is a Global level Filter to get for each controller we ahve to use controller level filter in the controller class.

    //options.Filters.Add(new MyActionFilterAttribute());          
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
