using BehavioralHealth.SharedKernel.Domain;
using System;

namespace BehavioralHealth.Domain.ValueObjects
{

    public class EmploymentStatus : ValueObjectBase<EmploymentStatus>
    {
        public override bool Equals(EmploymentStatus other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
