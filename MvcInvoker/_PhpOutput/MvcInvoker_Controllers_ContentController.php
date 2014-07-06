<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Engine_ControllerBase.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_RequestModels_ContentRequestModel.php');
    require_once(dirname(__FILE__) . '/MvcInvoker_ViewModels_ContentViewModel.php');
}
namespace MvcInvoker\Controllers {
    class ContentController extends \MvcInvoker\Engine\ControllerBase {
        public function __construct() {
            $this->_requestModel = new \MvcInvoker\RequestModels\ContentRequestModel();
        }
        public function GenerateResponseBody() {
            $vm = $this->BuildViewModelFromDatabase();
            return '<html><head><title>' . $vm->PageTitle . '</title></head><body>' . $vm->PageContent . '</body></html>';
        }
        private function BuildViewModelFromDatabase() {
            $vm = new \MvcInvoker\ViewModels\ContentViewModel();
            return $vm;
        }
    }
}
?>