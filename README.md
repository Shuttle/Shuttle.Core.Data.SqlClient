# Shuttle.Core.Data.SqlClient

As yet (1 Jan 2018) .Net Core 2.0 does not have a `DbProviderFactories` implementation.

This package provides an implementation of the `DbProviderFactories` adapter to overcome this limitation specifically for `SqlClient` requirements:

``` c#
	var factories = new DbProviderFactories();
```