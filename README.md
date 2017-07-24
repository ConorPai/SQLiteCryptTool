# SQLite密码设置工具

使用System.Data.SQLite内置加密方案，对SQLite数据库进行加密设置、验证、密码重置和清除密码等操作。


System.Data.SQLite内置的加密方案，可以移植到C++底层，但是这套方案只支持Windows平台，所以这样加密出来的数据库安卓上无法使用

如果想多端加密，可以考虑集成SQLCipher，但这种方案需要修改System.Data.SQLite源码，将内置加密方案替换成SQLCipher，重新编译再使用。安卓上层SQLite访问库也需要考虑替换成支持SQLCipher的方案，例如WCDB
