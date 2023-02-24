@echo off
cls
cd FWAiO
dotnet publish --self-contained -p:PublishSingleFile=true -c Release
pause