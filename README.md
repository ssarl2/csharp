# Landing C#!
## On going
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/program-building-blocks
- Methods
## Testing environment
- Ubuntu 22.04
- VSCode 1.81.1
  - C# extension 2.0.376
- dotnet-sdk-7.0
## Install C#
### C# SDK
```
sudo rm /etc/apt/sources.list.d/microsoft-prod.list
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-7.0
```
### VSCode C# extension
`code --install-extension ms-dotnettools.csharp@2.0.376`

## Run
`dotnet run`

## References
- https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0
- https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-2204

### Trouble shootings
- https://stackoverflow.com/questions/73312785/dotnet-sdk-is-installed-but-not-recognized-linux-ubuntu-popos-22-04
- https://github.com/dotnet/vscode-csharp/issues/6218