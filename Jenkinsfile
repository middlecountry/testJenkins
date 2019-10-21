


pipeline{
    
    agent any
    
    stages {
        stage('Build Start'){
            steps{
                echo 'Build Start'
            }
        }

        stage('Write File'){
            steps{
                writeFile file:'test.txt' , text:'Hello world !!!', encoding: "UTF-8"
            }
        }

        stage('isUnix'){
            steps{
                script {
                    isu = isUnix()
                    echo "isUnix:" + isu
                }
            }
        }
        stage('Pwd'){
            steps{
                echo pwd()
            }
        }
        stage('FileExists'){
            steps{
                script {
                    exist = fileExists file:'test.txt'
                    echo 'exist : test.txt  ' + exist
                    exist = fileExists file:'test1.txt'
                    echo 'exist : test1.txt  ' + exist
                }
            }
        }
        stage('Read File'){
            steps{
                //echo readFile file:'test.txt', encoding: "UTF-8"
                script {
                    fileContent = readFile file:'test.txt', encoding: "UTF-8"
                    echo message: fileContent
                }
            }
        }
        // stage('Git Pull'){
        //     steps{
        //         dir('project'){
        //             echo pwd()
        //             //git credentialsId: 'github_w', url: 'git@github.com:middlecountry/testJenkins.git'
        //             checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: 'github_w', url: 'git@github.com:middlecountry/testJenkins.git']]])
        //         }
        //    }
        // }
        stage('Build'){
            steps{
                script{
                    echo pwd()
                    UNITY_PATH="C:\\Program Files\\Unity2018.3.14\\Editor\\Unity.exe"
                    WORKSPACE=env.WORKSPACE + "\\project\\TestBuild"
                    bat("\"${UNITY_PATH}\" -quit -batchmode -executeMethod ProjectBuild.BuildForAndroid -projectPath \"${WORKSPACE}\" -logFile build_log.txt")
                }
            }
        }
        // stage('Build1'){
        //     steps{
        //         script {
        //             echo pwd()
        //             exist = fileExists file:'project/TestBuild/Build.bat'
        //             if(!exist)
        //             {
        //                 error message: pwd() + 'project/TestBuild/Build.bat' + " 不存在"
        //             }
        //             batContent = readFile file:'project/TestBuild/Build.bat', encoding: "UTF-8"
        //             echo message: batContent
        //             bat(batContent)
        //         }
        //     }
        // }
    }
    
}


