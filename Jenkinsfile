pipeline {
    agent any
    triggers {
        pollSCM '* * * * *'
    }
    stages {
        stage('Git checkOut') {
            steps {
                git branch: 'main', url: 'https://github.com/MahbubAhmedTonmoy/jenkins-Learn-Dotnet-core-app.git'
            }
        }
        stage('Restore packages') {
            steps {
                bat "dotnet restore"
            }
        }

        stage('Clean') {
            steps {
                 bat "dotnet clean"
            }
        }
        stage('Build') {
            steps {
                bat "dotnet build"
            }
        }
        stage('Run'){
            steps{
            bat "dotnet run"
            }
        }
        stage('Create Docker Image'){
            steps {
                bat "docker build -t consoleapp:${env.BUILD_ID} -f Dockerfile ."
            }
        }
        stage('Run Docker Image'){
            steps {
                bat "docker run consoleapp:${env.BUILD_ID}"
            }
        }
    }
}