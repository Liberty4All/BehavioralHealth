using BehavioralHealth.Domain;
using BehavioralHealth.Domain.Domain;
using BehavioralHealth.Domain.ValueObjects;
using FluentAssertions;
using FluentAssertions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BehavioralHealth.Tests
{
    [TestClass]
    public class AdmissionTests
    {
        int id = 0;

        Client currentClient = new Client(5, "Bob", "Tester", 10.October(1964), new Gender(GenderType.Male), new Race(RaceType.White), new Ethnicity(EthnicityType.NotOfHispanicOrigin));
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
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                 ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentException>()
                .WithMessage("Admission Date cannot be before Date of First Contact\nParameter name: Admission Date");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_DateOfFirstContactTooOld_InvalidValueError()
        {
            // Arrange
            Initialize();
            DateOfFirstContact = 31.December(1999);

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                 ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage("Date of First Contact cannot be before January 1, 2000\nParameter name: Date of First Contact");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_AdmissionDateTooOld_InvalidValueError()
        {
            // Arrange
            Initialize();
            AdmissionDate = 31.December(1999);

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage("Admission Date cannot be before January 1, 2000\nParameter name: Admission Date");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_LevelOfCareNull_NullValueError()
        {
            // Arrange
            Initialize();
            LevelOfCare = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Level of Care cannot be null\nParameter name: Level of Care");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_ReferredByNull_NullValueError()
        {
            // Arrange
            Initialize();
            ReferredBy = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Referred By cannot be null\nParameter name: Referred By");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_MaritalStatusNull_NullValueError()
        {
            // Arrange
            Initialize();
            MaritalStatus = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Marital Status cannot be null\nParameter name: Marital Status");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_EducationLevelNull_NullValueError()
        {
            // Arrange
            Initialize();
            EducationLevel = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Education Level cannot be null\nParameter name: Education Level");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_EducationEnrollmentNull_NullValueError()
        {
            // Arrange
            Initialize();
            EducationEnrollment = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Education Enrollment cannot be null\nParameter name: Education Enrollment");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_EmploymentStatusNull_NullValueError()
        {
            // Arrange
            Initialize();
            EmploymentStatus = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Employment Status cannot be null\nParameter name: Employment Status");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_SourceOfIncomeSupportNull_NullValueError()
        {
            // Arrange
            Initialize();
            SourceOfIncomeSupport = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentNullException>()
                .WithMessage("Source of Income Support cannot be null\nParameter name: Source of Income Support");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_NumberOfChildrenUnder18LessThanZero_ValueOutOfRangeError()
        {
            // Arrange
            Initialize();
            NumberOfChildrenUnder18 = -1;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage("Number of Children Under 18 cannot be less than 0\nParameter name: Number of Children Under 18");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_NumberOfChildrenUnder18MoreThan99_ValueOutOfRangeError()
        {
            // Arrange
            Initialize();
            NumberOfChildrenUnder18 = 100;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage("Number of Children Under 18 cannot be more than 99\nParameter name: Number of Children Under 18");
        }

        [TestMethod]
        [TestCategory("Undefined")]
        public void Create_ClientIsNull_NullValueError()
        {
            // Arrange
            Initialize();
            Client currentClient = null;

            // Act
            Action result = () => new Admission(id, currentClient, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
                ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
                LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
                NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
                StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
                NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

            // Assert
            result.Should().Throw<ArgumentException>()
                .WithMessage("Client cannot be null\nParameter name: Admission Client");
        }

        //[TestMethod]
        //[TestCategory("Unit")]
        //public void Create_ChildBirthWithinLast5YearsTrueAndClientIsMale_InvalidValueError()
        //{
        //    // Arrange
        //    Initialize();
        //    ChildBirthWithinLast5Years = true;
        //    Client currentClient = new Client(5, "Bob", "Tester", 10.October(1964), new Gender(GenderType.Male), new Race(RaceType.White), new Ethnicity(EthnicityType.NotOfHispanicOrigin));

        //    // Act
        //    Action result = () => new Admission(id, DateOfFirstContact, AdmissionDate, CompletelyPaidByMedicaid, LevelOfCare,
        //        ReferredBy, MaritalStatus, EducationLevel, EducationEnrollment, EmploymentStatus, SourceOfIncomeSupport,
        //        LivingArrangement, PriorAODTxtEpisodes, MentalHealthHistory, Diagnoses, OpioidReplacementTherapy,
        //        NumberOfChildrenUnder18, SpecialPopulation, ChildBirthWithinLast5Years, NumberOfBirths, ClientPregnant,
        //        StageOfPregnancy, MilitaryStatus, ServedInIraq, ServedInAfghanistan, AlcoholAgeOfFirstIntox, DrugUse,
        //        NumberOfArrestsPast30Days, Reimbursement, SelfHelp);

        //    // Assert
        //    result.Should().Throw<ArgumentOutOfRangeException>()
        //        .WithMessage("Childbirth within last 5 years cannot be true for client gender male\nParameter name: Childbirth Within Last 5 Years");
        //}
        //Start here: Special Population
    }
}
