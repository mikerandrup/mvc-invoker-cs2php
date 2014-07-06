<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Routes_AdminRoute.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_Routes_StoreRoute.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_Routes_ContentRoute.php');
}
namespace MvcInvoker\Engine {
    class RouteCollection {
        private $Routes;
        public function __construct() {
            $this->Routes = array();
            array_push($this->Routes, new \MvcInvoker\Routes\AdminRoute());
            array_push($this->Routes, new \MvcInvoker\Routes\StoreRoute());
            array_push($this->Routes, new \MvcInvoker\Routes\ContentRoute());
        }
        public function GetRouteForPath($path) {
            $matchingRoute = null;
            foreach($this->Routes as $route)
                if ($route->RouteDoesMatch($path))
                    {
                        $matchingRoute = $route;
                        break;
                    }
            return $matchingRoute;
        }
    }
}
?>