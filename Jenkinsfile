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
                    // Get the input
                    // def userInput = input(
                    //         id: 'userInput', message: 'Enter Version:?',
                    //         parameters: [

                    //                 string(defaultValue: '',
                    //                         description: 'Version of application',
                    //                         name: 'Version'),
                    //         ])
                            VERSION = input message: 'User input required',
              parameters: [string(name: 'Application version', defaultValue: '',
                                            description: 'Version of application')]

                    // Save to variables. Default to empty string if not found.
                    // inputVersion = userInput.Version?:''

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
				// bat 'Bat1.bat'
                echo "TimeStamp1: ${currentBuild.startTime}"
				run 'ConsoleApp1.exe'
                }
			}
			}
		stage ('Parallel-Task2') {
			steps {
			script {
                echo "TimeStamp2: ${currentBuild.startTimeInMillis}"
				bat 'call "Bat2.bat"'
				}
			}
		}
		}
		}
    }
}