using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PlantAcceptance
    {
        public long Id { get; set; }
        public string MachineType { get; set; }
        public string Weight { get; set; }
        public string Company { get; set; }
        public string Site { get; set; }
        public string GangLeader { get; set; }
        public string PlantFreeFromDamageToBody { get; set; }
        public string MachineFreeFromCracksBoom { get; set; }
        public string MachineThoroughlyGreased { get; set; }
        public string MountingsAttachedSecurely { get; set; }
        public string SafetyLabelsInPlace { get; set; }
        public string SafeWorkingLoadDisplayed { get; set; }
        public string MachineClean { get; set; }
        public string WindowsFreeFromChipsCracks { get; set; }
        public string TyresFreeFromDamage { get; set; }
        public string StepsHandrailsGoodCondition { get; set; }
        public string MachineFreeFromLeaks { get; set; }
        public string LightsBeaconsOperational { get; set; }
        public string RegPlateVisible { get; set; }
        public string WipersOperational { get; set; }
        public string DoorsLocksHingesGoodCondition { get; set; }
        public string QuickHitchFunctionalSecure { get; set; }
        public string TowingSocketSecure { get; set; }
        public string RoadTaxDisplayed { get; set; }
        public string RearHitchMechanismOperate { get; set; }
        public string RollOverPreventionFunctional { get; set; }
        public string CertificateConformityCorrect { get; set; }
        public string MachineSafe { get; set; }
        public string SubmittedBy { get; set; }
        public string DocumentDate { get; set; }
        public string PathToPdf { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
