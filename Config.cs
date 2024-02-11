using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mono_chat_client
{
  internal class Config
  {
    private static readonly Lazy<Config> lazy = new Lazy<Config>(() => new Config());

    public static Config Instance { get { return lazy.Value; } }

    private Config()
    {
      ConfigurationBuilder configBuilder = new ConfigurationBuilder();
      configBuilder.AddJsonFile("settings.json", true, true);
    }
  }
}
