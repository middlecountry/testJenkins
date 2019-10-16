

@echo off
 
set IsDevAuth = "true"
set BuildVersion = "0.2.3"
set BundleVersionCode = 0
set UNITY_LOG_PATH=%cd%\unity_log.txt
set UNITY_PATH="C:\Program Files\Unity2018.3.14\Editor\Unity.exe"
set PROJECT_PATH="D:\workspace\testJenkins\TestBuild"
echo lunch unity.exe ,please wait a moment...
 

%UNITY_PATH% -quit -batchmode -executeMethod ProjectBuild.BuildForAndroid -projectPath %PROJECT_PATH% -logFile build_log.txt


echo "Build apk done"
pause