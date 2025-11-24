# Cirreum.Runtime.Storage

[![NuGet Version](https://img.shields.io/nuget/v/Cirreum.Runtime.Storage.svg?style=flat-square&labelColor=1F1F1F&color=003D8F)](https://www.nuget.org/packages/Cirreum.Runtime.Storage/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Cirreum.Runtime.Storage.svg?style=flat-square&labelColor=1F1F1F&color=003D8F)](https://www.nuget.org/packages/Cirreum.Runtime.Storage/)
[![GitHub Release](https://img.shields.io/github/v/release/cirreum/Cirreum.Runtime.Storage?style=flat-square&labelColor=1F1F1F&color=FF3B2E)](https://github.com/cirreum/Cirreum.Runtime.Storage/releases)
[![License](https://img.shields.io/github/license/cirreum/Cirreum.Runtime.Storage?style=flat-square&labelColor=1F1F1F&color=F2F2F2)](https://github.com/cirreum/Cirreum.Runtime.Storage/blob/main/LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10.0-003D8F?style=flat-square&labelColor=1F1F1F)](https://dotnet.microsoft.com/)

**Storage service configuration for Cirreum runtime applications**

## Overview

**Cirreum.Runtime.Storage** provides runtime configuration and integration for storage services within the Cirreum Foundation Framework.

This extension simplifies the setup of storage providers (such as Azure Blob Storage) by offering hosting extensions that automatically configure service providers, health checks, and dependency injection for your runtime applications.

## Features

- **Azure Blob Storage Integration** - Pre-configured support for Azure Blob Storage
- **Service Provider Pattern** - Consistent configuration pattern across all storage providers
- **Health Check Integration** - Automatic health check registration for storage services
- **Duplicate Registration Prevention** - Built-in safeguards against duplicate service registrations
- **Runtime Configuration** - Dynamic configuration through the Cirreum service provider infrastructure

## Getting Started

### Installation

```bash
dotnet add package Cirreum.Runtime.Storage
```

### Usage

Add storage services to your host application builder:

```csharp
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add storage configuration
builder.AddStorage();

var app = builder.Build();
```

This will automatically:
- Configure Azure Blob Storage providers based on your application settings
- Register health checks for storage services
- Set up dependency injection for storage-related services

## Contribution Guidelines

1. **Be conservative with new abstractions**  
   The API surface must remain stable and meaningful.

2. **Limit dependency expansion**  
   Only add foundational, version-stable dependencies.

3. **Favor additive, non-breaking changes**  
   Breaking changes ripple through the entire ecosystem.

4. **Include thorough unit tests**  
   All primitives and patterns should be independently testable.

5. **Document architectural decisions**  
   Context and reasoning should be clear for future maintainers.

6. **Follow .NET conventions**  
   Use established patterns from Microsoft.Extensions.* libraries.

## Versioning

Cirreum.Runtime.Storage follows [Semantic Versioning](https://semver.org/):

- **Major** - Breaking API changes
- **Minor** - New features, backward compatible
- **Patch** - Bug fixes, backward compatible

Given its foundational role, major version bumps are rare and carefully considered.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Cirreum Foundation Framework**  
*Layered simplicity for modern .NET*