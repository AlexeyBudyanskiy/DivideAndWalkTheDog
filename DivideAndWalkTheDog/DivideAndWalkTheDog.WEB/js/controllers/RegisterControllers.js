divideAndWalkTheDogApp.controller('RegisterController',
    function RegisterController($scope, $http){
         
        $scope.response={};
        $scope.register = function (user, registerForm){
            if(registerForm.$valid){
                 
                $http.post("http://localhost:42598/api/account/register", user).success(function (answ) {
                    $scope.response=answ;
                     
                });
            }
        };
    }
)