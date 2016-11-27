divideAndWalkTheDogApp.controller('RequestController',
    function RequestController($scope, $http,$rootScope, $routeParams, $location) {
        
        $scope.Dog = $rootScope.Dog;
        $scope.User = $rootScope.User;

        var id = $routeParams["id"];
        $scope.canDayTimes = [];
        $scope.needDayTimes = [];
        var path = "http://localhost:42598/requests/" + id;
        $http.get(path).success(function (data) {
            $scope.request = data;
        });

        $scope.getDogs = function(){
            
        }

        $scope.addCanDayTime = function (day, from, to) {
            if (!isNaN(day) && from < to) {
                $scope.errorMessage = "";

                $scope.canDayTimes.push({
                    Day: day,
                    DayTimeStart: from.getHours() + "." + from.getMinutes(),
                    DayTimeFinish: to.getHours() + "." + to.getMinutes()
                });
            }
            else
            {
                $scope.errorMessage = "Invalid time";
            }
        }

        $scope.addNeedDayTime = function (day, from, to) {
            if (!isNaN(day) && from < to) {
                $scope.errorMessage = "";

                $scope.needDayTimes.push({
                    Day: day,
                    DayTimeStart: from.getHours() + "." + from.getMinutes(),
                    DayTimeFinish: to.getHours() + "." + to.getMinutes()
                });
            }
            else
            {
                $scope.errorMessage = "Invalid time";
            }
        }

        $scope.create = function (request, requestForm) {
            var d = 2;
            if (requestForm.$valid) {
                $scope.errorMessage = "";

                if($scope.canDayTimes.Length < 1){
                   $scope.errorMessage = "Add days, when you can walk with dogs"; 
                }

                if($scope.needDayTimes.Length < 1){
                   $scope.errorMessage = "Add days, when you can`t walk with dogs"; 
                }
                request.TimePeriodsWhenUserCanWalk = $scope.canDayTimes;
                request.TimePeriodsWhenUserNeedWalk = $scope.needDayTimes;
                request.User = {};
                request.User = $rootScope.User;
                request.Dog = $rootScope.Dog;
                $http.post("http://localhost:42598/requests/create", request)
                    .success(function (answ) {
                        $location.path("/requests");
                    }).error(function (answ) {
                        if (typeof answ['error_description'] != "undefined") {
                            $scope.errorMessage = "Some fields are incorrect";
                        }
                    });
            }
        }
    }
)