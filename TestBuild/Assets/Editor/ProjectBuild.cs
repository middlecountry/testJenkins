﻿using System.Collections;
using System.IO;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEditor.Build.Reporting;

class ProjectBuild : Editor{
 
    //在这里找出你当前工程所有的场景文件，假设你只想把部分的scene文件打包 那么这里可以写你的条件判断 总之返回一个字符串数组。
    static string[] GetBuildScenes()
    {
        List<string> names = new List<string>();
        foreach(EditorBuildSettingsScene e in EditorBuildSettings.scenes)
        {
            if(e==null)
                continue;
            if(e.enabled)
                names.Add(e.path);
        }
        return names.ToArray();
    }
 
    [MenuItem("Build/android")]
    static void BuildForAndroid()
    {
        //Function.DeleteFolder(Application.dataPath+"/Plugins/Android");
 
//        if(Function.projectName == "91")
//        {
//            Function.CopyDirectory(Application.dataPath+"/91",Application.dataPath+"/Plugins/Android");
//            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "USE_SHARE");+
//        }
        string path = Application.dataPath + '/' + Function.projectName+".apk";
        path = path.Replace("Assets", "Build");
        BuildReport result = BuildPipeline.BuildPlayer(GetBuildScenes(), path, BuildTarget.Android, BuildOptions.None);
        
        switch (result.summary.result)
        {
            case BuildResult.Succeeded:
            {
                Debug.Log(result.summary.outputPath);
                Debug.Log("project build - Build project succeed! " + result.summary.result.ToString());
                break;
            }
            default:
            {
                throw new Exception("Build project failure! result = " + result.summary.result.ToString());
            }
        }
        
    }
}