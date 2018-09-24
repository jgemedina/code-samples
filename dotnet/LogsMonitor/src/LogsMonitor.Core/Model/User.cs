using System;
using System.Linq;

namespace LogsMonitor.Core.Model
{
    public sealed class User : IEquatable<User>
    {
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

#region Object equality
        public bool Equals(User other)
        {
            if (object.ReferenceEquals(other, null))
                return false;
            
            return string.Equals(this.EmailAddress, other.EmailAddress, StringComparison.OrdinalIgnoreCase);
        }
#endregion

#region Overrides
        public static bool operator ==(User a, User b)
        {
            if (object.ReferenceEquals(a, null))
                return object.ReferenceEquals(b, null);

            return a.Equals(b);
        }

        public static bool operator !=(User a, User b) => !(a == b);

        public override bool Equals(object other) => Equals(other as User);

        public override int GetHashCode() => EmailAddress.GetHashCode();

        public override string ToString()
        {
            var middleInitial = MiddleName != null ? string.Concat(MiddleName.First(), ". ") : string.Empty;

            return string.Concat($"{GivenName} {middleInitial}{LastName} ({EmailAddress})");
        }
#endregion
    }
}