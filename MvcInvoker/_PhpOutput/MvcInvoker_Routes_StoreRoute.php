<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Engine_RouteBase.php');
    require_once('System_Text_RegularExpressions_Regex.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_Controllers_StoreController.php');
}
namespace MvcInvoker\Routes {
    class StoreRoute extends \MvcInvoker\Engine\RouteBase {
        public function __construct() {
            $this->MatchingRegex = new \System\Text\RegularExpressions\Regex('retail\\/');
        }
        public function CreateController() {
            return new \MvcInvoker\Controllers\StoreController();
        }
    }
}
?>