var divideAndWalkTheDogApp = angular.module('divideAndWalkTheDogApp', ["ngRoute"])
    .config(function($routeProvider){
        $routeProvider.when('/landing',
        {
            templateUrl:'views/landing.html',
            controller:'LoginController'
        });

        $routeProvider.when('/register',
        {
            templateUrl:'views/register.html',
            controller:'RegisterController'
        });

        $routeProvider.when('/userInfo',
        {
            templateUrl:'views/createUserInfo.html',
            controller:'RegisterController'
        });

        $routeProvider.when('/createDog',
        {
            templateUrl:'views/createDog.html',
            controller:'RegisterController'
        });
        
        $routeProvider.when('/login',
        {
            templateUrl:'views/login.html',
            controller:'LoginController'
        });

        $routeProvider.when('/requests/create',
        {
            templateUrl:'views/createRequest.html',
            controller:'RequestController'
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