pipeline {
    agent any
environment {
        VERSION = ''
        manifestFilePath = "${env.WORKSPACE}\\${ITEM_FULL_NAME}\\"
    }
        stages {
    //     stage('GetInput') {
    //         steps {
    //             script {
                    
    // try {
    //                         VERSION = input message: 'User input required',
    //           parameters: [string(name: 'Application version', defaultValue: '',
    //                                         description: 'Version of application')]

    //                 // Echo to console
    //                 echo 'Version:' + VERSION
                    
    // }
    // catch (Exception e) {
    //     echo 'Exception occurred: ' + e.toString()
    // }
    //             }
    //         }
    //     }
        stage('PrintInput') {
            steps {
                script {
                    writeFile file: "testDoc.txt", text: "From Pipeline - new log"
                    bat 'call git add .'
                    // Echo to console
                    echo env.GIT_BRANCH
                    bat 'call git commit -m "doc: update files to latest version number"'
                    bat "call git remote set-url origin https://github.com/SowmyaRaveendran/TestRepo" 
                    bat "call git push ${env.BRANCH_NAME}" 
                }
            }
        }
		// stage('Parallel-stages-Test') {
		// parallel {
		// stage ('Parallel-Task1') {
		// 	steps {
        //         script {
        //         echo "TimeStamp1: ${currentBuild.startTimeInMillis}"
		// 		echo bat(returnStdout: false, script: manifestFilePath + 'ConsoleApp1.exe')
        //         }
		// 	}
		// 	}
		// stage ('Parallel-Task2') {
		// 	steps {
		// 	script {
        //         echo "TimeStamp2: ${currentBuild.startTimeInMillis}"
		// 		// echo bat(script: 'ConsoleApp2.exe')
		// 		bat 'call "Bat1.bat"'
		// 		}
		// 	}
		// }
		// }
		// }
    }
}