namespace Microsoft.AspNetCore.Hosting;

using Cirreum.Storage;
using Cirreum.Storage.Configuration;
using Cirreum.Storage.Health;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public static class HostingExtensions {

	private class ConfigureStorageMarker { }

	/// <summary>
	/// Add support for storage (Blob Storage) by registering any configured providers
	/// and associated instances.
	/// </summary>
	public static IHostApplicationBuilder AddStorage(this IHostApplicationBuilder builder) {

		// Check if already registered using a marker service		
		if (builder.Services.IsMarkerTypeRegistered<ConfigureStorageMarker>()) {
			return builder;
		}

		// Mark as registered
		builder.Services.MarkTypeAsRegistered<ConfigureStorageMarker>();

		// Service Providers...
		return builder
			.RegisterServiceProvider<
				AzureBlobStorageRegistrar,
				AzureBlobStorageSettings,
				AzureBlobStorageInstanceSettings,
				AzureBlobStorageHealthCheckOptions>();

		// .RegisterServiceProvider<AWSBlobStorageRegistrar>();

	}

}