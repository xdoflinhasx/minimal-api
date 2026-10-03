var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login",(minimalapi.Dtos.LoginDTO loginDto) =>
{
    if (loginDto.Email == "adm@teste.com" &&  loginDto.senha =="123456")
        return Results.Ok("login Realizado com Sucesso");
    else
        return Results.Unauthorized();
});


app.Run();


public class LoginDTO
{
    public string Email{ get;set; }= default!;
    public string senha{ get;set; }= default!;


}
