﻿using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class OrderControlCodes : ITableInfo
    {
        private static ITableInfo InstanceData => new OrderControlCodes();
        public static ITableInfo Instance => InstanceData;
        private OrderControlCodes() { }

        public int Id => 119;
        public string Name => "Order Control Codes";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"AF", "Order/service refill request approval"},
            {"CA", "Cancel order/service request"},
            {"CH", "Child order/service"},
            {"CN", "Combined result"},
            {"CP", "Cancel process step"},
            {"CR", "Canceled as requested"},
            {"DC", "Discontinue order/service request"},
            {"DE", "Data errors"},
            {"DF", "Order/service refill request denied"},
            {"DR", "Discontinued as requested"},
            {"FU", "Order/service refilled, unsolicited"},
            {"HD", "Hold order request"},
            {"HR", "On hold as requested"},
            {"LI", "Link order/service to patient care problem or goal"},
            {"NA", "Number assigned"},
            {"NW", "New order/service"},
            {"OC", "Order/service canceled"},
            {"OD", "Order/service discontinued"},
            {"OE", "Order/service released"},
            {"OF", "Order/service refilled as requested"},
            {"OH", "Order/service held"},
            {"OK", "Order/service accepted & OK"},
            {"OP", "Notification of order for outside dispense"},
            {"OR", "Released as requested"},
            {"PA", "Parent order/service"},
            {"PR", "Previous Results with new order/service"},
            {"PY", "Notification of replacement order for outside dispense"},
            {"RE", "Observations/Performed Service to follow"},
            {"RF", "Refill order/service request"},
            {"RL", "Release previous hold"},
            {"RO", "Replacement order"},
            {"RP", "Order/service replace request"},
            {"RQ", "Replaced as requested"},
            {"RR", "Request received"},
            {"RU", "Replaced unsolicited"},
            {"SC", "Status changed"},
            {"SN", "Send order/service number"},
            {"SR", "Response to send order/service status request"},
            {"SS", "Send order/service status request"},
            {"UA", "Unable to accept order/service"},
            {"UC", "Unable to cancel"},
            {"UD", "Unable to discontinue"},
            {"UF", "Unable to refill"},
            {"UH", "Unable to put on hold"},
            {"UM", "Unable to replace"},
            {"UN", "Unlink order/service from patient care problem or goal"},
            {"UR", "Unable to release"},
            {"UX", "Unable to change"},
            {"XO", "Change order/service request"},
            {"XR", "Changed as requested"},
            {"XX", "Order/service changed, unsol."},
            {"MC", "Miscellaneous Charge – not associated with an order"}
        };
    }
}
