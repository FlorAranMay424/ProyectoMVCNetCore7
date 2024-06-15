using BlazorComponentUtilities;
using BlazorStrap;
using EstudioContableC5B.Client.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Org.BouncyCastle.Asn1.Microsoft;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Transactions;
using Microsoft.Extensions.Configuration;
using System.Collections;
using MimeKit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Configuration.Internal;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

await builder.Build().RunAsync();


builder.Services.AddBootstrapCss();

//public Startup(IConfiguration configuration) {
//    Configuration = configuration;
//}

//public IConfiguration Configuration { get; }

//IServiceCollection serviceCollection = builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));


////builder.Services.AddSvgLoader();

//var configuration = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>()
//{
//    ["Somekey"] = "SomeValue"
//}
//    ).Build(); 

//public IConfiguration Configuration { get; }

//builder.Configure<SmtpSettings>(Configuration.)