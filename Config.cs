using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace mono_chat_client
{
  internal class Config
  {
    private static readonly Lazy<Config> lazy = new(() => new Config());

    public static Config Instance => lazy.Value;

    private IConfigurationRoot Configuration { get; set; }

    public Settings AppSettings { get; private set; }

    private Config()
    {
      var configBuilder = new ConfigurationBuilder();
      string settingsFilePath = "settings.json";

      EnsureSettingsFileExists(settingsFilePath);

      configBuilder.AddJsonFile(settingsFilePath, optional: false, reloadOnChange: true);
      Configuration = configBuilder.Build();

      AppSettings = new Settings();
      Configuration.Bind(AppSettings);
    }

    private static void EnsureSettingsFileExists(string filePath)
    {
      if (!File.Exists(filePath))
      {
        try
        {
          var defaultSettings = new
          {
            NickName = "Ricardo",
            RoomName = "The Lobby",
            Server = "dir.irc7.com"
          };

          string json = JsonSerializer.Serialize(defaultSettings, new JsonSerializerOptions { WriteIndented = true });
          File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error creating settings file: {ex.Message}");
        }
      }
    }
  }
}
