using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using UserService;
using UserService.Context;
using UserService.Services;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddAuthorization();
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = AuthOptions.ISSUER,
        ValidAudience = AuthOptions.AUDIENCE,
        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey()
    };
});
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
// Configure the HTTP request pipeline.
app.MapGrpcService<UserApiService>();

app.Run();