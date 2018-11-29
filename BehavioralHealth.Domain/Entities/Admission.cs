using System;
using BehavioralHealth.Domain.ValueObjects;

namespace BehavioralHealth.Domain.Domain
{
    public class Admission
    {
        private readonly int id;
        private readonly DateTime dateOfFirstContact;
        private readonly DateTime admissionDate;
        private readonly bool completelyPaidByMedicaid;
        private readonly LevelOfCare levelOfCare;
        private readonly ReferredBy referredBy;
        private readonly MaritalStatus maritalStatus;
        private readonly EducationLevel educationLevel;
        private readonly EducationEnrollment educationEnrollment;
        private readonly EmploymentStatus employmentStatus;
        private readonly SourceOfIncomeSupport sourceOfIncomeSupport;
        private readonly LivingArrangement livingArrangement;
        private readonly PriorAODTxtEpisodes priorAODTxtEpisodes;
        private readonly bool mentalHealthHistory;
        private readonly Diagnoses diagnoses;
        private readonly OpioidReplacementTherapy opioidReplacementTherapy;
        private readonly int numberOfChildrenUnder18;
        private readonly SpecialPopulation specialPopulation;
        private readonly bool childBirthWithinLast5Years;
        private readonly int numberOfBirths;
        private readonly bool clientPregnant;
        private readonly StageOfPregnancy stageOfPregnancy;
        private readonly MilitaryStatus militaryStatus;
        private readonly bool servedInIraq;
        private readonly bool servedInAfghanistan;
        private readonly int alcoholAgeOfFirstIntox;
        private readonly DrugUse drugUse;
        private readonly int numberOfArrestsPast30Days;
        private readonly Reimbursement reimbursement;
        private readonly SelfHelp selfHelp;

        public Admission(int id, DateTime dateOfFirstContact, DateTime admissionDate, bool completelyPaidByMedicaid, LevelOfCare levelOfCare, ReferredBy referredBy, MaritalStatus maritalStatus, EducationLevel educationLevel, EducationEnrollment educationEnrollment, EmploymentStatus employmentStatus, SourceOfIncomeSupport sourceOfIncomeSupport, LivingArrangement livingArrangement, PriorAODTxtEpisodes priorAODTxtEpisodes, bool mentalHealthHistory, Diagnoses diagnoses, OpioidReplacementTherapy opioidReplacementTherapy, int numberOfChildrenUnder18, SpecialPopulation specialPopulation, bool childBirthWithinLast5Years, int numberOfBirths, bool clientPregnant, StageOfPregnancy stageOfPregnancy, MilitaryStatus militaryStatus, bool servedInIraq, bool servedInAfghanistan, int alcoholAgeOfFirstIntox, DrugUse drugUse, int numberOfArrestsPast30Days, Reimbursement reimbursement, SelfHelp selfHelp)
        {
            this.id = id;
            if (admissionDate < dateOfFirstContact)
            {
                throw new ArgumentException("Admission Date cannot be before Date of First Contact", "Admission Date");
            }
            this.dateOfFirstContact = dateOfFirstContact;
            this.admissionDate = admissionDate;
            this.completelyPaidByMedicaid = completelyPaidByMedicaid;
            this.levelOfCare = levelOfCare;
            this.referredBy = referredBy;
            this.maritalStatus = maritalStatus;
            this.educationLevel = educationLevel;
            this.educationEnrollment = educationEnrollment;
            this.employmentStatus = employmentStatus;
            this.sourceOfIncomeSupport = sourceOfIncomeSupport;
            this.livingArrangement = livingArrangement;
            this.priorAODTxtEpisodes = priorAODTxtEpisodes;
            this.mentalHealthHistory = mentalHealthHistory;
            this.diagnoses = diagnoses;
            this.opioidReplacementTherapy = opioidReplacementTherapy;
            this.numberOfChildrenUnder18 = numberOfChildrenUnder18;
            this.specialPopulation = specialPopulation;
            this.childBirthWithinLast5Years = childBirthWithinLast5Years;
            this.numberOfBirths = numberOfBirths;
            this.clientPregnant = clientPregnant;
            this.stageOfPregnancy = stageOfPregnancy;
            this.militaryStatus = militaryStatus;
            this.servedInIraq = servedInIraq;
            this.servedInAfghanistan = servedInAfghanistan;
            this.alcoholAgeOfFirstIntox = alcoholAgeOfFirstIntox;
            this.drugUse = drugUse;
            this.numberOfArrestsPast30Days = numberOfArrestsPast30Days;
            this.reimbursement = reimbursement;
            this.selfHelp = selfHelp;
        }
    }
}