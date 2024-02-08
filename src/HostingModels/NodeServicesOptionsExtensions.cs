// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Cynosure.NodeServices.HostingModels
{
    /// <summary>
    /// Extension methods that help with populating a <see cref="NodeServicesOptions"/> object.
    /// </summary>
    public static class NodeServicesOptionsExtensions
    {
        /// <summary>
        /// Configures the <see cref="INodeServices"/> service so that it will use out-of-process
        /// Node.js instances and perform RPC calls over HTTP.
        /// </summary>
        public static void UseHttpHosting(this NodeServicesOptions options)
        {
            options.NodeInstanceFactory = () => new HttpNodeInstance(options);
        }
    }
}
