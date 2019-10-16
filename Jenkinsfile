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
                writeFile file:'test.txt' , text:'Hello world !!'
            }
        }
        stage('Read File'){
            steps{
                fileContent = readFile file: "test.txt"
                echo fileContent
            }
        }
    }
    
} 