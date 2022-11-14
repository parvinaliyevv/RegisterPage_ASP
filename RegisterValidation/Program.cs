var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<UserValidator>());

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Register}/{Action=SignUp}/{id?}"
);

app.Run();
