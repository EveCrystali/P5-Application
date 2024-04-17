﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ExpressVoitures.Data;

namespace ExpressVoitures.Data
{
    public class CarMotor
    {
        public int Id { get; set; }

        public int CarModelId { get; set; }

        public virtual CarModel? CarModel { get; set; }

        [DisplayName("Motorisation")]
        public string? CarMotorName { get; set; }
    }
}