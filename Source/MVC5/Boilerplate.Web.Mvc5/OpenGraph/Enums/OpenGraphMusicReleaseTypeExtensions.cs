﻿namespace Boilerplate.Web.Mvc.OpenGraph
{
    /// <summary>
    /// <see cref="OpenGraphMusicReleaseType"/> extension methods.
    /// </summary>
    internal static class OpenGraphMusicReleaseTypeExtensions
    {
        /// <summary>
        /// Returns the lowercase <see cref="string"/> representation of the <see cref="OpenGraphMusicReleaseType"/>.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The lowercase <see cref="string"/> representation of the <see cref="OpenGraphMusicReleaseType"/>.</returns>
        public static string ToLowercaseString(this OpenGraphMusicReleaseType musicReleaseType)
        {
            switch (musicReleaseType)
            {
                case OpenGraphMusicReleaseType.OriginalRelease:
                    return "original_release";
                case OpenGraphMusicReleaseType.ReRelease:
                    return "re_release";
                case OpenGraphMusicReleaseType.Anthology:
                    return "anthology";
                default:
                    return string.Empty;
            }
        }
    }
}
