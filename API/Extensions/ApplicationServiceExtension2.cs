using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions;
public static class ApplicationServiceExtension2
{
    public static void ConfigureCors(this IServiceCollection services)=>
    services.AddCors(options=>
        options.AddPolicy("CorsPolicy",builder=>
        {
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        })
    );
}
