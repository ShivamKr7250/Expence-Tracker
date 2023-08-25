using Expence_Tracker.Models;
using Microsoft.EntityFrameworkCore;

// JAI SHREE RAM 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Syncfusion Licence
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRcQlVhTH5ack1jUHZdeXE=;Mgo+DSMBPh8sVXJ1S0d+X1RPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXZRc0VqXXdeeX1QRWU=;ORg4AjUWIQA/Gnt2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5bdEBjUHtWcH1cQGZZ;MjY2MzQ1M0AzMjMxMmUzMTJlMzMzNVJpa1RhcFRLSzJ5RElUQVJaOEtxUTV6UjVVSVlkRGYvL1NvRkNKZ1Z2aUU9;MjY2MzQ1NEAzMjMxMmUzMTJlMzMzNWhBdlRVM3dtWlJvM2xNZzNZbE9mOVN5cm9zQnhLNFJYYTEwOGl6b25HUE09;NRAiBiAaIQQuGjN/V0d+XU9Hc1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TfkdmWXZaeHVVRmRcVA==;MjY2MzQ1NkAzMjMxMmUzMTJlMzMzNUtEVnFtVUN3Tkh6b0djenV2WHVKQ3JVTkY5eVgzckZkSjYveHZVVXR3VDg9;MjY2MzQ1N0AzMjMxMmUzMTJlMzMzNWhvamZ0UnpxMEVpTWd0VXdGbjdQcE1CTFhqVEg4R0xVTDVYWmZxYlZkUzg9;Mgo+DSMBMAY9C3t2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5bdEBjUHtWcXRUQmVZ;MjY2MzQ1OUAzMjMxMmUzMTJlMzMzNWp0cEZMbWp5Zm5qUEgvQ2pCaHN2R2U4cFRhU1NNTS81cElPWFVuOGRTSGc9;MjY2MzQ2MEAzMjMxMmUzMTJlMzMzNVBsN3BOYlhBRTQ2eUtvRG9YT3llV00xQ2FTTy84UjRtaEV2K2hiMFBvV0E9;MjY2MzQ2MUAzMjMxMmUzMTJlMzMzNUtEVnFtVUN3Tkh6b0djenV2WHVKQ3JVTkY5eVgzckZkSjYveHZVVXR3VDg9");

//Dependencies Injection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
