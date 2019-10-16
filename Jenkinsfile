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
        stage('Dir'){
            steps{
                script {
                    dir('bbb'){
                        echo pwd()
                        bat('echo bat')
                    }
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
        stage('deleteDir'){
            steps{
                script {
                    echo env.WORKSPACE
                    //deleteDir()
                }
            }
        }
    }
    
} 