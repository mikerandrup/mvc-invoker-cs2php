<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Engine_ControllerBase.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_RequestModels_AdminRequestModel.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_ViewModels_AdminViewModel.php');
}
namespace MvcInvoker\Controllers {
    class AdminController extends \MvcInvoker\Engine\ControllerBase {
        public function __construct() {
            $this->_requestModel = new \MvcInvoker\RequestModels\AdminRequestModel();
        }
        public function GenerateResponseBody() {
            $vm = new \MvcInvoker\ViewModels\AdminViewModel();
            return '<html><head><title>' . $vm->ToolMode . '</title></head><body>You ' . ($vm->IsAuthenticated ? 'are' : "aren't") . ' Authenticated.</body></html>';
        }
    }
}
?>