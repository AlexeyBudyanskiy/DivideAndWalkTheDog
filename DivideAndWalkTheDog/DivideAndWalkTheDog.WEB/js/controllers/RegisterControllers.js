divideAndWalkTheDogApp.controller('RegisterController',
    function RegisterController($scope, $http, $location, $rootScope) {
        $scope.register = function (user, registerForm) {
            if (registerForm.$valid) {

                $http.post("http://localhost:42598/api/account/register", user).success(function (answ) {
                    $scope.login(user);
                }).error(function (answ) {
                    $scope.errorMessage = "";
                    $scope.errorConfirmPasswordMessage = "";
                    $scope.errorPasswordMessage = "";
                    $scope.errorEmailMessage = "";

                    if (typeof answ.ModelState['Error'] != "undefined") {
                        $scope.errorMessage = answ.ModelState['Error'][0];
                    }

                    if (typeof answ.ModelState['model.ConfirmPassword'] != "undefined") {
                        $scope.errorConfirmPasswordMessage = answ.ModelState['model.ConfirmPassword'][0];
                    }

                    if (typeof answ.ModelState['model.Password'] != "undefined") {
                        $scope.errorPasswordMessage = answ.ModelState['model.Password'][0];
                    }

                    if (typeof answ.ModelState['model.Email'] !== "undefined") {
                        $scope.errorEmailMessage = answ.ModelState['model.Email'][0];
                    }
                });
            }
        };

        $scope.login = function (user) {
            var message = "grant_type=password&username=" + user.Email
                + "&password=" + user.Password;
            $http({
                method: 'POST',
                url: 'http://localhost:42598/token',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                data: message
            })
                .success(function (answ) {
                    var token = answ.access_token;
                    $http.defaults.headers.common.Authorization = 'Bearer ' + token;
                    $rootScope.token = token;
                    $location.path("/userInfo");
                }).error(function (answ) {
                    $scope.errorMessage = "Some error has occured";
                });
        }

        $scope.createUserInfo = function (user, userInfoForm) {
            if (userInfoForm.$valid) {
                $http.post("http://localhost:42598/users/create", user)
                    .success(function (answ) {
                        $scope.getUserInfo();
                        $location.path("/createDog");
                    })
                    .error(function (answ) {
                        $scope.errorMessage = "Some fields are invalid";
                    });
            }
        }

        $scope.createDog = function (dog, createDogForm) {
            if (createDogForm.$valid) {
                dog.User = $rootScope.User;

                $http.post("http://localhost:42598/dogs/create", dog)
                    .success(function (answ) {
                        $scope.getDogInfo();
                        $location.path("/requests");
                    })
                    .error(function (answ) {
                        $scope.errorMessage = "Some fields are invalid";
                    });
            }
        }

        $scope.getUserInfo = function () {

            $http.get("http://localhost:42598/user")
                .success(function (answ) {
                    $rootScope.User = answ;
                })
                .error(function (answ) {
                    $scope.errorMessage = "Some fields are invalid";
                });
        }

        $scope.getDogInfo = function () {
            var url = "http://localhost:42598/user/" + $rootScope.User.Id + "/dog"
            $http.get(url)
                .success(function (answ) {
                    $rootScope.Dog = answ;
                })
                .error(function (answ) {
                    $scope.errorMessage = "Some fields are invalid";
                });
        }
    }
)