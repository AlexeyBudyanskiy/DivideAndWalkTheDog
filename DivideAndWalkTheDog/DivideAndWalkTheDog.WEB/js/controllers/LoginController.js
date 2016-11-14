divideAndWalkTheDogApp.controller('LoginController',
    function LoginController($scope, $http) {
        $scope.response = {};
        $scope.login = function (user, loginForm) {
            if (registerForm.$valid) {
                $http.post("http://localhost:42598/token", user).success(function (answ) {
                    $scope.response = answ;
                }.error(function (answ) {
                    $scope.response = answ;
                }));
            }
        };
    }
)