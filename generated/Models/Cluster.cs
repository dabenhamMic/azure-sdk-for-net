// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OperationalInsightsManagementClient.Models
{
    /// <summary> The top level Log Analytics cluster resource container. </summary>
    public partial class Cluster : TrackedResource
    {
        /// <summary> Initializes a new instance of Cluster. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Cluster(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            AssociatedWorkspaces = new ChangeTrackingList<AssociatedWorkspace>();
        }

        /// <summary> Initializes a new instance of Cluster. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="sku"> The sku properties. </param>
        /// <param name="clusterId"> The ID associated with the cluster. </param>
        /// <param name="provisioningState"> The provisioning state of the cluster. </param>
        /// <param name="isDoubleEncryptionEnabled"> Configures whether cluster will use double encryption. This Property can not be modified after cluster creation. Default value is &apos;true&apos;. </param>
        /// <param name="isAvailabilityZonesEnabled"> Sets whether the cluster will support availability zones. This can be set as true only in regions where Azure Data Explorer support Availability Zones. This Property can not be modified after cluster creation. Default value is &apos;true&apos; if region supports Availability Zones. </param>
        /// <param name="billingType"> The cluster&apos;s billing type. </param>
        /// <param name="keyVaultProperties"> The associated key properties. </param>
        /// <param name="lastModifiedDate"> The last time the cluster was updated. </param>
        /// <param name="createdDate"> The cluster creation time. </param>
        /// <param name="associatedWorkspaces"> The list of Log Analytics workspaces associated with the cluster. </param>
        /// <param name="capacityReservationProperties"> Additional properties for capacity reservation. </param>
        internal Cluster(string id, string name, string type, IDictionary<string, string> tags, string location, Identity identity, ClusterSku sku, string clusterId, ClusterEntityStatus? provisioningState, bool? isDoubleEncryptionEnabled, bool? isAvailabilityZonesEnabled, BillingType? billingType, KeyVaultProperties keyVaultProperties, string lastModifiedDate, string createdDate, IList<AssociatedWorkspace> associatedWorkspaces, CapacityReservationProperties capacityReservationProperties) : base(id, name, type, tags, location)
        {
            Identity = identity;
            Sku = sku;
            ClusterId = clusterId;
            ProvisioningState = provisioningState;
            IsDoubleEncryptionEnabled = isDoubleEncryptionEnabled;
            IsAvailabilityZonesEnabled = isAvailabilityZonesEnabled;
            BillingType = billingType;
            KeyVaultProperties = keyVaultProperties;
            LastModifiedDate = lastModifiedDate;
            CreatedDate = createdDate;
            AssociatedWorkspaces = associatedWorkspaces;
            CapacityReservationProperties = capacityReservationProperties;
        }

        /// <summary> The identity of the resource. </summary>
        public Identity Identity { get; set; }
        /// <summary> The sku properties. </summary>
        public ClusterSku Sku { get; set; }
        /// <summary> The ID associated with the cluster. </summary>
        public string ClusterId { get; }
        /// <summary> The provisioning state of the cluster. </summary>
        public ClusterEntityStatus? ProvisioningState { get; }
        /// <summary> Configures whether cluster will use double encryption. This Property can not be modified after cluster creation. Default value is &apos;true&apos;. </summary>
        public bool? IsDoubleEncryptionEnabled { get; set; }
        /// <summary> Sets whether the cluster will support availability zones. This can be set as true only in regions where Azure Data Explorer support Availability Zones. This Property can not be modified after cluster creation. Default value is &apos;true&apos; if region supports Availability Zones. </summary>
        public bool? IsAvailabilityZonesEnabled { get; set; }
        /// <summary> The cluster&apos;s billing type. </summary>
        public BillingType? BillingType { get; set; }
        /// <summary> The associated key properties. </summary>
        public KeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> The last time the cluster was updated. </summary>
        public string LastModifiedDate { get; }
        /// <summary> The cluster creation time. </summary>
        public string CreatedDate { get; }
        /// <summary> The list of Log Analytics workspaces associated with the cluster. </summary>
        public IList<AssociatedWorkspace> AssociatedWorkspaces { get; }
        /// <summary> Additional properties for capacity reservation. </summary>
        public CapacityReservationProperties CapacityReservationProperties { get; set; }
    }
}
