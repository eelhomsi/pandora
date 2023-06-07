using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_04_01.ReplicationProtectedItems;

internal class Definition : ResourceDefinition
{
    public string Name => "ReplicationProtectedItems";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AddDisksOperation(),
        new ApplyRecoveryPointOperation(),
        new CreateOperation(),
        new DeleteOperation(),
        new FailoverCancelOperation(),
        new FailoverCommitOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByReplicationProtectionContainersOperation(),
        new PlannedFailoverOperation(),
        new PurgeOperation(),
        new RemoveDisksOperation(),
        new RepairReplicationOperation(),
        new ReprotectOperation(),
        new ResolveHealthErrorsOperation(),
        new SwitchProviderOperation(),
        new TestFailoverOperation(),
        new TestFailoverCleanupOperation(),
        new UnplannedFailoverOperation(),
        new UpdateOperation(),
        new UpdateApplianceOperation(),
        new UpdateMobilityServiceOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AgentUpgradeBlockedReasonConstant),
        typeof(AutoProtectionOfDataDiskConstant),
        typeof(DisableProtectionReasonConstant),
        typeof(DiskAccountTypeConstant),
        typeof(DiskReplicationProgressHealthConstant),
        typeof(EthernetAddressTypeConstant),
        typeof(HealthErrorCustomerResolvabilityConstant),
        typeof(InMageRcmFailbackRecoveryPointTypeConstant),
        typeof(LicenseTypeConstant),
        typeof(MobilityAgentUpgradeStateConstant),
        typeof(MultiVMGroupCreateOptionConstant),
        typeof(PlannedFailoverStatusConstant),
        typeof(RecoveryPointTypeConstant),
        typeof(ResyncStateConstant),
        typeof(SqlServerLicenseTypeConstant),
        typeof(VMEncryptionTypeConstant),
        typeof(VMReplicationProgressHealthConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(A2AAddDisksInputModel),
        typeof(A2AApplyRecoveryPointInputModel),
        typeof(A2ACrossClusterMigrationApplyRecoveryPointInputModel),
        typeof(A2ACrossClusterMigrationEnableProtectionInputModel),
        typeof(A2ACrossClusterMigrationReplicationDetailsModel),
        typeof(A2AEnableProtectionInputModel),
        typeof(A2AProtectedDiskDetailsModel),
        typeof(A2AProtectedManagedDiskDetailsModel),
        typeof(A2ARemoveDisksInputModel),
        typeof(A2AReplicationDetailsModel),
        typeof(A2AReprotectInputModel),
        typeof(A2ATestFailoverInputModel),
        typeof(A2AUnplannedFailoverInputModel),
        typeof(A2AUnprotectedDiskDetailsModel),
        typeof(A2AUpdateReplicationProtectedItemInputModel),
        typeof(A2AVMDiskInputDetailsModel),
        typeof(A2AVMManagedDiskInputDetailsModel),
        typeof(A2AVMManagedDiskUpdateDetailsModel),
        typeof(AddDisksInputModel),
        typeof(AddDisksInputPropertiesModel),
        typeof(AddDisksProviderSpecificInputModel),
        typeof(ApplyRecoveryPointInputModel),
        typeof(ApplyRecoveryPointInputPropertiesModel),
        typeof(ApplyRecoveryPointProviderSpecificInputModel),
        typeof(AzureToAzureVMSyncedConfigDetailsModel),
        typeof(AzureVMDiskDetailsModel),
        typeof(CurrentScenarioDetailsModel),
        typeof(DisableProtectionInputModel),
        typeof(DisableProtectionInputPropertiesModel),
        typeof(DisableProtectionProviderSpecificInputModel),
        typeof(DiskDetailsModel),
        typeof(DiskEncryptionInfoModel),
        typeof(DiskEncryptionKeyInfoModel),
        typeof(EnableProtectionInputModel),
        typeof(EnableProtectionInputPropertiesModel),
        typeof(EnableProtectionProviderSpecificInputModel),
        typeof(HealthErrorModel),
        typeof(HyperVReplicaAzureApplyRecoveryPointInputModel),
        typeof(HyperVReplicaAzureDiskInputDetailsModel),
        typeof(HyperVReplicaAzureEnableProtectionInputModel),
        typeof(HyperVReplicaAzureFailbackProviderInputModel),
        typeof(HyperVReplicaAzureManagedDiskDetailsModel),
        typeof(HyperVReplicaAzurePlannedFailoverProviderInputModel),
        typeof(HyperVReplicaAzureReplicationDetailsModel),
        typeof(HyperVReplicaAzureReprotectInputModel),
        typeof(HyperVReplicaAzureTestFailoverInputModel),
        typeof(HyperVReplicaAzureUnplannedFailoverInputModel),
        typeof(HyperVReplicaAzureUpdateReplicationProtectedItemInputModel),
        typeof(HyperVReplicaBaseReplicationDetailsModel),
        typeof(HyperVReplicaBlueReplicationDetailsModel),
        typeof(HyperVReplicaReplicationDetailsModel),
        typeof(IPConfigDetailsModel),
        typeof(IPConfigInputDetailsModel),
        typeof(InMageAgentDetailsModel),
        typeof(InMageAzureV2ApplyRecoveryPointInputModel),
        typeof(InMageAzureV2DiskInputDetailsModel),
        typeof(InMageAzureV2EnableProtectionInputModel),
        typeof(InMageAzureV2ManagedDiskDetailsModel),
        typeof(InMageAzureV2ProtectedDiskDetailsModel),
        typeof(InMageAzureV2ReplicationDetailsModel),
        typeof(InMageAzureV2ReprotectInputModel),
        typeof(InMageAzureV2SwitchProviderBlockingErrorDetailsModel),
        typeof(InMageAzureV2SwitchProviderDetailsModel),
        typeof(InMageAzureV2SwitchProviderProviderInputModel),
        typeof(InMageAzureV2TestFailoverInputModel),
        typeof(InMageAzureV2UnplannedFailoverInputModel),
        typeof(InMageAzureV2UpdateReplicationProtectedItemInputModel),
        typeof(InMageDisableProtectionProviderSpecificInputModel),
        typeof(InMageDiskExclusionInputModel),
        typeof(InMageDiskSignatureExclusionOptionsModel),
        typeof(InMageEnableProtectionInputModel),
        typeof(InMageProtectedDiskDetailsModel),
        typeof(InMageRcmAgentUpgradeBlockingErrorDetailsModel),
        typeof(InMageRcmApplyRecoveryPointInputModel),
        typeof(InMageRcmDiscoveredProtectedVMDetailsModel),
        typeof(InMageRcmDiskInputModel),
        typeof(InMageRcmDisksDefaultInputModel),
        typeof(InMageRcmEnableProtectionInputModel),
        typeof(InMageRcmFailbackDiscoveredProtectedVMDetailsModel),
        typeof(InMageRcmFailbackMobilityAgentDetailsModel),
        typeof(InMageRcmFailbackNicDetailsModel),
        typeof(InMageRcmFailbackPlannedFailoverProviderInputModel),
        typeof(InMageRcmFailbackProtectedDiskDetailsModel),
        typeof(InMageRcmFailbackReplicationDetailsModel),
        typeof(InMageRcmFailbackReprotectInputModel),
        typeof(InMageRcmFailbackSyncDetailsModel),
        typeof(InMageRcmLastAgentUpgradeErrorDetailsModel),
        typeof(InMageRcmMobilityAgentDetailsModel),
        typeof(InMageRcmNicDetailsModel),
        typeof(InMageRcmNicInputModel),
        typeof(InMageRcmProtectedDiskDetailsModel),
        typeof(InMageRcmReplicationDetailsModel),
        typeof(InMageRcmReprotectInputModel),
        typeof(InMageRcmSyncDetailsModel),
        typeof(InMageRcmTestFailoverInputModel),
        typeof(InMageRcmUnplannedFailoverInputModel),
        typeof(InMageRcmUpdateApplianceForReplicationProtectedItemInputModel),
        typeof(InMageRcmUpdateReplicationProtectedItemInputModel),
        typeof(InMageReplicationDetailsModel),
        typeof(InMageReprotectInputModel),
        typeof(InMageTestFailoverInputModel),
        typeof(InMageUnplannedFailoverInputModel),
        typeof(InMageVolumeExclusionOptionsModel),
        typeof(InitialReplicationDetailsModel),
        typeof(InnerHealthErrorModel),
        typeof(InputEndpointModel),
        typeof(KeyEncryptionKeyInfoModel),
        typeof(OSDetailsModel),
        typeof(OSDiskDetailsModel),
        typeof(PlannedFailoverInputModel),
        typeof(PlannedFailoverInputPropertiesModel),
        typeof(PlannedFailoverProviderSpecificFailoverInputModel),
        typeof(RemoveDisksInputModel),
        typeof(RemoveDisksInputPropertiesModel),
        typeof(RemoveDisksProviderSpecificInputModel),
        typeof(ReplicationProtectedItemModel),
        typeof(ReplicationProtectedItemPropertiesModel),
        typeof(ReplicationProviderSpecificSettingsModel),
        typeof(ResolveHealthErrorModel),
        typeof(ResolveHealthInputModel),
        typeof(ResolveHealthInputPropertiesModel),
        typeof(ReverseReplicationInputModel),
        typeof(ReverseReplicationInputPropertiesModel),
        typeof(ReverseReplicationProviderSpecificInputModel),
        typeof(SwitchProviderInputModel),
        typeof(SwitchProviderInputPropertiesModel),
        typeof(SwitchProviderProviderSpecificInputModel),
        typeof(TestFailoverCleanupInputModel),
        typeof(TestFailoverCleanupInputPropertiesModel),
        typeof(TestFailoverInputModel),
        typeof(TestFailoverInputPropertiesModel),
        typeof(TestFailoverProviderSpecificInputModel),
        typeof(UnplannedFailoverInputModel),
        typeof(UnplannedFailoverInputPropertiesModel),
        typeof(UnplannedFailoverProviderSpecificInputModel),
        typeof(UpdateApplianceForReplicationProtectedItemInputModel),
        typeof(UpdateApplianceForReplicationProtectedItemInputPropertiesModel),
        typeof(UpdateApplianceForReplicationProtectedItemProviderSpecificInputModel),
        typeof(UpdateDiskInputModel),
        typeof(UpdateMobilityServiceRequestModel),
        typeof(UpdateMobilityServiceRequestPropertiesModel),
        typeof(UpdateReplicationProtectedItemInputModel),
        typeof(UpdateReplicationProtectedItemInputPropertiesModel),
        typeof(UpdateReplicationProtectedItemProviderInputModel),
        typeof(VMNicDetailsModel),
        typeof(VMNicInputDetailsModel),
    };
}
