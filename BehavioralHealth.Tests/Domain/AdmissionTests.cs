using BehavioralHealth.Domain;
using BehavioralHealth.Domain.Domain;
using BehavioralHealth.Domain.ValueObjects;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BehavioralHealth.Tests
{
    [TestClass]
    public class AdmissionTests
    {
        int id = 0;

        DateTime DateOfFirstContact;
        DateTime AdmissionDate;
        bool CompletelyPaidByMedicaid;
        LevelOfCare LevelOfCare;
        //"NotConsistentWithAssessment" type="bh:NotConsistentWithAssessmentDef" minOccurs="0"/>
        //"GamblingDisorderScreen" type="boolean" minOccurs="0"/>
        //"GamblingDisorderAssessment" type="boolean" minOccurs="0"/>
        //"ProviderEpisodeNumber" type="bh:ProviderEpisodeNumberDef" minOccurs="0"/>
        ReferredBy ReferredBy;
        MaritalStatus MaritalStatus;
        EducationLevel EducationLevel;
        EducationEnrollment EducationEnrollment;
        //MHEducationType MHEducationType;
        EmploymentStatus EmploymentStatus;
        SourceOfIncomeSupport SourceOfIncomeSupport;
        LivingArrangement LivingArrangement;
        PriorAODTxtEpisodes PriorAODTxtEpisodes;
        bool MentalHealthHistory;
        Diagnoses Diagnoses;
        OpioidReplacementTherapy OpioidReplacementTherapy;
        int NumberOfChildrenUnder18;
        SpecialPopulation SpecialPopulation;
        bool ChildBirthWithinLast5Years;
        int NumberOfBirths;
        bool ClientPregnant;
        StageOfPregnancy StageOfPregnancy;
        MilitaryStatus MilitaryStatus;
        bool ServedInIraq;
        bool ServedInAfghanistan;
        int AlcoholAgeOfFirstIntox;
        DrugUse DrugUse;
        int NumberOfArrestsPast30Days;
        Reimbursement Reimbursement;
        SelfHelp SelfHelp;
        //"StarSI" type="bh:AdmissionStarSIDef" minOccurs="0"/>
        //"FamilyReunification" type="bh:AdmissionFamilyReunificationDef" minOccurs="0"/>
        //"WomensProgram" type="bh:AdmissionWomensProgramDef" minOccurs="0"/>
        //"PayingBoard" type="bh:BoardNumberDef" minOccurs="1" maxOccurs="unbounded"/>
        //"GAF" type="integer" minOccurs="0" maxOccurs="1"/>
        //"MHSecondary" type="bh:AddMHSecondaryDef" minOccurs="0" maxOccurs="1"/>

        public void Initialize()
        {
            DateOfFirstContact = DateTime.Now.Date.AddMonths(-5);
            AdmissionDate = DateOfFirstContact.AddDays(1);
            CompletelyPaidByMedicaid = false;
            LevelOfCare = new LevelOfCare();
            //"NotConsistentWithAssessment" type="bh:NotConsistentWithAssessmentDef" minOccurs="0"/>
            //"GamblingDisorderScreen" type="boolean" minOccurs="0"/>
            //"GamblingDisorderAssessment" type="boolean" minOccurs="0"/>
            //"ProviderEpisodeNumber" type="bh:ProviderEpisodeNumberDef" minOccurs="0"/>
            ReferredBy = new ReferredBy();
            MaritalStatus = new MaritalStatus();
            EducationLevel = new EducationLevel();
            EducationEnrollment = new EducationEnrollment();
            EmploymentStatus = new EmploymentStatus();
            SourceOfIncomeSupport = new SourceOfIncomeSupport();
            LivingArrangement = new LivingArrangement();
            PriorAODTxtEpisodes = new PriorAODTxtEpisodes();
            MentalHealthHistory = true;
            Diagnoses = new Diagnoses();
            OpioidReplacementTherapy = new OpioidReplacementTherapy();
            NumberOfChildrenUnder18 = 2;
            SpecialPopulation = new SpecialPopulation();
            ChildBirthWithinLast5Years = true;
            NumberOfBirths = 0;
            ClientPregnant = false;
            StageOfPregnancy = new StageOfPregnancy();
            MilitaryStatus = new MilitaryStatus();
            ServedInIraq = false;
            ServedInAfghanistan = false;
            AlcoholAgeOfFirstIntox = 15;
            DrugUse = new DrugUse();
            NumberOfArrestsPast30Days = 0;
            Reimbursement = new Reimbursement();
            SelfHelp = new SelfHelp();
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_AdmissionDateBeforeContactDate_BadAdmissionDateError()
        {
            // Arrange
            Initialize();
            AdmissionDate = DateOfFirstContact.Date.AddDays(-1);

            // Act
            Action result = () => new Admission(id, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                //"NotConsistentWithAssessment" type="bh:NotConsistentWithAssessmentDef" minOccurs="0"/>
            //"GamblingDisorderScreen" type="boolean" minOccurs="0"/>
            //"GamblingDisorderAssessment" type="boolean" minOccurs="0"/>
            //"ProviderEpisodeNumber" type="bh:ProviderEpisodeNumberDef" minOccurs="0"/>
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentException>()
                .WithMessage("Admission Date cannot be before Date of First Contact\nParameter name: Admission Date");
        }

        //[TestMethod]
        //[TestCategory("Unit")]
        //public void Create_LastNameNull_MissingValueError()
        //{
        //    // Arrange
        //    Initialize();
        //    lastName = null;

        //    // Act
        //    Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

        //    // Assert
        //    result.Should().Throw<ArgumentNullException>()
        //        .WithMessage("Missing value\nParameter name: Last Name");
        //}

        //[TestMethod]
        //[TestCategory("Unit")]
        //public void Create_BirthdateTooLongAgo_InvalidValueError()
        //{
        //    // Arrange
        //    Initialize();
        //    birthDate = DateTime.Now.Date.AddYears(-121);

        //    // Act
        //    Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

        //    // Assert
        //    result.Should().Throw<ArgumentOutOfRangeException>()
        //       .WithMessage("More than 120 years ago\nParameter name: Date of Birth");
        //}

        //[TestMethod]
        //[TestCategory("Unit")]
        //public void Create_EthnicityNull_InvalidValueError()
        //{
        //    // Arrange
        //    Initialize();
        //    ethnicity = null;

        //    // Act
        //    Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

        //    // Assert
        //    result.Should().Throw<ArgumentNullException>()
        //        .WithMessage("Missing value\nParameter name: Ethnicity");
        //}

        //[TestMethod]
        //[TestCategory("Unit")]
        //public void Create_GenderNull_InvalidValueError()
        //{
        //    // Arrange
        //    Initialize();
        //    gender = null;

        //    // Act
        //    Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

        //    // Assert
        //    result.Should().Throw<ArgumentNullException>()
        //        .WithMessage("Missing value\nParameter name: Gender");
        //}

        //[TestMethod]
        //[TestCategory("Unit")]
        //public void Create_RaceNull_InvalidValueError()
        //{
        //    // Arrange
        //    Initialize();
        //    race = null;

        //    // Act
        //    Action result = () => new Client(id, firstName, lastName, birthDate, gender, race, ethnicity);

        //    // Assert
        //    result.Should().Throw<ArgumentNullException>()
        //        .WithMessage("Missing value\nParameter name: Race");
        //}
    }
}
