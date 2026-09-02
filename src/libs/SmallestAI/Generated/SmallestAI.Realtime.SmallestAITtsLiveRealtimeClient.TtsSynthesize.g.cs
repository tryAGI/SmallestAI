
#nullable enable

namespace SmallestAI.Realtime
{
    public sealed partial class SmallestAITtsLiveRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendTtsSynthesizeAsync(
            global::SmallestAI.Realtime.TtsSynthesizeRequest message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::SmallestAI.Realtime.TtsSynthesizeRequest), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}