using System;

namespace HL7Data.Exceptions.ApplicationExceptions
{
    public static class ApplicationExceptions
    {
        #region Property Validation

        [Serializable]
        public class ValidationException : ApplicationException
        {
            public ValidationException()
            {
            }

            public ValidationException(string message) : base(message)
            {
            }

            public ValidationException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }

        [Serializable]
        public class MinimumLengthNotReachedException : ValidationException
        {
            public MinimumLengthNotReachedException()
            {
            }

            public MinimumLengthNotReachedException(string message) : base(message)
            {
            }

            public MinimumLengthNotReachedException(string message, Exception innerException) : base(message,
                innerException)
            {
            }
        }

        [Serializable]
        public class MaximumLengthExceededException : ValidationException
        {
            public MaximumLengthExceededException()
            {
            }

            public MaximumLengthExceededException(string message) : base(message)
            {
            }

            public MaximumLengthExceededException(string message, Exception innerException) : base(message,
                innerException)
            {
            }
        }

        [Serializable]
        public class RequiredFieldIsNullException : ValidationException
        {
            public RequiredFieldIsNullException()
            {
            }

            public RequiredFieldIsNullException(string message) : base(message)
            {
            }

            public RequiredFieldIsNullException(string message, Exception innerException) : base(message,
                innerException)
            {
            }
        }

        [Serializable]
        public class ValueIsNullOrEmptyException : ValidationException
        {
        }

        #endregion Property Validation
    }
}