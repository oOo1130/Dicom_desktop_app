using System;

namespace DicomServer
{
    /// <summary>
    /// This describes a tenant combo box item.
    /// </summary>
    public class TenantComboboxItem
    {
        /// <summary>
        /// The tenant.
        /// </summary>
        public Tenant Tenant { get; set; }

        /// <summary>
        /// Creates the tenant string.
        /// </summary>
        /// <returns>The tenant string</returns>
        public override String ToString()
        {
            return Tenant == null
                ? String.Empty
                : Tenant.TenantName;
        }
    }
}
