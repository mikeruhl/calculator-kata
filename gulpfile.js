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