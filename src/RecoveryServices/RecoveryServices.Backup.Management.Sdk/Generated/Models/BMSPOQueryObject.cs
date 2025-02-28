// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Filters to list items that can be backed up.
    /// </summary>
    public partial class BmspoQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BmspoQueryObject class.
        /// </summary>
        public BmspoQueryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BmspoQueryObject class.
        /// </summary>

        /// <param name="backupManagementType">Backup management type.
        /// Possible values include: &#39;Invalid&#39;, &#39;AzureIaasVM&#39;, &#39;MAB&#39;, &#39;DPM&#39;,
        /// &#39;AzureBackupServer&#39;, &#39;AzureSql&#39;, &#39;AzureStorage&#39;, &#39;AzureWorkload&#39;,
        /// &#39;DefaultBackup&#39;</param>

        /// <param name="workloadType">Workload type
        /// Possible values include: &#39;Invalid&#39;, &#39;VM&#39;, &#39;FileFolder&#39;, &#39;AzureSqlDb&#39;,
        /// &#39;SQLDB&#39;, &#39;Exchange&#39;, &#39;Sharepoint&#39;, &#39;VMwareVM&#39;, &#39;SystemState&#39;, &#39;Client&#39;,
        /// &#39;GenericDataSource&#39;, &#39;SQLDataBase&#39;, &#39;AzureFileShare&#39;, &#39;SAPHanaDatabase&#39;,
        /// &#39;SAPAseDatabase&#39;, &#39;SAPHanaDBInstance&#39;</param>

        /// <param name="containerName">Full name of the container whose Protectable Objects should be returned.
        /// </param>

        /// <param name="status">Backup status query parameter.
        /// </param>

        /// <param name="friendlyName">Friendly name.
        /// </param>
        public BmspoQueryObject(string backupManagementType = default(string), string workloadType = default(string), string containerName = default(string), string status = default(string), string friendlyName = default(string))

        {
            this.BackupManagementType = backupManagementType;
            this.WorkloadType = workloadType;
            this.ContainerName = containerName;
            this.Status = status;
            this.FriendlyName = friendlyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets backup management type. Possible values include: &#39;Invalid&#39;, &#39;AzureIaasVM&#39;, &#39;MAB&#39;, &#39;DPM&#39;, &#39;AzureBackupServer&#39;, &#39;AzureSql&#39;, &#39;AzureStorage&#39;, &#39;AzureWorkload&#39;, &#39;DefaultBackup&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType {get; set; }

        /// <summary>
        /// Gets or sets workload type Possible values include: &#39;Invalid&#39;, &#39;VM&#39;, &#39;FileFolder&#39;, &#39;AzureSqlDb&#39;, &#39;SQLDB&#39;, &#39;Exchange&#39;, &#39;Sharepoint&#39;, &#39;VMwareVM&#39;, &#39;SystemState&#39;, &#39;Client&#39;, &#39;GenericDataSource&#39;, &#39;SQLDataBase&#39;, &#39;AzureFileShare&#39;, &#39;SAPHanaDatabase&#39;, &#39;SAPAseDatabase&#39;, &#39;SAPHanaDBInstance&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workloadType")]
        public string WorkloadType {get; set; }

        /// <summary>
        /// Gets or sets full name of the container whose Protectable Objects should be
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "containerName")]
        public string ContainerName {get; set; }

        /// <summary>
        /// Gets or sets backup status query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }

        /// <summary>
        /// Gets or sets friendly name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName {get; set; }
    }
}