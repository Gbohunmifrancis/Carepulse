using System;

namespace Carepulse_Backend.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }  // Changed to Guid
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string PrimaryPhysician { get; set; }
        public string InsuranceProvider { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string Allergies { get; set; }
        public string CurrentMedication { get; set; }
        public string FamilyMedicalHistory { get; set; }
        public string PastMedicalHistory { get; set; }
        public IdentificationType IdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public string IdentificationDocuments { get; set; }  // File paths
        public bool TreatmentConsent { get; set; }
        public bool DisclosureConsent { get; set; }
        public bool PrivacyConsent { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum IdentificationType
    {
        BirthCertificate,
        DriversLicense,
        MedicalInsuranceCard,
        MilitaryIdCard,
        NationalIdentityCard,
        Passport,
        ResidentAlienCard,
        SocialSecurityCard,
        StateIdCard,
        StudentIdCard,
        VoterIdCard
    }
}