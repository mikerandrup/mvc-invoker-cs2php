<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Engine_RouteBase.php');
    require_once('System_Text_RegularExpressions_Regex.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_Controllers_AdminController.php');
}
namespace MvcInvoker\Routes {
    class AdminRoute extends \MvcInvoker\Engine\RouteBase {
        public function __construct() {
            $this->MatchingRegex = new \System\Text\RegularExpressions\Regex('admin\\/');
        }
        public function CreateController() {
            return new \MvcInvoker\Controllers\AdminController();
        }
    }
}
?>