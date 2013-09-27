/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the CreateVirtualMFADevice action.</para>
    /// </summary>
    public class CreateVirtualMFADeviceResult  
    {
        
        private VirtualMFADevice virtualMFADevice;

        /// <summary>
        /// A newly created virtual MFA device.
        ///  
        /// </summary>
        public VirtualMFADevice VirtualMFADevice
        {
            get { return this.virtualMFADevice; }
            set { this.virtualMFADevice = value; }
        }

        /// <summary>
        /// Sets the VirtualMFADevice property
        /// </summary>
        /// <param name="virtualMFADevice">The value to set for the VirtualMFADevice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVirtualMFADeviceResult WithVirtualMFADevice(VirtualMFADevice virtualMFADevice)
        {
            this.virtualMFADevice = virtualMFADevice;
            return this;
        }
            

        // Check to see if VirtualMFADevice property is set
        internal bool IsSetVirtualMFADevice()
        {
            return this.virtualMFADevice != null;       
        }
    }
}
