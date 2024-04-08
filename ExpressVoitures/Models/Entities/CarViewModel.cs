﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ExpressVoitures.Data;

namespace ExpressVoitures.Models.Entities
{
    public class CarViewModel
    {
        public int Id { get; set; }

        public CarBrand? CarBrand { get; set; }

        public string? CarBrandName { get; set; }

        public CarModel? CarModel { get; set; }

        public string? CarModelName { get; set; }

        public CarTrim CarTrim { get; set; }

        public List<CarRepair>? CarRepairs { get; set; }

        [DisplayName("Année")]
        [Required(ErrorMessage = "L'année du véhicule est obligatoire.")]
        public int? Year { get; set; }

        [DisplayName("Kilométrage")]
        public int? Mileage { get; set; }

        [DisplayName("Prix d'achat")]
        [Required(ErrorMessage = "Le prix d'achat du véhicule est obligatoire.")]
        [Range(0.01, Double.MaxValue, ErrorMessage = "La valeur doit être positive.")]
        public decimal? PurchasePrice { get; set; }

        [DisplayName("Prix de vente")]
        [Range(0.01, Double.MaxValue, ErrorMessage = "La valeur doit être positive.")]
        public decimal? SellingPrice { get; set; }

        [DisplayName("Disponibile")]
        [Required(ErrorMessage = "La disponibilité du vehicule est obligatoire.")]
        public bool IsAvailable { get; set; }

        [DisplayName("Date d'achat")]
        public DateOnly? PurchaseDate { get; set; }

        [DisplayName("Date de disponibilité à la vente")]
        public DateOnly? DateOfAvailability { get; set; }

        [DisplayName("Date de vente")]
        public DateOnly? SaleDate { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }

        [DisplayName("Chemin des images")]
        public List<String>? ImagePaths { get; set; }

        public List<IFormFile>? Images { get; set; }
    }
}