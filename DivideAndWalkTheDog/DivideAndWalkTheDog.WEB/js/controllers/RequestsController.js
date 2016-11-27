divideAndWalkTheDogApp.controller('RequestsController', 
    function RequestsController($scope, $http, $rootScope){  

        $scope.Dog = $rootScope.Dog;
        $scope.User = $rootScope.User;

        $http.get('http://localhost:42598/requests').success(function(data) {
            $scope.requests = data;
        });
    }
)