using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Device
{
    public ulong Id { get; set; }

    public string DeviceName { get; set; } = null!;

    public string? Address { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    public int? PackageId { get; set; }

    public int? OperatorId { get; set; }

    public DateTime? NextRenewalDate { get; set; }

    public DateTime? LastRequest { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? WrongTime { get; set; }

    public int? WrongChannel { get; set; }

    public string? Type { get; set; }

    public int Tvoff { get; set; }

    public string EconomicStatus { get; set; } = null!;

    public string? MonthlyIncome { get; set; }

    public string SocioStatus { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactNumber { get; set; }

    public string? AltNumber { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentNumber { get; set; }

    public string? OtherPaymentType { get; set; }

    public string? OtherPaymentNumber { get; set; }

    public string? HouseName { get; set; }

    public string? HouseNumber { get; set; }

    public string? RoadNumber { get; set; }

    public string? StateName { get; set; }

    public string? WardNo { get; set; }

    public string? ZoneThana { get; set; }

    public string? Thana { get; set; }

    public string? CityCorporation { get; set; }

    public string? CityName { get; set; }

    public string? ZipCode { get; set; }

    public string? District { get; set; }

    public string? HouseholdCondition { get; set; }

    public string? InstallerName { get; set; }

    public DateTime? SurveyDate { get; set; }

    public DateTime? InstallationDate { get; set; }

    public string? Description { get; set; }

    public string? TvType { get; set; }

    public string? TvBrand { get; set; }

    public string? TvPlacement { get; set; }

    public string? GsmSignalStrength { get; set; }

    public string? Wifi { get; set; }

    public string? WifiSignalStrength { get; set; }

    public string? StbProviderName { get; set; }

    public string? StbSubscriptionType { get; set; }

    public string? StbSubscriptionCharge { get; set; }
}
