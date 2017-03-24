#TDD with .NET Core

##My First String Calculator Kata

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

####Setup VSCode for Testing

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
