<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Engine_RouteCollection.php');
}
namespace MvcInvoker {
    class MvcEngine {
        public static function PhpMain() {
            $routePath = 'admin/announcements';
            $routeCollection = new Engine\RouteCollection();
            $route = $routeCollection->GetRouteForPath($routePath);
            $controller = $route->CreateController();
            echo $controller->GenerateResponseBody();
        }
    }
}
namespace {
    \MvcInvoker\MvcEngine::PhpMain();
}
?>