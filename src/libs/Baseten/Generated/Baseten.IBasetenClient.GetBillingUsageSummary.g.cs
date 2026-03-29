#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets billing usage summary for a date range<br/>
        /// Returns billing usage data within the specified date range. Includes dedicated model serving, training, and model APIs usage. The date range must not exceed 31 days.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/billing/usage_summary \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.UsageSummaryV1> GetBillingUsageSummaryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}