using System;

namespace Logic
{
    /// <summary>
    /// This is Greeting class
    /// </summary>
    public static class GreetingClass
    {
        /// <summary>
        /// The greeting method.
        /// </summary>
        /// <param name="userName">
        /// The user name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the user name is null 
        /// </exception>
        public static string GreetingMethod(string userName)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }

            if (userName == string.Empty)
            {
                return "Hello, anonim!";
            }

            //if (string.IsNullOrEmpty(userName))
            //{}

            return $"Hello, {userName}!";
        }
    }
}
