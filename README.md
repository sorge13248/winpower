# WinPower
Tired of pressing restart instead of shutdown in Windows 10 Start menu and having to wait for your PC to reboot?
WinPower aims to solve this issue by providing a very simple yet powerful utility to shutdown, restart or hibernate your Windows computer.

## Features
 - A single place where to shutdown, restart or hibernate your system
 - Wait for some seconds before shutting down, reboot or hibernate
 - Cancel operation
 - Advanced Restart (only for Windows 8, 8.1 and 10)
 - Choose a default option to pre-select when opening WinPower
 
![Main window](https://static.francescosorge.com/file/francesco-sorge/2020-02/software/winpower/screen-1.png)
![Settings](https://static.francescosorge.com/file/francesco-sorge/2020-02/software/winpower/screen-2.png)

## Download
You can download WinPower from 'Release' tab here on GitHub or at my website: https://www.francescosorge.com/fwlink/winpower

## Hide power button in Start Menu (advanced)
If you want to be sure you will no longer be using Windows owns power off options, you may want to hide them from Start menu.

N.B.: You should be doing this operation only if you're familiar with Windows Registry Editor.

- Hide restart: Navigate to 'Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Start\HideRestart' and set 'value' to 1

- Hide shutdown: Navigate to 'Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Start\HideShutDown' and set 'value' to 1

- Hide sleep: Navigate to 'Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Start\HideSleep' and set 'value' to 1

- Hide hidernate: Navigate to 'Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Start\HideHibernate' and set 'value' to 1
