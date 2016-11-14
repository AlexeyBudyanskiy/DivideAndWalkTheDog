divideAndWalkTheDogApp.controller('RequestsController', 
    function RequestsController($scope, $http){  
        $http.get('http://localhost:42598/requests').success(function(data) {
            $scope.requests = data;
        });
    }
)