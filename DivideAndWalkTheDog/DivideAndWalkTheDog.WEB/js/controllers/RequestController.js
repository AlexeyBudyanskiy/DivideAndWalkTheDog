divideAndWalkTheDogApp.controller('RequestController', 
    function RequestController($scope, $http, $routeParams){  
         var id = $routeParams["id"];
         var path = "http://localhost:42598/requests/" + id;
        $http.get(path).success(function(data) {
            $scope.request = data;
        });
    }
)