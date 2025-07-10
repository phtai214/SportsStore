using Microsoft.AspNetCore.Identity; using Microsoft.AspNetCore.Identity.EntityFrameworkCore; using Microsoft.EntityFrameworkCore; namespace SportsStore.Models { public class AppIdentityDbContext : IdentityDbContext<IdentityUser> { public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { } } }


Bước 2.3: Cấu hình chuỗi kết nối trong appsettings.json

{ "Logging": { "LogLevel": { "Default": "Information", "Microsoft.AspNetCore": "Warning" } }, "AllowedHosts": "*", "ConnectionStrings": { "SportsStoreConnection": " Server=(local);Database=SportStoreDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true; ", "IdentityConnection": " Server=(local);Database=SportStoreDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true; "} }