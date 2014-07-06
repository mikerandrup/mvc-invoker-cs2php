<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Engine_ControllerBase.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_RequestModels_StoreRequestModel.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_ViewModels_StoreViewModel.php');
}
namespace MvcInvoker\Controllers {
    class StoreController extends \MvcInvoker\Engine\ControllerBase {
        public function __construct() {
            $this->_requestModel = new \MvcInvoker\RequestModels\StoreRequestModel();
        }
        public function GenerateResponseBody() {
            $vm = new \MvcInvoker\ViewModels\StoreViewModel();
            return '<html><head><title>' . $vm->ProductName . '</title></head><body>$' . $vm->ProductPrice . '</body></html>';
        }
    }
}
?>