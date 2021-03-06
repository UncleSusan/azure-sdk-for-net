// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DatabaseOperations.
    /// </summary>
    public static partial class DatabaseOperationsExtensions
    {
            /// <summary>
            /// Retrieves the metrics determined by the given filter for the given database
            /// account and database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='databaseRid'>
            /// Cosmos DB database rid.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// The parameters that can be filtered are name.value (name of the metric, can
            /// have an or of multiple names), startTime, endTime, and timeGrain. The
            /// supported operator is eq.
            /// </param>
            public static IEnumerable<Metric> ListMetrics(this IDatabaseOperations operations, string resourceGroupName, string accountName, string databaseRid, string filter)
            {
                return operations.ListMetricsAsync(resourceGroupName, accountName, databaseRid, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the metrics determined by the given filter for the given database
            /// account and database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='databaseRid'>
            /// Cosmos DB database rid.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// The parameters that can be filtered are name.value (name of the metric, can
            /// have an or of multiple names), startTime, endTime, and timeGrain. The
            /// supported operator is eq.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Metric>> ListMetricsAsync(this IDatabaseOperations operations, string resourceGroupName, string accountName, string databaseRid, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, accountName, databaseRid, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves the usages (most recent data) for the given database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='databaseRid'>
            /// Cosmos DB database rid.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of usages to return. The
            /// supported parameter is name.value (name of the metric, can have an or of
            /// multiple names).
            /// </param>
            public static IEnumerable<Usage> ListUsages(this IDatabaseOperations operations, string resourceGroupName, string accountName, string databaseRid, string filter = default(string))
            {
                return operations.ListUsagesAsync(resourceGroupName, accountName, databaseRid, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the usages (most recent data) for the given database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='databaseRid'>
            /// Cosmos DB database rid.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of usages to return. The
            /// supported parameter is name.value (name of the metric, can have an or of
            /// multiple names).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Usage>> ListUsagesAsync(this IDatabaseOperations operations, string resourceGroupName, string accountName, string databaseRid, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUsagesWithHttpMessagesAsync(resourceGroupName, accountName, databaseRid, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves metric definitions for the given database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='databaseRid'>
            /// Cosmos DB database rid.
            /// </param>
            public static IEnumerable<MetricDefinition> ListMetricDefinitions(this IDatabaseOperations operations, string resourceGroupName, string accountName, string databaseRid)
            {
                return operations.ListMetricDefinitionsAsync(resourceGroupName, accountName, databaseRid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves metric definitions for the given database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='databaseRid'>
            /// Cosmos DB database rid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<MetricDefinition>> ListMetricDefinitionsAsync(this IDatabaseOperations operations, string resourceGroupName, string accountName, string databaseRid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, accountName, databaseRid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
