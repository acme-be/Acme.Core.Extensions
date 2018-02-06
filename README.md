Acme.Core.Extensions
=========================
Useful extensions for .net framework types. This is a pure utility package and should be kept as simple as possible but also as powerful as possible :)

[![NuGet Package](https://img.shields.io/nuget/v/Acme.Core.Extensions.svg)](https://www.nuget.org/packages/Acme.Core.Extensions/) [![NuGet Package](https://img.shields.io/nuget/dt/Acme.Core.Extensions.svg)](https://www.nuget.org/packages/Acme.Core.Extensions/) [![acme MyGet Build Status](https://www.myget.org/BuildSource/Badge/acme-dev?identifier=a7c3be77-1f5e-4a11-bb82-fca2530cd9a6)](https://www.myget.org/) [![License](https://img.shields.io/badge/license-LGPL--3.0-blue.svg)](LICENSE) 

# Getting started
---------------

Install [NuGet Package](https://www.nuget.org/packages/Acme.Core.Extensions/) Acme.Core.Extensions from Package Manager or from Package Manager Console:
```
PM> Install-Package Acme.Core.Extensions
```

After installation you have access to a new namespace :
```csharp
using Acme.Core.Extensions;
```

# Changes
-------
1.0.0:
* Adds ByteArrayExtensions.ToHexadecimalString
* Adds DateTimeExtensions.ToUnixTimeStamp
* Adds ObjectExtensions.EnsureNotNull
* * Adds ObjectExtensions.ThrowIfNull

# Roadmap & Ideas
---------------
* Unit tests to keep a coverage above 80%
* Keep library compatible with .Net Framework, .Net Core and .Net Standard
* Avoid too many references to externals libraries 

# Documentation
-------------
