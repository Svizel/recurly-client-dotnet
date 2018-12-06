using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources {
  [ExcludeFromCodeCoverage] 
  public class Plan : Resource {
  
    /// <value>Accounting code for invoice line items for the plan. If no value is provided, it defaults to plan's code.</value>
    [JsonProperty("accounting_code")]
    public string AccountingCode { get; set; }
  
    /// <value>Subscriptions will automatically inherit this value once they are active. If `auto_renew` is `true`, then a subscription will automatically renew its term at renewal. If `auto_renew` is `false`, then a subscription will expire at the end of its term. `auto_renew` can be overridden on the subscription record itself.</value>
    [JsonProperty("auto_renew")]
    public bool? AutoRenew { get; set; }
  
    /// <value>Unique code to identify the plan. This is used in Hosted Payment Page URLs and in the invoice exports.</value>
    [JsonProperty("code")]
    public string Code { get; set; }
  
    /// <value>Created at</value>
    [JsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }
  
    /// <value>Pricing</value>
    [JsonProperty("currencies")]
    public List<PlanPricing> Currencies { get; set; }
  
    /// <value>Deleted at</value>
    [JsonProperty("deleted_at")]
    public DateTime? DeletedAt { get; set; }
  
    /// <value>Optional description, not displayed.</value>
    [JsonProperty("description")]
    public string Description { get; set; }
  
    /// <value>Hosted pages settings</value>
    [JsonProperty("hosted_pages")]
    public Dictionary<string, string> HostedPages { get; set; }
  
    /// <value>Plan ID</value>
    [JsonProperty("id")]
    public string Id { get; set; }
  
    /// <value>Length of the plan's billing interval in `interval_unit`.</value>
    [JsonProperty("interval_length")]
    public int? IntervalLength { get; set; }
  
    /// <value>Unit for the plan's billing interval.</value>
    [JsonProperty("interval_unit")]
    public string IntervalUnit { get; set; }
  
    /// <value>This name describes your plan and will appear on the Hosted Payment Page and the subscriber's invoice.</value>
    [JsonProperty("name")]
    public string Name { get; set; }
  
    /// <value>Accounting code for invoice line items for the plan's setup fee. If no value is provided, it defaults to plan's accounting code.</value>
    [JsonProperty("setup_fee_accounting_code")]
    public string SetupFeeAccountingCode { get; set; }
  
    /// <value>The current state of the plan.</value>
    [JsonProperty("state")]
    public string State { get; set; }
  
    /// <value>Optional field for EU VAT merchants and Avalara AvaTax Pro merchants. If you are using Recurly's EU VAT feature, you can use values of 'unknown', 'physical', or 'digital'. If you have your own AvaTax account configured, you can use Avalara tax codes to assign custom tax rules.</value>
    [JsonProperty("tax_code")]
    public string TaxCode { get; set; }
  
    /// <value>`true` exempts tax on the plan, `false` applies tax on the plan.</value>
    [JsonProperty("tax_exempt")]
    public bool? TaxExempt { get; set; }
  
    /// <value>Automatically terminate subscriptions after a defined number of billing cycles. Number of billing cycles before the plan automatically stops renewing, defaults to `null` for continuous, automatic renewal.</value>
    [JsonProperty("total_billing_cycles")]
    public int? TotalBillingCycles { get; set; }
  
    /// <value>Length of plan's trial period in `trial_units`. `0` means `no trial`.</value>
    [JsonProperty("trial_length")]
    public int? TrialLength { get; set; }
  
    /// <value>Units for the plan's trial period.</value>
    [JsonProperty("trial_unit")]
    public string TrialUnit { get; set; }
  
    /// <value>Last updated at</value>
    [JsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }
  
  }
}
