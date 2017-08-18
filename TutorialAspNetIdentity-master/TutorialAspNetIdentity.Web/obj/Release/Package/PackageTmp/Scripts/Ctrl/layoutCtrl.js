angular.module("layout").controller("layoutCtrl", function ($scope) {
    
    $scope.txtHome = "active";
    $scope.txtSobre = "";
    $scope.txtVideos = "";

    $scope.opVideos = function () {
        $scope.txtHome = "";
        $scope.txtSobre = "";
        $scope.txtVideos = "active";
    }
    $scope.opSobre = function () {
        $scope.txtHome = "";
        $scope.txtSobre = "active";
        $scope.txtVideos = "";
    }
    $scope.ooHome = function () {
        $scope.txtHome = "active";
        $scope.txtSobre = "";
        $scope.txtVideos = "";
    }
});