namespace BlazoriseCommunityStandup.ECommerce.Models
{
    /// <summary>
    /// You could then have sub order states within these major states... waiting payment, paid, shipping, shipped, etc
    /// </summary>
    public enum OrderState
    {
        None,
        Created,
        Confirmed,
        Processing,
        Cancelled,
        Completed
    }
}
