using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO_S
{
    public class CarDetailsDTO:IDto
    {

        public int CarId { get; set; }

        public string CarName { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public int DailyPrice { get; set; }
    }
}
