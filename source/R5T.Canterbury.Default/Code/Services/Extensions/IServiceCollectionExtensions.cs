using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Canterbury.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CDriveNameConvention"/> implementation of <see cref="ICDriveNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultCDriveNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<ICDriveNameConvention, CDriveNameConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CDriveNameConvention"/> implementation of <see cref="ICDriveNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ICDriveNameConvention> AddDefaultCDriveNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ICDriveNameConvention>(() => services.AddDefaultCDriveNameConvention());
            return serviceAction;
        }
    }
}
