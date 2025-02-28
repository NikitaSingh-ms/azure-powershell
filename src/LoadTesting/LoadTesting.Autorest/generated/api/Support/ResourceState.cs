// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support
{

    /// <summary>Resources provisioning states.</summary>
    public partial struct ResourceState :
        System.IEquatable<ResourceState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState Deleted = @"Deleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState Succeeded = @"Succeeded";

        /// <summary>the value for an instance of the <see cref="ResourceState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResourceState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ResourceState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResourceState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResourceState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResourceState && Equals((ResourceState)obj);
        }

        /// <summary>Returns hashCode for enum ResourceState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResourceState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResourceState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResourceState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResourceState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceState" />.</param>

        public static implicit operator ResourceState(string value)
        {
            return new ResourceState(value);
        }

        /// <summary>Implicit operator to convert ResourceState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResourceState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResourceState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState e1, Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResourceState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState e1, Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ResourceState e2)
        {
            return e2.Equals(e1);
        }
    }
}