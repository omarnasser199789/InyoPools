using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using InyoPools.Core.Domain.Model.Authentication;

using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using System.Text.Json;
using InyoPoolsRest.API.Application.Aithentication;
using InyoPoolsRest.API.Application.ProductCategories;
using InyoPoolsRest.API.Application.TestCategories;
using InyoPoolsRest.API.Application.Manufacturers;
using InyoPoolsRest.API.Application.EmailLogs;
using InyoPoolsRest.API.Application.Customers;
using InyoPoolsRest.API.Application.EmailTypes;

var builder = WebApplication.CreateBuilder(args);

//For Entity Framework
var configuration = builder.Configuration;
builder.Services.AddDbContext<InyoPoolsDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("InyoPoolsWebTestDbContextConnection")));

//For Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<InyoPoolsDbContext>()
    .AddDefaultTokenProviders();
//Add Config for requried Email
builder.Services.Configure<IdentityOptions>(opts => opts.SignIn.RequireConfirmedEmail = true);

//Adding Authentication
builder.Services.AddAuthentication(options =>
{

    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(options => {

    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters() 
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))

    };
}
) ;

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);



//Add Email Config
var emailConfig = configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);

// EmailLog
builder.Services.AddScoped<IAddEmailLogService, AddEmailLogService>();
builder.Services.AddScoped<IGetEmailLogsService, GetEmailLogsService>();

//EmailType
builder.Services.AddScoped<IAddEmailTypeService, AddEmailTypeService>();

// Customer
builder.Services.AddScoped<IAddCustomerService, AddCustomerService>();
builder.Services.AddScoped<IGetCustomersService, GetCustomersService>();
builder.Services.AddScoped<IDeleteCustomerService, DeleteCustomerService>();



builder.Services.AddScoped<IEmailService, EmailService>();

// Category
builder.Services.AddScoped<IGetCategoryService, GetCategoryService>();
builder.Services.AddScoped<IAddCategoryService, AddCategoryservice>();
builder.Services.AddScoped<IDeleteCategoryService, DeleteCategoryService>();

// ProductCategory
builder.Services.AddScoped<IAddProductCategoryService, AddProductCategoryService>();
builder.Services.AddScoped<IGetProductCategoryService, GetProductCategoryService>();

//TestCategory
builder.Services.AddScoped<IGetTestCategoryService, GetTestCategoryService>();
builder.Services.AddScoped<IAddTestCategoryService, AddTestCategoryService>();

// Manufacturer
builder.Services.AddScoped<IAddManufacturerService, AddManufacturerService>();
builder.Services.AddScoped<IGetManufacturersService,GetManufacturersService>();
builder.Services.AddScoped<IDeleteManufacturerService, DeleteManufacturerService>();

//var connectionString = builder.Configuration.GetConnectionString("InyoPoolsWebTestDbContextConnection") ?? throw new InvalidOperationException("Connection string 'InyoPoolsWebTestDbContextConnection' not found.");
//builder.Services.AddDbContext<InyoPoolsDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();





var app = builder.Build();

//Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
