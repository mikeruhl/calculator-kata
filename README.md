#TDD with .NET Core

##My First String Calculator Kata with VS Code

####Initial Steps

1. md CalculatorServices && cd CalculatorServices
2. dotnet new classlib
3. cd ..
4. md CalculatorServices.Tests && cd CalculatorServices.Tests
5. dotnet new xunit
6. dotnet restore
7. cd ..
8. echo $null >> .gitignore
   Good example of [.gitignore] (https://github.com/aspnet/Docs/blob/master/.gitignore)
9. git init && git add --all && git commit -m "initial commit"

####Setup VSCode for Manual Unit Testing

1. Ctl+Shift+P
2. Type 'Tasks'
3. Click on 'Configure Task Runner' (file called tasks.json under .vscode folder)
4. add test task to file

    {
        "taskName": "test",
        "args": [
            "${workspaceRoot}\\CalculatorServices.Tests\\CalculatorServices.Tests.csproj"
        ],
        "isTestCommand": true,
        "showOutput": "always",
        "problemMatcher": "$msCompile"
    }

5. File > Preferences > Keyboard Shortcuts

    [{
        "key": "ctrl+shift+t",
        "command": "workbench.action.tasks.test",
        "when": "editorTextFocus"
    }
    ]

6. Now you can run the Xunit tests with the shortcut and see results in output window

####(Optional) Setup VSCode for Automated Unit Testing

I am using gulp for this (must also have NodeJs/NPM installed first)

1. Navigate to the root folder
2. npm install gulp
3. npm install gulp-shell
4. npm install gulp-watch
5. Replace the contents of .vscode/tasks.json file with:

    var gulp = require('gulp');
    shell = require('gulp-shell');
    watch = require('gulp-watch');

    gulp.task('default', ['restore','build', 'watch']);

    gulp.task('restore', shell.task([
      'dotnet restore ./CalculatorServices.Tests'
    ]));

    gulp.task('build', shell.task([
      'dotnet build ./CalculatorServices.Tests'
    ]));

    gulp.task('test', shell.task([
      'dotnet test ./CalculatorServices.Tests/CalculatorServices.Tests.csproj'
    ]));

    gulp.task('watch', function () {
      gulp.watch('./*/*.cs', ['test']);
    });

6. Press Ctl+Shift+B to start the task runner
7. Now anytime a change is saved to one of the *.cs files the tests will run