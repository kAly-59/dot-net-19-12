﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PizzAPI.Datas;
using PizzAPI.Helpers;
using PizzAPI.Repositories;
using PizzCore.Models;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;

namespace PizzAPI.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void InjectDependancies(this WebApplicationBuilder builder)
        {
            // ajouter .AddJsonOptions(...) pour éviter les cycles/la redondance (un ingrédient qui a sa pizza dans le json qui a elle même son ingrédient
            builder.Services.AddControllers().AddJsonOptions(x =>
                            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            builder.AddSwagger();

            builder.AddDatabase();

            builder.AddRepositories();

            builder.AddAuthentication();

            builder.AddAuthorization();
        }

        private static void AddSwagger(this WebApplicationBuilder builder)
        {

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzApi", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Name = "Authorization",
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    Type = SecuritySchemeType.Http
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                    {
                        new OpenApiSecurityScheme
                        {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                        },
                        new string[] { }
                    }
                });
            });
        }

        private static void AddDatabase(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }

        private static void AddRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepository<User>, UserRepository>();
            builder.Services.AddScoped<IRepository<Pizza>, PizzaRepository>();
            builder.Services.AddScoped<IRepository<Ingredient>, IngredientRepository>();
        }

        private static void AddAuthentication(this WebApplicationBuilder builder)
        {
            var appSettingsSection = builder.Configuration.GetSection(nameof(AppSettings));
            builder.Services.Configure<AppSettings>(appSettingsSection); // service IOptions<Appsettings>
            AppSettings appSettings = appSettingsSection.Get<AppSettings>();

            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey!);

            // Authentication
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true, // utilisation d'une clé cryptée pour la sécurité du token
                        IssuerSigningKey = new SymmetricSecurityKey(key), // clé cryptée en elle même
                        ValidateLifetime = true, // vérification du temps d'expiration du Token
                        ValidateAudience = true, // vérification de l'audience du token
                        ValidAudience = appSettings.ValidAudience, // l'audience
                        ValidateIssuer = true, // vérification du donneur du token
                        ValidIssuer = appSettings.ValidIssuer, // le donneur
                        ClockSkew = TimeSpan.Zero // décallage possible de l'expiration du token
                    };
                });
        }

        private static void AddAuthorization(this WebApplicationBuilder builder)
        {
            builder.Services.AddAuthorization(options =>
            {
                // les policy ne sont pas obligatoires
                // elle permettent d'élaborer des stratégies plus complexe pour l'authorization
                // pour cette application les rôles suffisent

                options.AddPolicy(Constants.PolicyAdmin, police =>
                {
                    police.RequireClaim(ClaimTypes.Role, Constants.RoleAdmin);
                });
                options.AddPolicy(Constants.PolicyUser, police =>
                {
                    police.RequireClaim(ClaimTypes.Role, Constants.RoleUser);
                });
            });
        }
    }
}
