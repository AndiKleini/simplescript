﻿using exampleservice.Framework.BaseFramework;

namespace exampleservice.SellTicketService.Contract
{
    public class TicketSoldEvent : EventBase
    {
        public string TicketNumber { get; set; }
    }
}
