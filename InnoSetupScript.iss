; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "汽车租赁管理系统"
#define MyAppVersion "1.0"
#define MyAppPublisher "通辽市科区公安局"
#define MyAppURL "http://www.keerqin.gov.cn/weibanju/keqgongan/"
#define MyAppExeName "CarRentalLoader.exe"
#define IsExternal ""
#define FrameworkFileName "dotNetFx40_Full_x86_x64.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{C287F022-D62D-4E5B-8C0F-CCDE57DE7F73}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
OutputBaseFilename=Setup
Compression=lzma
SolidCompression=yes
Uninstallable=noDefaultDirName={pf}\汽车租赁管理系统


[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "C:\Windows\Fonts\msyh.ttf"; DestDir: "{fonts}"; FontInstall: "微软雅黑"; Flags: onlyifdoesntexist uninsneveruninstall     
Source: "D:\WorkSpace\CarRental\lib\CarRentalLoader.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\CarRental.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\CarRentalLibrary.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\LumiSoft.Net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\DevExpress.XtraWizard.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\DevExpress.XtraLayout.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\DevExpress.XtraEditors.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\DevExpress.XtraBars.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion      
Source: "D:\WorkSpace\CarRental\lib\DevExpress.XtraGrid.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion  
Source: "D:\WorkSpace\CarRental\lib\DevExpress.XtraPrinting.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion  
Source: "D:\WorkSpace\CarRental\lib\DevExpress.XtraTreeList.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion  
Source: "D:\WorkSpace\CarRental\lib\DevExpress.Utils.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\DevExpress.Data.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\CarRental\lib\DevExpress.BonusSkins.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion    
Source: "D:\WorkSpace\CarRental\lib\DevExpress.Printing.v12.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion   
Source: "D:\WorkSpace\CarRental\lib\Db.mdb"; DestDir: "{app}"; Flags: onlyifdoesntexist
Source: "D:\WorkSpace\CarRental\FrameWorkInstallPrepare.bat"; DestDir: "{tmp}"; Flags: ignoreversion {#IsExternal}; Check: NF
Source: "E:\Software\Coding\{#FrameworkFileName}"; DestDir: "{tmp}"; Flags: ignoreversion {#IsExternal}; Check: NF
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Run]
Filename: {tmp}\FrameWorkInstallPrepare.bat; WorkingDir: {tmp}; Flags: skipifdoesntexist; StatusMsg: "正在准备安装..."
Filename: {tmp}\{#FrameworkFileName}; Parameters: "/q:a /c:""install /l /q /norestart /ChainingPackage FullX64Bootstrapper"""; WorkingDir: {tmp}; Flags: skipifdoesntexist; StatusMsg: "正在安装.Net FrameWork，这通常需要一些时间，请耐心等待..."
Filename: {win}\Microsoft.NET\Framework\v4.0.30319\CasPol.exe; Parameters: "-q -machine -remgroup ""{#MyAppName}"""; WorkingDir: {tmp}; Flags: skipifdoesntexist runhidden; StatusMsg: "正在配置..."
Filename: {win}\Microsoft.NET\Framework\v4.0.30319\CasPol.exe; Parameters: "-q -machine -addgroup 1.2 -url ""file://{app}/*"" FullTrust -name ""{#MyAppName}"""; WorkingDir: {tmp}; Flags: skipifdoesntexist runhidden; StatusMsg: "正在配置..."       
Filename: {app}\CarRentalLoader.exe; Description: "运行汽车租赁管理系统"; Flags: postinstall

[Tasks]
; 注意: 这下面程序自动生成的中文字符 "在桌面上创建图标" 和 "添加图标" 。如果有需要的话，你可以将其翻译为任意一种语言。                           
Name: "desktopicon"; Description: "在桌面上创建图标(&D)"; GroupDescription: "添加图标："         

[Icons] 
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\CarRentalLoader.exe"; Tasks:desktopicon ; WorkingDir: "{app}" 

[Code]

//检查是否需要安装.Net Framework。返回True或False。
function NF(): boolean;
var
  success: boolean;
  install: cardinal;
begin
  success := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Install', install);
  Result := (success and (install = 1) = false);
end;

//略过欢迎界面。
function ShouldSkipPage(PageID: Integer): Boolean;  
begin  
  if PageID=wpWelcome then  
    Result := true;  
  if PageID=wpSelectProgramGroup then
    Result := true;
end;