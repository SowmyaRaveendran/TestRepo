pipeline {
    agent any
environment {
        VERSION = ''
    }
        stages {
        stage('GetInput') {
            steps {
                script {
                    
    try {
                            VERSION = input message: 'User input required',
              parameters: [string(name: 'Application version', defaultValue: '',
                                            description: 'Version of application')]

                    // Echo to console
                    echo 'Version:' + VERSION
                    
    }
    catch (Exception e) {
        echo 'Exception occurred: ' + e.toString()
    }
                }
            }
        }
        stage('PrintInput') {
            steps {
                script {
                    // Echo to console
                    echo 'Version entered by user:' + VERSION
                }
            }
        }
		stage('Parallel-stages-Test') {
		parallel {
		stage ('Parallel-Task1') {
			steps {
                script {
                //echo "TimeStamp1: ${currentBuild.startTimeInMillis}"
				echo bat(returnStdout: true, script: 'ConsoleApp1.exe')
                }
			}
			}
		stage ('Parallel-Task2') {
			steps {
			script {
                //echo "TimeStamp2: ${currentBuild.startTimeInMillis}"
				echo bat(script: 'ConsoleApp2.exe')
				// bat 'call "Bat1.bat"'
				}
			}
		}
		}
		}
    }
}