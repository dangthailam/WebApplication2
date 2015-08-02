myApp.factory('httpInterceptor', function ($q, $rootScope, $log) {

    var numLoadings = 0;

    return {
        request: function (config) {

            numLoadings++;

            // Show loader
            $rootScope.$broadcast("loader_show");
            return config || $q.when(config);

        },
        response: function (response) {

            if ((--numLoadings) === 0) {
                // Hide loader
                $rootScope.$broadcast("loader_hide");
            }

            return response || $q.when(response);

        },
        responseError: function (response) {

            if (!(--numLoadings)) {
                // Hide loader
                $rootScope.$broadcast("loader_hide");
            }

            return $q.reject(response);
        }
    };
})
.config(function ($httpProvider, $routeProvider) {
    $httpProvider.interceptors.push('httpInterceptor');
    $routeProvider
        .when('/', {
            templateUrl: myApp.Root + "Home/Home",
            controller: "homeController"
        }).when('/createcv', {
            templateUrl: myApp.Root + "Cv/Create",
            controller: "cvController"
        });
});