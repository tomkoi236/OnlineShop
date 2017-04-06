
/// <reference path="../Plugins/angular/angular.js" />
var myApp = angular.module('myModule', []);
myApp.controller("myController", myController);

myController.$inject = ['$scope'];
//declera
function myController($scope) {
    $scope.message = "this is message from controller";
}