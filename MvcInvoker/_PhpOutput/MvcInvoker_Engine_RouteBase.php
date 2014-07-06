<?php
/*
Generated with CS2PHP
*/
namespace {
    require_once(dirname(__FILE__) . '/MvcInvoker_Engine_ControllerBase.php');
}
namespace MvcInvoker\Engine {
    class RouteBase {
        protected $MatchingRegex;
        public function CreateController() {
            return new ControllerBase();
        }
        public function RouteDoesMatch($requestedPath) {
            if ($this->MatchingRegex == null)
                return false;
            else
                return $this->MatchingRegex->IsMatch($requestedPath);
        }
    }
}
?>