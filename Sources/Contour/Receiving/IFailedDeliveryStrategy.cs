﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFailedDeliveryStrategy.cs" company="">
//   
// </copyright>
// <summary>
//   The FailedDeliveryStrategy interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contour.Receiving
{
    /// <summary>
    /// The FailedDeliveryStrategy interface.
    /// </summary>
    public interface IFailedDeliveryStrategy
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="failedConsumingContext">
        /// The failed consuming context.
        /// </param>
        void Handle(IFailedConsumingContext failedConsumingContext);
    }
}
