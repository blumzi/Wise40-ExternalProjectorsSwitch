; -- setup.iss --
[Setup]
AppName=Wise-Projectors
AppVersion=1.0
DefaultDirName={commonpf}\Wise-Projectors
DefaultGroupName=Wise-Projectors
OutputBaseFilename=Wise-Projectors-Installer
Compression=lzma
SolidCompression=yes
SetupIconFile=onoff.ico

[Files]
Source: "C:\Users\User\source\repos\ExternalProjectorsSwitch\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\User\source\repos\ExternalProjectorsSwitch\installer\onoff.ico"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\Wise-Projectors"; Filename: "{app}\ExternalProjectorsSwitch.exe"; IconFilename: "{app}\onoff.ico"; Tasks: desktopicon
Name: "{commondesktop}\Wise-Projectors"; Filename: "{app}\ExternalProjectorsSwitch.exe"; IconFilename: "{app}\onoff.ico"; Tasks: desktopicon
Name: "{group}\Uninstall Wise-Projectors"; Filename: "{uninstallexe}"

[Tasks]
Name: "desktopicon"; Description: "Create a &desktop shortcut"; GroupDescription: "Additional icons:"
