
/// <reference path="../Plugins/angular/angular.js" />
var myApp = angular.module('myModule', []);
myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);
myController.$inject = ['$scope'];

//declera
function schoolController($scope) {
    $scope.message = "anumation from school";
}
function studentController( $scope) {
//    $scope.message = "this is message from student";
}
function teacherController($scope) {
    //$scope.message = "this is message from teacher";
}