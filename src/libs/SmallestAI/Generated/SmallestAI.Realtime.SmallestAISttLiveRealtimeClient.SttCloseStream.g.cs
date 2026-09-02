
#nullable enable

namespace SmallestAI.Realtime
{
    public sealed partial class SmallestAISttLiveRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendSttCloseStreamAsync(
            global::SmallestAI.Realtime.SttCloseStreamRequest message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::SmallestAI.Realtime.SttCloseStreamRequest), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}