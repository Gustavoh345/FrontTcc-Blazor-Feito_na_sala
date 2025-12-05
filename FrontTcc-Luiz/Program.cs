using FrontTcc_Luiz;
using FrontTcc_Luiz.Services;
using FrontTcc_Luiz.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FrontTcc_Luiz.ViewModels;
using FrontTcc_Luiz.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<ProdutoService>();    
builder.Services.AddScoped<ProdutosViewModel>();   


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
