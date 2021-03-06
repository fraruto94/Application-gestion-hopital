; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "hopitaljacquesdumont"
#define MyAppVersion "1.5"
#define MyAppPublisher "peyo ngono tchuati"
#define MyAppExeName "gestionHopital.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{89A5148A-351A-420F-BB03-EA665C9FBB87}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=E:\Nouveau dossier (2)
OutputBaseFilename=hjdsetup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Frank Basso\Documents\Visual Studio 2013\Projects\gestionHopital\gestionHopital\bin\Debug\gestionHopital.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Frank Basso\Documents\Visual Studio 2013\Projects\gestionHopital\az.iss"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Frank Basso\Documents\Visual Studio 2013\Projects\gestionHopital\gestionHopital.sln"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Frank Basso\Documents\Visual Studio 2013\Projects\gestionHopital\gestionHopital.v12.suo"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Frank Basso\Documents\Visual Studio 2013\Projects\gestionHopital\localhost.sql.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Frank Basso\Documents\Visual Studio 2013\Projects\gestionHopital\op.iss"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

