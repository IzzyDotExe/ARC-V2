﻿using Arc;
using Arc.Schema;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Modules
{
    internal abstract class ArcModule : ApplicationCommandModule
    {

        protected readonly ArcDbContext DbContext;
        protected readonly IServiceProvider ServiceProvider;
        protected readonly DiscordClient ClientInstance;
        protected readonly IConfigurationRoot GlobalConfig;

        protected ArcModule()
        {
            DbContext = Arc.Arc.ArcDbContext;
            ServiceProvider = Arc.Arc.ServiceProvider;
            ClientInstance = Arc.Arc.ClientInstance;
            GlobalConfig = Arc.Arc.GlobalConfig;
        }
        
    }
}
