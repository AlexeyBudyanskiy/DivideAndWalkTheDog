var divideAndWalkTheDogApp = angular.module('divideAndWalkTheDogApp', ["ngRoute"])
    .config(function($routeProvider){
        $routeProvider.when('/register',
        {
            templateUrl:'views/register.html',
            controller:'RegisterController'
        });
        $routeProvider.when('/login',
        {
            templateUrl:'views/login.html',
            controller:'LoginController'
        });
        
        $routeProvider.when('/requests',
        {
            templateUrl:'views/requestsList.html',
            controller:'RequestsController'
        });

        $routeProvider.when('/request/:id',
        {
            templateUrl:'views/request.html',
            controller:'RequestController'
        });
});