### Example 1: List by resource group
```powershell
Get-AzSphereDevice -CatalogName test2024 -ResourceGroupName "joyer-test" -GroupName testdevicegroup -ProductName product2024
```

```output
Name                                                                                                                             SystemDataCreatedAt SystemDataCreatedBy SystemDataCreatedByType SystemDataLastModifiedAt SystemDataLastModifiedBy System 
                                                                                                                                                                                                                                                   DataLa 
                                                                                                                                                                                                                                                   stModi 
                                                                                                                                                                                                                                                   fiedBy 
                                                                                                                                                                                                                                                   Type   
----                                                                                                                             ------------------- ------------------- ----------------------- ------------------------ ------------------------ ------ 
dbb0e0cb8bd961a6129096e1e8a1375ac1fa274f030c08161b37ae3bc5a94f443bdb628cf257bc5bc810d8768c03b6f5ca301a35cd0169f56a49624255964560
b15332603ba55fb52b00fec8549fdaa46b7fb6ba35694bc8943131ccb4b302846d224580a27880a2996b9fd4f1b2699400b1627059b6a90d67dd29e2984ee147
5d257fbcf76a5853832122d9b0e2410daa1438e3c1cde005162a837a7535c08973cc819a50cf8eb724ffc88dada06b40bee6010e82a8f84d2fef0fc263061d67
```

This command gets list of device resources by resource group.

### Example 2: Get specific resource with specified resource group
```powershell
Get-AzSphereDevice -CatalogName test2024 -ResourceGroupName "joyer-test" -GroupName testdevicegroup -ProductName product2024 -Name dbb0e0cb8bd961a6129096e1e8a1375ac1fa274f030c08161b37ae3bc5a94f443bdb628cf257bc5bc810d8768c03b6f5ca301a35cd0169f56a49624255964560
```

```output
ChipSku                      : MT3620AN
DeviceId                     : dbb0e0cb8bd961a6129096e1e8a1375ac1fa274f030c08161b37ae3bc5a94f443bdb628cf257bc5bc810d8768c03b6f5ca301a35cd0169f56a49624255964560
Id                           : /subscriptions/d1cd48f9-b94b-4645-9632-634b440db393/resourceGroups/joyer-test/providers/Microsoft.AzureSphere/catalogs/test2024/products/product2024/deviceGroups/testdevicegroup/devices/dbb0e0cb8bd961a6129096e1e8a1375ac1fa274f030c08161b37ae3bc5a94f443bdb628cf257bc5bc810d8768c03b6f5ca301a35cd0169f56a49624255964560
LastAvailableOSVersion       : 
LastInstalledOSVersion       : 
LastOSUpdateUtc              : 
LastUpdateRequestUtc         : 
Name                         : dbb0e0cb8bd961a6129096e1e8a1375ac1fa274f030c08161b37ae3bc5a94f443bdb628cf257bc5bc810d8768c03b6f5ca301a35cd0169f56a49624255964560
ProvisioningState            : Succeeded
ResourceGroupName            : joyer-test
SystemDataCreatedAt          : 
SystemDataCreatedBy          : 
SystemDataCreatedByType      : 
SystemDataLastModifiedAt     : 
SystemDataLastModifiedBy     : 
SystemDataLastModifiedByType : 
Type                         : Microsoft.AzureSphere/catalogs/products/deviceGroups/devices
```

This command gets specific device resource with specified resource group.

