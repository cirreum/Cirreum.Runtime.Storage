# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a Cirreum Runtime Extension project that provides storage service configuration, specifically for Azure Blob Storage integration. It's part of the Cirreum Foundation Framework ecosystem and extends the runtime with storage capabilities.

## Build Commands

```bash
# Restore dependencies
dotnet restore Cirreum.Runtime.Storage.slnx

# Build the solution
dotnet build Cirreum.Runtime.Storage.slnx --configuration Release

# Create NuGet package
dotnet pack Cirreum.Runtime.Storage.slnx --configuration Release
```

## Architecture

### Key Components

1. **HostingExtensions.cs** (src/Cirreum.Runtime.Storage/Extensions/Hosting/HostingExtensions.cs:9)
   - Provides the `AddStorage()` extension method for `IHostApplicationBuilder`
   - Implements the marker pattern to prevent duplicate registrations
   - Uses the service provider pattern from Cirreum.Runtime.ServiceProvider

### Design Patterns

- **Service Provider Pattern**: The project uses `RegisterServiceProvider<>` to register storage providers with their settings and health check options
- **Marker Pattern**: Uses internal marker types to prevent duplicate service registrations
- **Extension Methods**: All configuration is done through extension methods in the `Microsoft.AspNetCore.Hosting` namespace

### Dependencies

- Cirreum.Storage.Azure (v1.0.1) - Azure Blob Storage implementation
- Cirreum.Runtime.ServiceProvider (v1.0.1) - Service provider infrastructure
- Target Framework: .NET 10.0

## Development Guidelines

1. Follow the contribution guidelines from the README regarding conservative abstraction design
2. The project uses nullable reference types (enabled by default)
3. XML documentation generation is enabled
4. The project follows semantic versioning with careful consideration for breaking changes

## CI/CD

The project uses GitHub Actions for publishing to NuGet:
- Triggered on release creation or manual workflow dispatch
- Uses OIDC authentication for NuGet publishing
- Version is extracted from git tags (format: v1.2.3)