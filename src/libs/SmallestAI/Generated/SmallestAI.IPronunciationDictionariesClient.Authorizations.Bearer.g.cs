
#nullable enable

namespace SmallestAI
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}