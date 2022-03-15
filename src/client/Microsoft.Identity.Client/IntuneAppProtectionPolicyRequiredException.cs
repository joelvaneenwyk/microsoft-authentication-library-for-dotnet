﻿using System;
namespace Microsoft.Identity.Client
{
    /// <summary>
    /// This exception is thrown when Intune requires app protection policy.
    /// The information in this exception can be used by app to obtain the required 
    /// enrollment ID from Mobile App Management (MAM) SDK.
    /// See https://aka.ms/msal-net-trueMAM
    /// </summary>
    public class IntuneAppProtectionPolicyRequiredException : MsalServiceException
    {
        /// <summary>
        /// UPN of the user
        /// </summary>
        public string Upn { get; set; }

        /// <summary>
        /// Initializes a new instance of the exception class with a specified
        /// error code and error message.
        /// </summary>
        /// <param name="errorCode">
        /// The error code returned by the service or generated by the client. This is the code you can rely on
        /// for exception handling.
        /// </param>
        /// <param name="errorMessage">The error message that explains the reason for the exception.</param>
        public IntuneAppProtectionPolicyRequiredException(string errorCode, string errorMessage) :
            base(errorCode, errorMessage, null)
        {
        }
    }
}