divideAndWalkTheDogApp.controller('MessageController', 
    function MessageController($scope, $http, $routeParams){
        var id1 = $routeParams["id1"];
        var id2 = $routeParams["id2"];
        var path = "http://localhost:42598/messages/" + id1 + "/" + id2;
        $http.get('http://localhost:42598/messages').success(function(data) {
            $scope.messages = data;
        });
    }
)