# Acme.Core.Extensions
Useful extensions for .net framework types. This is a pure utility package and should be kept as simple as possible but also as powerful as possible :)

[![NuGet Package](https://img.shields.io/nuget/v/Acme.Core.Extensions.svg)](https://www.nuget.org/packages/Acme.Core.Extensions/) [![NuGet Package](https://img.shields.io/nuget/dt/Acme.Core.Extensions.svg)](https://www.nuget.org/packages/Acme.Core.Extensions/) [![acme MyGet Build Status](https://www.myget.org/BuildSource/Badge/acme-dev?identifier=a7c3be77-1f5e-4a11-bb82-fca2530cd9a6)](https://www.myget.org/) [![License](https://img.shields.io/badge/license-LGPL--3.0-blue.svg)](LICENSE) 

## Getting started
Install [NuGet Package](https://www.nuget.org/packages/Acme.Core.Extensions/) Acme.Core.Extensions from Package Manager or from Package Manager Console:
```
PM> Install-Package Acme.Core.Extensions
```
After installation you have access to a new namespace :
```csharp
using Acme.Core.Extensions;
```

## Changes
### 1.0.0
* Adds ByteArrayExtensions.ToHexadecimalString
* Adds DateTimeExtensions.ToUnixTimeStamp
* Adds ObjectExtensions.EnsureNotNull
* Adds ObjectExtensions.ThrowIfNull

## Roadmap & Ideas
* Unit tests to keep a coverage above 80%
* Keep library compatible with .Net Framework, .Net Core and .Net Standard
* Avoid too many references to external libraries 

## Related Projects
### Acme.Web.Security.Headers
*Secure your web site/application with a simple package.*
https://github.com/olibos/Acme.Web.Security.Headers

# Documentation
All the library is self documented with XmlDoc, but here you can find some code sample.
You can also have a look at the unit test project, it contains most of the extensions and how to use it.

## ByteArrayExtensions
* ToHexadecimalString : Convert a byte array into his hexadecimal string

## DateTimeExtensions
* ToUnixTimeStamp : Convert a datetime to a UNIX timestamp (i.e. : number of seconds since unix Epoch)

## ObjectExtensions
* EnsureNotNull : Throws an ArgumentNullException if the object is null, or return the object. Help to validate that parameters are not null and follow. Works with class and nullable struct. Read more :  https://docs.microsoft.com/en-us/visualstudio/code-quality/ca1062-validate-arguments-of-public-methods
* ThrowIfNull : Throws an ArgumentNullException if the object is null. Help to validate that parameters are not null and follow. Works with class and nullable struct. Read more :  https://docs.microsoft.com/en-us/visualstudio/code-quality/ca1062-validate-arguments-of-public-methods