﻿namespace Nop.Services.Caching.CachingDefaults
{
    /// <summary>
    /// Represents default values related to discounts services
    /// </summary>
    public static partial class NopDiscountCachingDefaults
    {
        /// <summary>
        /// Key for discount requirement of a certain discount
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// </remarks>
        public static string DiscountRequirementModelCacheKey => "Nop.discounts.requirements-{0}";
        
        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// {1} : coupon code
        /// {2} : discount name
        /// </remarks>
        public static string DiscountAllCacheKey => "Nop.discounts.all-{0}-{1}-{2}";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string DiscountAllPrefixCacheKey => "Nop.discounts.all";

        /// <summary>
        /// Key for category IDs of a discount
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// {1} : roles of the current user
        /// {2} : current store ID
        /// </remarks>
        public static string DiscountCategoryIdsModelCacheKey => "Nop.discounts.categoryids-{0}-{1}-{2}";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// </remarks>
        public static string DiscountCategoryIdsByDiscountPrefixCacheKey => "Nop.discounts.categoryids-{0}";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string DiscountCategoryIdsPrefixCacheKey => "Nop.discounts.categoryids";

        /// <summary>
        /// Key for manufacturer IDs of a discount
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// {1} : roles of the current user
        /// {2} : current store ID
        /// </remarks>
        public static string DiscountManufacturerIdsModelCacheKey => "Nop.discounts.manufacturerids-{0}-{1}-{2}";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// </remarks>
        public static string DiscountManufacturerIdsByDiscountPrefixCacheKey => "Nop.discounts.manufacturerids-{0}";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string DiscountManufacturerIdsPrefixCacheKey => "Nop.discounts.manufacturerids";
    }
}