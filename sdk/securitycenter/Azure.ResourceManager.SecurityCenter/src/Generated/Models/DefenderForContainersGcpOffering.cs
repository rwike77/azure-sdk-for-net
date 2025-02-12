// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The containers GCP offering. </summary>
    public partial class DefenderForContainersGcpOffering : CloudOffering
    {
        /// <summary> Initializes a new instance of DefenderForContainersGcpOffering. </summary>
        public DefenderForContainersGcpOffering()
        {
            OfferingType = OfferingType.DefenderForContainersGcp;
        }

        /// <summary> Initializes a new instance of DefenderForContainersGcpOffering. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="nativeCloudConnection"> The native cloud connection configuration. </param>
        /// <param name="dataPipelineNativeCloudConnection"> The native cloud connection configuration. </param>
        /// <param name="auditLogsAutoProvisioningFlag"> Is audit logs data collection enabled. </param>
        /// <param name="defenderAgentAutoProvisioningFlag"> Is Microsoft Defender for Cloud Kubernetes agent auto provisioning enabled. </param>
        /// <param name="policyAgentAutoProvisioningFlag"> Is Policy Kubernetes agent auto provisioning enabled. </param>
        internal DefenderForContainersGcpOffering(OfferingType offeringType, string description, DefenderForContainersGcpOfferingNativeCloudConnection nativeCloudConnection, DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection dataPipelineNativeCloudConnection, bool? auditLogsAutoProvisioningFlag, bool? defenderAgentAutoProvisioningFlag, bool? policyAgentAutoProvisioningFlag) : base(offeringType, description)
        {
            NativeCloudConnection = nativeCloudConnection;
            DataPipelineNativeCloudConnection = dataPipelineNativeCloudConnection;
            AuditLogsAutoProvisioningFlag = auditLogsAutoProvisioningFlag;
            DefenderAgentAutoProvisioningFlag = defenderAgentAutoProvisioningFlag;
            PolicyAgentAutoProvisioningFlag = policyAgentAutoProvisioningFlag;
            OfferingType = offeringType;
        }

        /// <summary> The native cloud connection configuration. </summary>
        public DefenderForContainersGcpOfferingNativeCloudConnection NativeCloudConnection { get; set; }
        /// <summary> The native cloud connection configuration. </summary>
        public DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection DataPipelineNativeCloudConnection { get; set; }
        /// <summary> Is audit logs data collection enabled. </summary>
        public bool? AuditLogsAutoProvisioningFlag { get; set; }
        /// <summary> Is Microsoft Defender for Cloud Kubernetes agent auto provisioning enabled. </summary>
        public bool? DefenderAgentAutoProvisioningFlag { get; set; }
        /// <summary> Is Policy Kubernetes agent auto provisioning enabled. </summary>
        public bool? PolicyAgentAutoProvisioningFlag { get; set; }
    }
}
