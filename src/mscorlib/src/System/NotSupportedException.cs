// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
**
** Purpose: For methods that should be implemented on subclasses.
**
**
=============================================================================*/

using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    public class NotSupportedException : SystemException
    {
        public NotSupportedException()
            : base(SR.Arg_NotSupportedException)
        {
            HResult = __HResults.COR_E_NOTSUPPORTED;
        }

        public NotSupportedException(String message)
            : base(message)
        {
            HResult = __HResults.COR_E_NOTSUPPORTED;
        }

        public NotSupportedException(String message, Exception innerException)
            : base(message, innerException)
        {
            HResult = __HResults.COR_E_NOTSUPPORTED;
        }

        protected NotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
