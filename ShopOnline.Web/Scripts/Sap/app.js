
/// <reference path="../Plugins/angular/angular.js" />
var myApp = angular.module('myModule', []);
myApp.controller("schoolController", schoolController);
myApp.service('validator', validator);
myApp.directive("onlineShopDirective", onlineShopDirective);

schoolController.$inject = ['$scope', 'validator'];

//declera
function schoolController($scope, validator) {
    $scope.checkNumber = function () {
        $scope.message = validator.checkNumber(2);
    }
}
// declea service
function validator($window) {
    return {
        checkNumber: checkNumber
    };
    function checkNumber(input) {
        if (input % 2 === 0) {
            return 'this is even';
        }
        else {
            return 'this is odd';
        }
    }
}

//directive
function onlineShopDirective() {
    return {
        template: "<h1> this is my first custom directive </h1>"
    }
}

