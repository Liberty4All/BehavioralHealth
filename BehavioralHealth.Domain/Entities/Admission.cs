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
        private readonly Client client;

        public Admission(int id, Client client, DateTime dateOfFirstContact, DateTime admissionDate, bool completelyPaidByMedicaid, LevelOfCare levelOfCare, ReferredBy referredBy, MaritalStatus maritalStatus, EducationLevel educationLevel, EducationEnrollment educationEnrollment, EmploymentStatus employmentStatus, SourceOfIncomeSupport sourceOfIncomeSupport, LivingArrangement livingArrangement, PriorAODTxtEpisodes priorAODTxtEpisodes, bool mentalHealthHistory, Diagnoses diagnoses, OpioidReplacementTherapy opioidReplacementTherapy, int numberOfChildrenUnder18, SpecialPopulation specialPopulation, bool childBirthWithinLast5Years, int numberOfBirths, bool clientPregnant, StageOfPregnancy stageOfPregnancy, MilitaryStatus militaryStatus, bool servedInIraq, bool servedInAfghanistan, int alcoholAgeOfFirstIntox, DrugUse drugUse, int numberOfArrestsPast30Days, Reimbursement reimbursement, SelfHelp selfHelp)
        {
            this.id = id;
            RaiseIfClientIsNull("Admission Client", client);
            RaiseIfTooOld("Date of First Contact",dateOfFirstContact, new DateTime(2000,1,1));
            RaiseIfTooOld("Admission Date",admissionDate,new DateTime(2000, 1, 1));
            RaiseIfDateTooEarly("Admission Date", admissionDate, "Date of First Contact", dateOfFirstContact);
            this.dateOfFirstContact = dateOfFirstContact;
            this.admissionDate = admissionDate;
            this.completelyPaidByMedicaid = completelyPaidByMedicaid;

            RaiseIfNull("Level of Care", levelOfCare);
            this.levelOfCare = levelOfCare;

            RaiseIfNull("Referred By", referredBy);
            this.referredBy = referredBy;

            RaiseIfNull("Marital Status", maritalStatus);
            this.maritalStatus = maritalStatus;

            RaiseIfNull("Education Level", educationLevel);
            this.educationLevel = educationLevel;

            RaiseIfNull("Education Enrollment", educationEnrollment);
            this.educationEnrollment = educationEnrollment;

            RaiseIfNull("Employment Status", employmentStatus);
            this.employmentStatus = employmentStatus;

            RaiseIfNull("Source of Income Support", sourceOfIncomeSupport);
            this.sourceOfIncomeSupport = sourceOfIncomeSupport;

            //RaiseIfNull("Living Arrangement", livingArrangement);
            this.livingArrangement = livingArrangement;

            //RaiseIfNull("Prior AOD Treatment Episodes", priorAODTxtEpisodes);
            this.priorAODTxtEpisodes = priorAODTxtEpisodes;

            //RaiseIfNull("", );
            this.mentalHealthHistory = mentalHealthHistory;
            this.diagnoses = diagnoses;
            this.opioidReplacementTherapy = opioidReplacementTherapy;

            RaiseIfNotInRange("Number of Children Under 18", numberOfChildrenUnder18, 0, 99);
            this.numberOfChildrenUnder18 = numberOfChildrenUnder18;

            this.specialPopulation = specialPopulation;

            RaiseIfChildbirthTrueAndClientIsMale("Childbirth Within Last 5 Years", childBirthWithinLast5Years, client.Gender);
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

        private void RaiseIfClientIsNull(string paramName, Client client)
        {
            if (client is null)
            {
                throw new ArgumentException("Client cannot be null", paramName);
            };
        }

        private void RaiseIfChildbirthTrueAndClientIsMale(string paramName, bool childBirthWithinLast5Years, Gender gender)
        {
            throw new NotImplementedException();
        }

        private void RaiseIfNotInRange(string paramName, int paramValue, int lower, int upper)
        {
            if (paramValue < lower)
            {
                throw new ArgumentOutOfRangeException(paramName, $"{paramName} cannot be less than {lower}");
            }
            if (paramValue > upper)
            {
                throw new ArgumentOutOfRangeException(paramName, $"{paramName} cannot be more than {upper}");
            }
        }

        private void RaiseIfNull(string parameterName, object parameter)
        {
            if (parameter is null)
            {
                throw new ArgumentNullException($"{parameterName}", $"{parameterName} cannot be null");
            }
        }

        private void RaiseIfDateTooEarly(string param1, DateTime date1, string param2, DateTime date2)
        {
            if (date1 < date2)
            {
                throw new ArgumentException($"{param1} cannot be before {param2}",param1);
            }
        }

        private static void RaiseIfTooOld(string parameterName, DateTime checkDate, DateTime thresholdDate)
        {
            var dateString = thresholdDate.ToString("MMMM d, yyyy");
            if (checkDate < thresholdDate)
            {
                throw new ArgumentOutOfRangeException($"{parameterName}", $"{parameterName} cannot be before {dateString}");
            }
        }
    }
}