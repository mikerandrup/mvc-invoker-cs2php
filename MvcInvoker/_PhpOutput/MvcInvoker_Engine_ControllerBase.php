<?php
/*
Generated with CS2PHP
*/
namespace MvcInvoker\Engine {
    class ControllerBase {
        protected $_requestModel;
        public function BindRequestModelFromGlobalState($requestModel, $requestDictionary) {
        }
        public function GenerateResponseBody() {
            return '';
        }
        public function get_RequestModel() {
            return $this->_requestModel;
        }
    }
}
?>