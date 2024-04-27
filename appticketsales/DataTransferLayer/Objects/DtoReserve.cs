﻿
namespace DataTransferLayer.Objects
{
    public class DtoReserve
    {
        public string idReserver { get; set; }
        public string idClient { get; set; }
        public string idProgramming { get; set; }
        public string serie { get; set; }
        public DateTime resgisterDate { get; set; }
        public DateTime travelDate { get; set; }
        public TimeSpan travelTime { get; set; }
        public Decimal advancement { get; set; }
        public string state { get; set; }
        public string description { get; set; }
    }
}
