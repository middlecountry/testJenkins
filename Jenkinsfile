


pipeline{
    
    agent any

    parameters{
        booleanParam(defaultValue: true , description:'Is Debug or not' , name:'Debug')
        choice(name:'AppRoot',choices:'AppRootData_local'
            +'AppRootData_hotupdate\n'
            +'AppRootData_daily\n'
            +'AppRootData_test\n'
            +'AppRootData_outside_test\n'
            +'AppRootData_stage\n'
            +'AppRootData_localoutside_test\n'
            +'AppRootData_wondertown_sandbox'
            , description:'Is Debug or not')
    }
    
    stages {
        stage('Git Pull'){
            steps{
                dir('project'){
                    checkout([$class: 'GitSCM', branches: [[name: '*/master']], 
                    doGenerateSubmoduleConfigurations: false, 
                    extensions: [], 
                    submoduleCfg: [], 
                    userRemoteConfigs: [[credentialsId: 'github_w', url: 'git@github.com:middlecountry/testJenkins.git']]])
                }
           }
        }
        stage('Build Apk'){
            steps{
                script{
                    echo pwd()
                    UNITY_PATH="C:\\Program Files\\Unity2018.3.14\\Editor\\Unity.exe"
                    WORKSPACE=env.WORKSPACE + "\\project\\TestBuild"
                    platform="Android" 
                    echo "projectPath:"+WORKSPACE
                    bat("\"${UNITY_PATH}\" -projectPath ${WORKSPACE} -quit -batchmode -buildTarget ${platform} -silent-crashes -executeMethod ProjectBuild.BuildForAndroid -logFile build_log.txt")

                }
           }
        }
        
    }
    
}


