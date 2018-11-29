using BehavioralHealth.SharedKernel.Domain;
using System;

namespace BehavioralHealth.Domain.ValueObjects
{

    public class DrugUse : ValueObjectBase<DrugUse>
    {
        public override bool Equals(DrugUse other)
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