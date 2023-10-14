using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DB;

public partial class TrbdbContext : DbContext
{
    public TrbdbContext()
    {
    }

    public TrbdbContext(DbContextOptions<TrbdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdLog> AdLogs { get; set; }

    public virtual DbSet<AdagencyKeyword> AdagencyKeywords { get; set; }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Adtrp> Adtrps { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Channel> Channels { get; set; }

    public virtual DbSet<ChannelOperator> ChannelOperators { get; set; }

    public virtual DbSet<ChannelPackage> ChannelPackages { get; set; }

    public virtual DbSet<DashboardTempDatum> DashboardTempData { get; set; }

    public virtual DbSet<DataCleanse> DataCleanses { get; set; }

    public virtual DbSet<DataReliability> DataReliabilities { get; set; }

    public virtual DbSet<Daypart> Dayparts { get; set; }

    public virtual DbSet<DaypartsProcess> DaypartsProcesses { get; set; }

    public virtual DbSet<DeployerInfo> DeployerInfos { get; set; }

    public virtual DbSet<DeselectLog> DeselectLogs { get; set; }

    public virtual DbSet<DeselectPeriod> DeselectPeriods { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DeviceBox> DeviceBoxes { get; set; }

    public virtual DbSet<EmailVerification> EmailVerifications { get; set; }

    public virtual DbSet<FailedJob> FailedJobs { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PasswordReset> PasswordResets { get; set; }

    public virtual DbSet<PlayoutFile> PlayoutFiles { get; set; }

    public virtual DbSet<PlayoutLog> PlayoutLogs { get; set; }

    public virtual DbSet<ProgramLog> ProgramLogs { get; set; }

    public virtual DbSet<ProgramsTrp> ProgramsTrps { get; set; }

    public virtual DbSet<RawRequest> RawRequests { get; set; }

    public virtual DbSet<SystemUniverse> SystemUniverses { get; set; }

    public virtual DbSet<TempDatum> TempData { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<Universe> Universes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserDataFilter> UserDataFilters { get; set; }

    public virtual DbSet<ViewLog> ViewLogs { get; set; }

    public virtual DbSet<ViewLogsArchive> ViewLogsArchives { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost; port=3500; database=trbdb;user=root;password=tiger");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ad_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdDate)
                .HasColumnType("date")
                .HasColumnName("ad_date");
            entity.Property(e => e.AdName)
                .HasMaxLength(200)
                .HasColumnName("ad_name");
            entity.Property(e => e.AdPos).HasColumnName("ad_pos");
            entity.Property(e => e.AdPrice).HasColumnName("ad_price");
            entity.Property(e => e.AdQty).HasColumnName("ad_qty");
            entity.Property(e => e.AdType)
                .HasMaxLength(100)
                .HasColumnName("ad_type");
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .HasColumnName("brand");
            entity.Property(e => e.BreakType)
                .HasMaxLength(100)
                .HasColumnName("break_type");
            entity.Property(e => e.Campaign)
                .HasMaxLength(200)
                .HasColumnName("campaign");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.Company)
                .HasMaxLength(200)
                .HasColumnName("company");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Finish)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("finish");
            entity.Property(e => e.IncompleteAd)
                .HasMaxLength(100)
                .HasColumnName("incomplete_ad");
            entity.Property(e => e.Peak)
                .HasMaxLength(100)
                .HasColumnName("peak");
            entity.Property(e => e.Product)
                .HasMaxLength(100)
                .HasColumnName("product");
            entity.Property(e => e.ProductType)
                .HasMaxLength(100)
                .HasColumnName("product_type");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(200)
                .HasColumnName("program_name");
            entity.Property(e => e.ProgramType)
                .HasMaxLength(100)
                .HasColumnName("program_type");
            entity.Property(e => e.Start)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("start");
            entity.Property(e => e.SubBrand)
                .HasMaxLength(100)
                .HasColumnName("sub_brand");
            entity.Property(e => e.TelecastTime)
                .HasColumnType("time")
                .HasColumnName("telecast_time");
        });

        modelBuilder.Entity<AdagencyKeyword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("adagency_keywords");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgencyId)
                .HasMaxLength(100)
                .HasColumnName("agency_id");
            entity.Property(e => e.Keyword)
                .HasColumnType("text")
                .HasColumnName("keyword");
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("admins");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Adtrp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("adtrps");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.C1).HasColumnName("c1");
            entity.Property(e => e.C10).HasColumnName("c10");
            entity.Property(e => e.C2).HasColumnName("c2");
            entity.Property(e => e.C3).HasColumnName("c3");
            entity.Property(e => e.C4).HasColumnName("c4");
            entity.Property(e => e.C5).HasColumnName("c5");
            entity.Property(e => e.C6).HasColumnName("c6");
            entity.Property(e => e.C7).HasColumnName("c7");
            entity.Property(e => e.C8).HasColumnName("c8");
            entity.Property(e => e.C9).HasColumnName("c9");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.ChannelName)
                .HasMaxLength(255)
                .HasColumnName("channel_name");
            entity.Property(e => e.CommercialName)
                .HasMaxLength(255)
                .HasColumnName("commercial_name");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Finish)
                .HasColumnType("timestamp")
                .HasColumnName("finish");
            entity.Property(e => e.PlaylogId).HasColumnName("playlog_id");
            entity.Property(e => e.Reach0).HasColumnName("reach0");
            entity.Property(e => e.Reachp).HasColumnName("reachp");
            entity.Property(e => e.Start)
                .HasColumnType("timestamp")
                .HasColumnName("start");
            entity.Property(e => e.Timewatched).HasColumnName("timewatched");
            entity.Property(e => e.Tvr0).HasColumnName("tvr0");
            entity.Property(e => e.Tvrp).HasColumnName("tvrp");
        });

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_users");

            entity.HasIndex(e => e.UserName, "user_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgeGroup)
                .HasMaxLength(100)
                .HasColumnName("age_group");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("region");
            entity.Property(e => e.Sec)
                .HasMaxLength(10)
                .HasColumnName("sec");
        });

        modelBuilder.Entity<Channel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("channels");

            entity.HasIndex(e => e.ChannelName, "channel_name").IsUnique();

            entity.HasIndex(e => e.TmpChannelName, "tmp_channel_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.ChannelName).HasColumnName("channel_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .HasColumnName("logo");
            entity.Property(e => e.TmpChannelName).HasColumnName("tmp_channel_name");
            entity.Property(e => e.TmpLogo)
                .HasMaxLength(255)
                .HasColumnName("tmp_logo");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ChannelOperator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("channel_operator");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.ChannelNumber).HasColumnName("channel_number");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ChannelPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("channel_package");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.ChannelNumber)
                .HasMaxLength(255)
                .HasColumnName("channel_number");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DashboardTempDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dashboard_temp_data");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Day)
                .HasMaxLength(100)
                .HasColumnName("day");
        });

        modelBuilder.Entity<DataCleanse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("data_cleanse");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<DataReliability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("data_reliability");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
        });

        modelBuilder.Entity<Daypart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dayparts");

            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Day)
                .HasColumnType("date")
                .HasColumnName("day");
            entity.Property(e => e.TimeRange).HasColumnName("time_range");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<DaypartsProcess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dayparts_process");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.Day)
                .HasColumnType("date")
                .HasColumnName("day");
            entity.Property(e => e.TimeRange).HasColumnName("time_range");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<DeployerInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("deployer_info");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AltNumber)
                .HasMaxLength(20)
                .HasColumnName("alt_number");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .HasColumnName("designation");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(100)
                .HasColumnName("district_name");
            entity.Property(e => e.DivisionName)
                .HasMaxLength(100)
                .HasColumnName("division_name");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Education)
                .HasMaxLength(200)
                .HasColumnName("education");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(100)
                .HasColumnName("employee_id");
            entity.Property(e => e.HouseName)
                .HasMaxLength(100)
                .HasColumnName("house_name");
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(100)
                .HasColumnName("house_number");
            entity.Property(e => e.Nid)
                .HasMaxLength(100)
                .HasColumnName("nid");
            entity.Property(e => e.Number)
                .HasMaxLength(20)
                .HasColumnName("number");
            entity.Property(e => e.Occupation)
                .HasMaxLength(200)
                .HasColumnName("occupation");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(100)
                .HasColumnName("organization_name");
            entity.Property(e => e.RoadNumber)
                .HasMaxLength(100)
                .HasColumnName("road_number");
            entity.Property(e => e.StateName)
                .HasMaxLength(100)
                .HasColumnName("state_name");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<DeselectLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("deselect_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.DurationMinute)
                .HasColumnType("double(10,2)")
                .HasColumnName("duration_minute");
            entity.Property(e => e.FinishedWatchingAt)
                .HasColumnType("timestamp")
                .HasColumnName("finished_watching_at");
            entity.Property(e => e.StartedWatchingAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("started_watching_at");
            entity.Property(e => e.System)
                .HasDefaultValueSql("'1'")
                .HasColumnName("system");
            entity.Property(e => e.Universe)
                .HasDefaultValueSql("'1'")
                .HasColumnName("universe");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<DeselectPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("deselect_periods");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("timestamp")
                .HasColumnName("end_date");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("devices");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.AltNumber)
                .HasMaxLength(20)
                .HasColumnName("alt_number");
            entity.Property(e => e.CityCorporation)
                .HasMaxLength(255)
                .HasColumnName("city_corporation");
            entity.Property(e => e.CityName)
                .HasMaxLength(255)
                .HasColumnName("city_name");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(100)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(20)
                .HasColumnName("contact_number");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(200)
                .HasColumnName("contact_person");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DeviceName)
                .HasMaxLength(255)
                .HasColumnName("device_name");
            entity.Property(e => e.District)
                .HasMaxLength(255)
                .HasColumnName("district");
            entity.Property(e => e.EconomicStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'b'")
                .HasColumnName("economic_status");
            entity.Property(e => e.GsmSignalStrength)
                .HasMaxLength(255)
                .HasColumnName("gsm_signal_strength");
            entity.Property(e => e.HouseName)
                .HasMaxLength(255)
                .HasColumnName("house_name");
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(255)
                .HasColumnName("house_number");
            entity.Property(e => e.HouseholdCondition)
                .HasMaxLength(255)
                .HasColumnName("household_condition");
            entity.Property(e => e.InstallationDate)
                .HasColumnType("datetime")
                .HasColumnName("installation_date");
            entity.Property(e => e.InstallerName)
                .HasMaxLength(200)
                .HasColumnName("installer_name");
            entity.Property(e => e.LastRequest)
                .HasColumnType("timestamp")
                .HasColumnName("last_request");
            entity.Property(e => e.Lat)
                .HasDefaultValueSql("'23.822508'")
                .HasColumnType("double(8,6)")
                .HasColumnName("lat");
            entity.Property(e => e.Lng)
                .HasDefaultValueSql("'90.427361'")
                .HasColumnType("double(9,6)")
                .HasColumnName("lng");
            entity.Property(e => e.MonthlyIncome)
                .HasMaxLength(10)
                .HasColumnName("monthly_income");
            entity.Property(e => e.NextRenewalDate)
                .HasColumnType("timestamp")
                .HasColumnName("next_renewal_date");
            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.OtherPaymentNumber)
                .HasMaxLength(255)
                .HasColumnName("other_payment_number");
            entity.Property(e => e.OtherPaymentType)
                .HasMaxLength(255)
                .HasColumnName("other_payment_type");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PaymentNumber)
                .HasMaxLength(255)
                .HasColumnName("payment_number");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(255)
                .HasColumnName("payment_type");
            entity.Property(e => e.RoadNumber)
                .HasMaxLength(255)
                .HasColumnName("road_number");
            entity.Property(e => e.SocioStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'u'")
                .HasColumnName("socio_status");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("state_name");
            entity.Property(e => e.StbProviderName)
                .HasMaxLength(255)
                .HasColumnName("stb_provider_name");
            entity.Property(e => e.StbSubscriptionCharge)
                .HasMaxLength(255)
                .HasColumnName("stb_subscription_charge");
            entity.Property(e => e.StbSubscriptionType)
                .HasMaxLength(255)
                .HasColumnName("stb_subscription_type");
            entity.Property(e => e.SurveyDate)
                .HasColumnType("datetime")
                .HasColumnName("survey_date");
            entity.Property(e => e.Thana)
                .HasMaxLength(255)
                .HasColumnName("thana");
            entity.Property(e => e.TvBrand)
                .HasMaxLength(255)
                .HasColumnName("tv_brand");
            entity.Property(e => e.TvPlacement)
                .HasMaxLength(255)
                .HasColumnName("tv_placement");
            entity.Property(e => e.TvType)
                .HasMaxLength(255)
                .HasColumnName("tv_type");
            entity.Property(e => e.Tvoff).HasColumnName("tvoff");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("'OTT'")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.WardNo)
                .HasMaxLength(255)
                .HasColumnName("ward_no");
            entity.Property(e => e.Wifi)
                .HasMaxLength(255)
                .HasColumnName("wifi");
            entity.Property(e => e.WifiSignalStrength)
                .HasMaxLength(255)
                .HasColumnName("wifi_signal_strength");
            entity.Property(e => e.WrongChannel).HasColumnName("wrong_channel");
            entity.Property(e => e.WrongTime)
                .HasColumnType("timestamp")
                .HasColumnName("wrong_time");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .HasColumnName("zip_code");
            entity.Property(e => e.ZoneThana)
                .HasMaxLength(255)
                .HasColumnName("zone_thana");
        });

        modelBuilder.Entity<DeviceBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("device_boxes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
        });

        modelBuilder.Entity<EmailVerification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("email_verification");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<FailedJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("failed_jobs");

            entity.Property(e => e.Connection)
                .HasColumnType("text")
                .HasColumnName("connection");
            entity.Property(e => e.Exception).HasColumnName("exception");
            entity.Property(e => e.FailedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("failed_at");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.Queue)
                .HasColumnType("text")
                .HasColumnName("queue");
            entity.Property(e => e.Uuid)
                .HasMaxLength(255)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("login");

            entity.HasIndex(e => e.UserName, "user_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(100)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasDefaultValueSql("'general'")
                .HasColumnName("role");
            entity.Property(e => e.TryTime).HasColumnName("try_time");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("user_name");
            entity.Property(e => e.Verified).HasColumnName("verified");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("migrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("notifications");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Details)
                .HasColumnType("text")
                .HasColumnName("details");
            entity.Property(e => e.DuId).HasColumnName("du_id");
            entity.Property(e => e.DuName)
                .HasMaxLength(255)
                .HasColumnName("du_name");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("'unseen'")
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Operator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("operators");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.NumberOfPackage).HasColumnName("number_of_package");
            entity.Property(e => e.OperatorName)
                .HasMaxLength(255)
                .HasColumnName("operator_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("packages");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NumberOfChannel).HasColumnName("number_of_channel");
            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.PackageName)
                .HasMaxLength(255)
                .HasColumnName("package_name");
            entity.Property(e => e.Price)
                .HasColumnType("double(8,2)")
                .HasColumnName("price");
            entity.Property(e => e.RenewalFrequency)
                .HasMaxLength(255)
                .HasColumnName("renewal_frequency");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PasswordReset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("password_resets");

            entity.HasIndex(e => e.Email, "PassReset_login_FK");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("email");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .HasColumnName("value");
        });

        modelBuilder.Entity<PlayoutFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("playout_files");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
        });

        modelBuilder.Entity<PlayoutLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("playout_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.CommercialName)
                .HasMaxLength(255)
                .HasColumnName("commercial_name");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Done).HasColumnName("done");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.Finish)
                .HasColumnType("timestamp")
                .HasColumnName("finish");
            entity.Property(e => e.Start)
                .HasColumnType("timestamp")
                .HasColumnName("start");
        });

        modelBuilder.Entity<ProgramLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("program_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.Day)
                .HasMaxLength(100)
                .HasColumnName("day");
            entity.Property(e => e.Finish)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("finish");
            entity.Property(e => e.Language)
                .HasMaxLength(100)
                .HasColumnName("language");
            entity.Property(e => e.PeakOffpeak)
                .HasMaxLength(100)
                .HasColumnName("peak_offpeak");
            entity.Property(e => e.ProgramDate)
                .HasColumnType("date")
                .HasColumnName("program_date");
            entity.Property(e => e.ProgramDurationMin).HasColumnName("program_duration_min");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(512)
                .HasColumnName("program_name");
            entity.Property(e => e.ProgramTypeGenre)
                .HasMaxLength(100)
                .HasColumnName("program_type_genre");
            entity.Property(e => e.Start)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("start");
            entity.Property(e => e.WeekNo).HasColumnName("week_no");
        });

        modelBuilder.Entity<ProgramsTrp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("programs_trps");

            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.ChannelName)
                .HasMaxLength(100)
                .HasColumnName("channel_name");
            entity.Property(e => e.Day)
                .HasMaxLength(100)
                .HasColumnName("day");
            entity.Property(e => e.DurMin).HasColumnName("dur_min");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("end_time");
            entity.Property(e => e.Genre)
                .HasMaxLength(100)
                .HasColumnName("genre");
            entity.Property(e => e.Language)
                .HasMaxLength(100)
                .HasColumnName("language");
            entity.Property(e => e.ProgramDate)
                .HasColumnType("date")
                .HasColumnName("program_date");
            entity.Property(e => e.Programme)
                .HasMaxLength(512)
                .HasColumnName("programme");
            entity.Property(e => e.Reach0).HasColumnName("reach0");
            entity.Property(e => e.Reachp).HasColumnName("reachp");
            entity.Property(e => e.Share).HasColumnName("share");
            entity.Property(e => e.StartTime)
                .HasColumnType("time")
                .HasColumnName("start_time");
            entity.Property(e => e.Timespent).HasColumnName("timespent");
            entity.Property(e => e.Tvr0).HasColumnName("tvr0");
            entity.Property(e => e.TvrAll).HasColumnName("tvr_all");
            entity.Property(e => e.Tvrp).HasColumnName("tvrp");
        });

        modelBuilder.Entity<RawRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("raw_requests");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId)
                .HasMaxLength(100)
                .HasColumnName("channel_id");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(100)
                .HasColumnName("device_id");
            entity.Property(e => e.Error)
                .HasMaxLength(9999)
                .HasColumnName("error");
            entity.Property(e => e.Finish)
                .HasMaxLength(100)
                .HasColumnName("finish");
            entity.Property(e => e.Offline)
                .HasMaxLength(10)
                .HasColumnName("offline");
            entity.Property(e => e.People)
                .HasMaxLength(10)
                .HasColumnName("people");
            entity.Property(e => e.ServerTime)
                .HasMaxLength(100)
                .HasColumnName("server_time");
            entity.Property(e => e.Start)
                .HasMaxLength(100)
                .HasColumnName("start");
            entity.Property(e => e.Temp)
                .HasMaxLength(10)
                .HasColumnName("temp");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(100)
                .HasColumnName("time_stamp");
        });

        modelBuilder.Entity<SystemUniverse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("system_universe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgeGroup)
                .HasMaxLength(100)
                .HasColumnName("age_group");
            entity.Property(e => e.DateOfGen)
                .HasColumnType("date")
                .HasColumnName("date_of_gen");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("region");
            entity.Property(e => e.Sec)
                .HasMaxLength(10)
                .HasColumnName("sec");
            entity.Property(e => e.Universe).HasColumnName("universe");
        });

        modelBuilder.Entity<TempDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("temp_data");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tokens");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Token1)
                .HasMaxLength(500)
                .HasColumnName("token");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Universe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("universe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgeGroup)
                .HasMaxLength(100)
                .HasColumnName("age_group");
            entity.Property(e => e.End)
                .HasColumnType("date")
                .HasColumnName("end");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("region");
            entity.Property(e => e.Rs)
                .HasMaxLength(100)
                .HasColumnName("rs");
            entity.Property(e => e.Sec)
                .HasMaxLength(10)
                .HasColumnName("sec");
            entity.Property(e => e.Start)
                .HasColumnType("date")
                .HasColumnName("start");
            entity.Property(e => e.Universe1).HasColumnName("universe");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Age)
                .HasDefaultValueSql("'30'")
                .HasColumnName("age");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.EconomicStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'b'")
                .HasColumnName("economic_status");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasDefaultValueSql("'m'")
                .HasColumnName("gender");
            entity.Property(e => e.LastRequest)
                .HasColumnType("timestamp")
                .HasColumnName("last_request");
            entity.Property(e => e.Lat)
                .HasColumnType("double(8,6)")
                .HasColumnName("lat");
            entity.Property(e => e.Lng)
                .HasColumnType("double(9,6)")
                .HasColumnName("lng");
            entity.Property(e => e.NextRenewalDate)
                .HasColumnType("timestamp")
                .HasColumnName("next_renewal_date");
            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.SocioStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'u'")
                .HasColumnName("socio_status");
            entity.Property(e => e.Tvoff).HasColumnName("tvoff");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("'STB'")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserIndex).HasColumnName("user_index");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("user_name");
            entity.Property(e => e.WrongChannel).HasColumnName("wrong_channel");
            entity.Property(e => e.WrongTime)
                .HasColumnType("timestamp")
                .HasColumnName("wrong_time");
        });

        modelBuilder.Entity<UserDataFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user_data_filter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.FilterName)
                .HasMaxLength(255)
                .HasColumnName("filter_name");
            entity.Property(e => e.Finish)
                .HasColumnType("datetime")
                .HasColumnName("finish");
            entity.Property(e => e.FromAge).HasColumnName("from_age");
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .HasColumnName("gender");
            entity.Property(e => e.GenerateFlag).HasColumnName("generate_flag");
            entity.Property(e => e.GeneratedData).HasColumnName("generated_data");
            entity.Property(e => e.Start)
                .HasColumnType("datetime")
                .HasColumnName("start");
            entity.Property(e => e.ToAge).HasColumnName("to_age");
        });

        modelBuilder.Entity<ViewLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("view_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.DurationMinute)
                .HasColumnType("double(10,2)")
                .HasColumnName("duration_minute");
            entity.Property(e => e.FinishedWatchingAt)
                .HasColumnType("timestamp")
                .HasColumnName("finished_watching_at");
            entity.Property(e => e.StartedWatchingAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("started_watching_at");
            entity.Property(e => e.System)
                .HasDefaultValueSql("'1'")
                .HasColumnName("system");
            entity.Property(e => e.Universe)
                .HasDefaultValueSql("'1'")
                .HasColumnName("universe");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ViewLogsArchive>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("view_logs_archive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.DurationMinute)
                .HasColumnType("double(10,2)")
                .HasColumnName("duration_minute");
            entity.Property(e => e.FinishedWatchingAt)
                .HasColumnType("timestamp")
                .HasColumnName("finished_watching_at");
            entity.Property(e => e.StartedWatchingAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("started_watching_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.ViewLogId).HasColumnName("view_log_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
