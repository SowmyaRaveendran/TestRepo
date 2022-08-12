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
				 bat "\"${tool 'MS_Build_Local'}\" ${WORKSPACE}/WpfApp1/WpfApp1.sln /m /p:Configuration=Release /p:Platform=\"Any CPU\""
			}
			}
		stage ('Parallel-Task2') {
			steps {
			script {
				bat 'Bat2.bat'
				}
			}
		}
		}
		}
    }
}