# ValorantForceLowSettings
Forces Valorant to low settings in the config files for all accounts on the computer

## How it works
When you set the ingame settings for Valorant, it saves these in a `GameUserSettings.ini` file for each of your accounts. This file allow you to further reduce the quality beyond "Low" ingame by setting the fields manually in the file to 0.

### Doing it manually
The program automates the following:

1. Press Windows + R and type %localappdata% and press OK
2. Access the Valorant folder
3. Access the Saved folder
4. Access the Config folder
5. For each UUID in there (This is your account folders) access the Windows folder
6. Update the `GameUserSettings.ini` file to the following:
```
sg.ViewDistanceQuality=0
sg.AntiAliasingQuality=0
sg.ShadowQuality=0
sg.PostProcessQuality=0
sg.TextureQuality=0
sg.EffectsQuality=0
sg.FoliageQuality=0
sg.ShadingQuality=0
```
7. Save the file

## Download
Build it from source yourself (You need the .NET6 SDK) or download from the release section.