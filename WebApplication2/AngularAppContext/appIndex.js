﻿myApp.factory('httpInterceptor', function ($q, $rootScope, $log) {

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
            templateUrl: myApp.Root + "Home/Index",
            controller: "workItemTableController"
        })
        .when('/services', {
            templateUrl: myApp.Root + 'WorkItemType/WorkItemTypes',
            controller: "workItemTypesController"
        })
        .when('/service/:id', {
            templateUrl: myApp.Root + 'WorkItemType/WorkItemType',
            controller: "workItemTypeController"
        });
});