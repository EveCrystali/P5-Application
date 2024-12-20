﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ExpressVoitures.Data;

namespace ExpressVoitures.Models.Entities
{
    public class CarViewModel
    {
        public int Id { get; set; }

        [DisplayName("Marque* :")]
        [Required(ErrorMessage = "La marque du véhicule est obligatoire.")]
        public int CarBrandId { get; set; }

        [DisplayName("Code VIN :")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "Le code VIN doit avoir 17 caractères.")]
        public string? CodeVIN { get; set; }

        public CarBrand? CarBrand { get; set; }

        public string? CarBrandName { get; set; }

        [DisplayName("Modèle* :")]
        [Required(ErrorMessage = "Le modèle du véhicule est obligatoire.")]
        public int CarModelId { get; set; }

        public CarModel? CarModel { get; set; }

        public string? CarModelName { get; set; }

        [DisplayName("Finition* :")]
        [Required(ErrorMessage = "La finition du véhicule est obligatoire.")]
        public int CarTrimId { get; set; }

        public CarTrim? CarTrim { get; set; }

        public string? CarTrimName { get; set; }

        [DisplayName("Motorisation :")]
        public int? CarMotorId { get; set; }

        public CarMotor? CarMotor { get; set; }

        public string? CarMotorName { get; set; }

        public List<CarRepair> CarRepairs { get; set; } = [];

        [DisplayName("Année* :")]
        [Required(ErrorMessage = "L'année du véhicule est obligatoire.")]
        [Range(1990, 2024, ErrorMessage = "La valeur doit être comprise entre 1990 et 2024.")]
        public int? Year { get; set; }

        [DisplayName("Kilométrage :")]
        public int? Mileage { get; set; }

        [DisplayName("Prix d'achat* :")]
        [RegularExpression(@"^\d+([.,]\d{0,2})?$", ErrorMessage = "Le prix doit être un nombre avec au maximum deux chiffres apres le séparateur décimal.")]
        [Required(ErrorMessage = "Le prix d'achat du véhicule est obligatoire.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "La valeur doit être positive.")]
        public decimal? PurchasePrice { get; set; }

        [DisplayName("Prix de vente :")]
        [Range(0.01, double.MaxValue, ErrorMessage = "La valeur doit être positive.")]
        public decimal? SellingPrice { get; set; }

        [DisplayName("Disponible** :")]
        [Required(ErrorMessage = "La disponibilité du vehicule est obligatoire.")]
        public bool IsAvailable { get; set; }

        [DisplayName("Date d'achat :")]
        public DateOnly? PurchaseDate { get; set; }

        [DisplayName("Disponibilité à la vente :")]
        public DateOnly? DateOfAvailability { get; set; }

        [DisplayName("Date de vente :")]
        public DateOnly? SaleDate { get; set; }

        [DisplayName("Description :")]
        public string? Description { get; set; }

        [DisplayName("Chemin des images :")]
        public List<string>? ImagePaths { get; set; }

        [DisplayName("Images :")]
        [FileExtensions(new string[] { ".jpeg", ".jpg", ".png", ".webp", ".jfif" })]
        public List<IFormFile>? Images { get; set; }
    }
}
