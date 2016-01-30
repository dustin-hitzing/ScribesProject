namespace ScribesF4 {

    angular.module('ScribesF4', ['ngRoute']);

    angular.module('ScribesF4').factory('authInterceptor',
        ($q: ng.IQService, $window: ng.IWindowService, $location: ng.ILocationService) => {
            return {
                request: (config) => {
                    config.headers = config.headers || {};
                    let token = $window.localStorage.getItem('token');
                    if (token) {
                        config.headers.Authorization = `Bearer ${token}`;
                    }
                    return config;
                },
                responseError: (response) => {
                    if (response.status === 401) {
                        $location.path('/login');
                    }
                    return $q.reject(response);
                }
            };
        });

    angular.module('ScribesF4')
        .config(function ($routeProvider: ng.route.IRouteProvider, $httpProvider: ng.IHttpProvider) {

            $httpProvider.interceptors.push('authInterceptor');

            $routeProvider.when('/activeStory/:storyId', {
                templateUrl: '/Presentation/ngApp/views/activeStory.html',
                controller: ScribesF4.Controllers.ActiveStoryController,
                controllerAs: 'controller'
            })
                .when('/login', {
                    templateUrl: '/Presentation/ngApp/views/login.html',
                    controller: ScribesF4.Controllers.AuthController,
                    controllerAs: 'controller'
                })
                .when('/register', {
                    templateUrl: '/Presentation/ngApp/views/register.html',
                    controller: ScribesF4.Controllers.AuthController,
                    controllerAs: 'controller'
                });
        })
}
