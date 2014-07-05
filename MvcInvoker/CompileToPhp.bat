c:
cd \Dropbox\mvc-invoker-cs2php\MvcInvoker

c:\cs2php\cs2php.exe MvcInvoker.csproj _PhpOutput

subst t: \\webmercury\aecdev2
copy _PhpOutput\*.* T:\content\cs2php_test\
subst /d t:

exit /b 0