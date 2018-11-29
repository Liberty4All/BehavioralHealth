using BehavioralHealth.SharedKernel.Domain;
using System;

namespace BehavioralHealth.Domain.ValueObjects
{
    public class MaritalStatus : ValueObjectBase<MaritalStatus>
    {
        public override bool Equals(MaritalStatus other)
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
