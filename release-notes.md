[← back to readme](README.md)

# Release notes
## 1.1.2
Released 05 November 2024.

* Updated for SMAPI 4.1.4.

## 1.1.1
Released 20 August 2024.

* Updated for Stardew Valley 1.6.9 and SMAPI 4.1.0.

## 1.1.0
Released 08 April 2024.

* You can now omit data fields which match their default value by calling `StardewXnbHack.exe --clean`.
* Updated for SMAPI 4.0.6.
* Fixed StardewXnbHack version shown in the console including a Git commit SHA in recent versions.

## 1.0.8
Released 19 March 2024.

* Updated for Stardew Valley 1.6.
* Added StardewXnbHack & game versions to console output.
* Data model properties marked with `[ContentSerializerIgnore]` are now omitted from output `.json` files.

## 1.0.7
Released 28 December 2021.

* Fixed exported `.tmx` files no longer indented.

## 1.0.6
Released 04 December 2021.

* StardewXnbHack no longer needs .NET to be installed.
* Updated to .NET 6.
* Fixed launch errors on macOS and Windows.

## 1.0.5
Released 15 September 2021.

* Updated for Stardew Valley 1.5.5 and .NET 5.
* Fixed some textures not unpacked correctly on Linux/macOS.
* Fixed _cannot be loaded into a Reach GraphicsDevice_ error for some users.

## 1.0.4
Released 23 March 2021.

* Added a descriptive error if you install the wrong version (e.g. the Windows version on macOS).
* Updated for SMAPI 3.9.5 (thanks to nyrdosh!).

## 1.0.3
Released 21 December 2020.

* Updated for Stardew Valley 1.5.

## 1.0.2
Released 07 December 2020.

* Assets on macOS are now unpacked into the game folder instead of resources, for consistency with other platforms.
* Improved error if the game's content folder is missing.
* Fixed duplicate tile index properties in some cases.
* Fixed unpack error on macOS with Steam.

## 1.0.1
Released 21 November 2020.

* Fixed `.tmx` map files losing tile index properties.

## 1.0
Released 04 October 2020.

* Added compiled release.
* Added icon/mascot (thanks to ParadigmNomad!).
* Added support for running it from the game folder or another app.
* Added file count and unpack time to log.
* Improved compatibility on Linux/macOS.
* Changed map format from `.tbin` to `.tmx` (thanks to Platonymous!).
* Fixed unsupported XNB files not always copied into the export folder.
* Fixed BMFont file extension set to `.xml` instead of `.fnt` (thanks to Platonymous!).

## Prerelease
Includes changes between 16 June 2019 and 25 April 2020, which didn't have packaged releases.

* Initial implementation with support for...
  * unpacking data (`.json`);
  * unpacking maps (`.tbin`);
  * unpacking textures (`.png`);
  * unpacking SpriteFont (`.png` and `.json`), and BMFont (`.png` and `.xml`) font files.
  * Linux/macOS/Windows.
* Fixed macOS build error (thanks to strobel1ght!).
