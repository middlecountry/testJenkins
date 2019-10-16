pipeline{
    
    agent any
    
    stages {
        stage('Build'){
            steps{
                echo 'writeFile'
                writeFile file:'test.txt' , text:'Hello world !'
            }
        }
    }
    
} 