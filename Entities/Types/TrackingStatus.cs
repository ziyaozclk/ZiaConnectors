using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Entities.Types
{
    public enum TrackingStatus
    {
        PackageAddedToSystem,
        PackageScannedByViaDC,
        PackageScannedByViaBode,
        PackageScannedByViaPunt,
        PackageDeliveredToViaGebruiker,
        PackagePickedUpByViaGebruiker,
        PackageVerifiedByViaGebruiker,
        PackageGivenToViaBode,
        PackageGivenToViaPunt,
        PackageGivenToViaDC,
        PackageGivenToExternal
    }
}
