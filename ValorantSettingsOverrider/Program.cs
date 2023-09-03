var appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
var valorantFolder = Path.Combine(appData, "Valorant", "Saved", "Config");
var dir = new DirectoryInfo(valorantFolder);
if (dir.Exists) Console.WriteLine($"Config folder exists at: {valorantFolder}");
var userFolders = dir.GetDirectories();
var i = 0;
foreach (var folder in userFolders)
{
    var userConfigFolder = new DirectoryInfo(Path.Combine(folder.FullName, "Windows"));
    if (userConfigFolder.Exists)
    {
        i++;
        var configFile = new FileInfo(Path.Combine(userConfigFolder.FullName, "GameUserSettings.ini"));
        if (configFile.Exists)
        {
            var text = File.ReadLines(configFile.FullName);
            var newText = string.Empty;
            foreach (var line in text)
                if (line.StartsWith("sg.") && !line.Contains("sg.ResolutionQuality"))
                {
                    var equalsIndex = line.IndexOf('=');
                    if (equalsIndex != -1)
                    {
                        var newLine = line.Remove(equalsIndex, line.Length - equalsIndex);
                        newLine += "=0";
                        newText += newLine + Environment.NewLine;
                    }
                }
                else
                {
                    newText += line + Environment.NewLine;
                }

            File.WriteAllText(configFile.FullName, newText);
        }
    }
}

Console.WriteLine($"Overwrote config files for {i} accounts");
Console.WriteLine("Done!");
Console.WriteLine("Press any key to exit");
Console.ReadKey();