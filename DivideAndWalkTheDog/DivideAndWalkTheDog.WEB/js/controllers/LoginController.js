divideAndWalkTheDogApp.controller('LoginController',
    function LoginController($scope, $http, $rootScope, $location) {
        $scope.response = {};
        $rootScope.token = "";
        $scope.login = function (user, loginForm) {
            if (loginForm.$valid) {
                var message = "grant_type=password&username=" + user.Email
                    + "&password=" + user.Password;
                $http({
                    method: 'POST',
                    url: 'http://localhost:42598/token',
                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                    data: message
                })
                    .success(function (answ) {
                        $rootScope.token = answ.access_token;
                        $http.defaults.headers.common.Authorization = 'Bearer ' + $rootScope.token;

                        $http.get("http://localhost:42598/user").success(function (answer) {
                            $rootScope.user = answer;
                        })
                            .error(function (answer) {
                                
                            });

                        $location.path("/requests");
                    }).error(function (answ) {
                        if (typeof answ['error_description'] != "undefined") {
                            $scope.errorMessage = answ['error_description'];
                        }
                    });
            }
        };
    }
)