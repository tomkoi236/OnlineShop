/// <reference path="~\Assets/Admin/libs/angular/angular.js" />

(function () {
    angular.module('ShopOnline',
        ['ShopOnline.products',
        'ShopOnline.product_categories',
        'ShopOnline.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider)
    {
        $stateProvider.state('home',
            {
                url: "/admin",
                templateUrl: "/app/components/home/homeView.html",
                controller: "homeController"
            });
        $urlRouterProvider.otherwise('/admin');
    }
})();