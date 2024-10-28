using System;
using System.Collections.Generic;
using Blazor.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blazor.API.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdditionalFieldData> AdditionalFieldData { get; set; }

    public virtual DbSet<AdminCalendar> AdminCalendar { get; set; }

    public virtual DbSet<AdminCalendarUsers> AdminCalendarUsers { get; set; }

    public virtual DbSet<AdminDocuments> AdminDocuments { get; set; }

    public virtual DbSet<AdminLead> AdminLead { get; set; }

    public virtual DbSet<AdminLeadComment> AdminLeadComment { get; set; }

    public virtual DbSet<AdminLeadConversation> AdminLeadConversation { get; set; }

    public virtual DbSet<AdminLeadFile> AdminLeadFile { get; set; }

    public virtual DbSet<AdminLeadNote> AdminLeadNote { get; set; }

    public virtual DbSet<AdminNotes> AdminNotes { get; set; }

    public virtual DbSet<Agency> Agency { get; set; }

    public virtual DbSet<AgencyAppointment> AgencyAppointment { get; set; }

    public virtual DbSet<AgencyLicense> AgencyLicense { get; set; }

    public virtual DbSet<AgencyState> AgencyState { get; set; }

    public virtual DbSet<AgencyUserView> AgencyUserView { get; set; }

    public virtual DbSet<AlternateContactDetail> AlternateContactDetail { get; set; }

    public virtual DbSet<Carrier> Carrier { get; set; }

    public virtual DbSet<CityMaster> CityMaster { get; set; }

    public virtual DbSet<CountryMaster> CountryMaster { get; set; }

    public virtual DbSet<CultureMaster> CultureMaster { get; set; }

    public virtual DbSet<CurrencyMaster> CurrencyMaster { get; set; }

    public virtual DbSet<DesignationMaster> DesignationMaster { get; set; }

    public virtual DbSet<DesignationPermission> DesignationPermission { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }

    public virtual DbSet<Enquiry> Enquiry { get; set; }

    public virtual DbSet<FlagMaster> FlagMaster { get; set; }

    public virtual DbSet<LeadCategoryMaster> LeadCategoryMaster { get; set; }

    public virtual DbSet<LeadComment> LeadComment { get; set; }

    public virtual DbSet<LeadConversation> LeadConversation { get; set; }

    public virtual DbSet<LeadEvent> LeadEvent { get; set; }

    public virtual DbSet<LeadFile> LeadFile { get; set; }

    public virtual DbSet<LeadNote> LeadNote { get; set; }

    public virtual DbSet<LeadQualityMaster> LeadQualityMaster { get; set; }

    public virtual DbSet<LeadSourceMaster> LeadSourceMaster { get; set; }

    public virtual DbSet<LeadStoreCart> LeadStoreCart { get; set; }

    public virtual DbSet<LeadStoreFilter> LeadStoreFilter { get; set; }

    public virtual DbSet<LeadStoreLeadTypes> LeadStoreLeadTypes { get; set; }

    public virtual DbSet<LeadStoreLog> LeadStoreLog { get; set; }

    public virtual DbSet<LeadStoreOrderDetails> LeadStoreOrderDetails { get; set; }

    public virtual DbSet<Leads> Leads { get; set; }

    public virtual DbSet<LeadsLog> LeadsLog { get; set; }

    public virtual DbSet<Menu> Menu { get; set; }

    public virtual DbSet<MenuItem> MenuItem { get; set; }

    public virtual DbSet<Plan> Plan { get; set; }

    public virtual DbSet<PriorityMaster> PriorityMaster { get; set; }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<Role> Role { get; set; }

    public virtual DbSet<StateMaster> StateMaster { get; set; }

    public virtual DbSet<StatePlan> StatePlan { get; set; }

    public virtual DbSet<StatusUpdateMaster> StatusUpdateMaster { get; set; }

    public virtual DbSet<UserCalendar> UserCalendar { get; set; }

    public virtual DbSet<UserCarrier> UserCarrier { get; set; }

    public virtual DbSet<UserLogin> UserLogin { get; set; }

    public virtual DbSet<UserOpportunity> UserOpportunity { get; set; }

    public virtual DbSet<UserProduct> UserProduct { get; set; }

    public virtual DbSet<UserTimeZones> UserTimeZones { get; set; }

    public virtual DbSet<Users> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdditionalFieldData>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Addition__3214EC075D6ACCE9");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.Required).HasDefaultValueSql("('0')");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");

            entity.HasOne(d => d.Flag).WithMany(p => p.AdditionalFieldData)
                .HasForeignKey(d => d.FlagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FlagMaster");
        });

        modelBuilder.Entity<AdminCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminCal__3214EC07BA9CA427");

            entity.Property(e => e.Description).HasMaxLength(3000);
            entity.Property(e => e.Location).HasMaxLength(2000);
            entity.Property(e => e.Title).HasMaxLength(1000);
        });

        modelBuilder.Entity<AdminCalendarUsers>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminCal__3214EC071BE00BA9");

            entity.HasOne(d => d.AdminCalendar).WithMany(p => p.AdminCalendarUsers)
                .HasForeignKey(d => d.AdminCalendarId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.AdminCalendarUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AdminDocuments>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminDoc__3214EC07184B8360");

            entity.Property(e => e.FileDescription).HasMaxLength(200);
            entity.Property(e => e.FileExt).HasMaxLength(50);
            entity.Property(e => e.FileType).HasMaxLength(200);

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.AdminDocuments)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AdminLead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminLea__3214EC078FE49EDF");

            entity.Property(e => e.Address).HasMaxLength(2000);
            entity.Property(e => e.AgencyName).HasMaxLength(500);
            entity.Property(e => e.City).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(150);
            entity.Property(e => e.Mobile).HasMaxLength(30);
            entity.Property(e => e.ZipCode).HasMaxLength(20);

            entity.HasOne(d => d.State).WithMany(p => p.AdminLead)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_Adminlead_StateMaster");
        });

        modelBuilder.Entity<AdminLeadComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminLea__3214EC070D4955C3");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.AdminLeadComment)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.AdminLead).WithMany(p => p.AdminLeadComment)
                .HasForeignKey(d => d.AdminLeadId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AdminLeadConversation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminLea__3214EC07C1183B7A");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.AdminLeadConversation)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.AdminLead).WithMany(p => p.AdminLeadConversation)
                .HasForeignKey(d => d.AdminLeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminLeadConversation_AdminLead_LeadId");
        });

        modelBuilder.Entity<AdminLeadFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminLea__3214EC0780B7927A");

            entity.Property(e => e.FileExt).HasMaxLength(50);
            entity.Property(e => e.FileType).HasMaxLength(200);

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.AdminLeadFile)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.AdminLead).WithMany(p => p.AdminLeadFile)
                .HasForeignKey(d => d.AdminLeadId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AdminLeadNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminLea__3214EC070E576B11");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.AdminLeadNote)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.AdminLead).WithMany(p => p.AdminLeadNote)
                .HasForeignKey(d => d.AdminLeadId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AdminNotes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminNot__3214EC07C9886EB7");

            entity.HasOne(d => d.User).WithMany(p => p.AdminNotes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Agency>(entity =>
        {
            entity.Property(e => e.Code).HasMaxLength(250);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Logo).HasMaxLength(500);
            entity.Property(e => e.ModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Npn)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NPN");

            entity.HasOne(d => d.State).WithMany(p => p.Agency).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<AgencyAppointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AgencyAp__3214EC07F1726F3E");

            entity.Property(e => e.Cocode)
                .HasMaxLength(250)
                .HasColumnName("COcode");
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.Fein)
                .HasMaxLength(250)
                .HasColumnName("FEIN");
            entity.Property(e => e.LineOfAuthority).HasMaxLength(250);
            entity.Property(e => e.Loacode)
                .HasMaxLength(250)
                .HasColumnName("LOACode");
            entity.Property(e => e.ReasonDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalDate).HasColumnType("datetime");
            entity.Property(e => e.TerminationReason).HasMaxLength(50);

            entity.HasOne(d => d.Agency).WithMany(p => p.AgencyAppointment)
                .HasForeignKey(d => d.AgencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State).WithMany(p => p.AgencyAppointment)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AgencyLicense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AgencyLi__3214EC0704597115");

            entity.Property(e => e.Class).HasMaxLength(250);
            entity.Property(e => e.DateExpire).HasColumnType("datetime");
            entity.Property(e => e.DateIssue).HasColumnType("datetime");

            entity.HasOne(d => d.Agency).WithMany(p => p.AgencyLicense)
                .HasForeignKey(d => d.AgencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State).WithMany(p => p.AgencyLicense)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AgencyState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AgencySt__3214EC07DF81EAA3");

            entity.Property(e => e.Class).HasMaxLength(250);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.DateExpire).HasColumnType("datetime");
            entity.Property(e => e.DateIssue).HasColumnType("datetime");
            entity.Property(e => e.LicenseNo).HasMaxLength(100);
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Agency).WithMany(p => p.AgencyState)
                .HasForeignKey(d => d.AgencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State).WithMany(p => p.AgencyState)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AgencyUserView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Agency_User_View");

            entity.Property(e => e.Code).HasMaxLength(250);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Id).HasMaxLength(150);
            entity.Property(e => e.Logo).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(752);
            entity.Property(e => e.Npn)
                .HasMaxLength(50)
                .HasColumnName("NPN");
            entity.Property(e => e.ProfilePic).HasMaxLength(500);
            entity.Property(e => e.StateId).HasMaxLength(5);
            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlternateContactDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Alternat__3214EC07419EB5D0");

            entity.Property(e => e.ContactNumber)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
        });

        modelBuilder.Entity<Carrier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Carrier__3214EC0779CE1219");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsAca).HasColumnName("IsACA");
            entity.Property(e => e.Logo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CityMaster>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.State).WithMany(p => p.CityMaster)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_CityMaster_StateMaster");
        });

        modelBuilder.Entity<CountryMaster>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CultureMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CultureM__3214EC0712CD20F2");

            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CurrencyCode).WithMany(p => p.CultureMaster)
                .HasForeignKey(d => d.CurrencyCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CultureMa__Curre__3F865F66");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CultureMaster)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CultureMa__Modif__407A839F");
        });

        modelBuilder.Entity<CurrencyMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Currency__3214EC0770D9B049");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.CurrencyDisplayName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<DesignationMaster>(entity =>
        {
            entity.Property(e => e.Colour)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<DesignationPermission>(entity =>
        {
            entity.Property(e => e.CreationOn).HasColumnType("datetime");

            entity.HasOne(d => d.Designation).WithMany(p => p.DesignationPermission)
                .HasForeignKey(d => d.DesignationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DesignationPermission_DesignationPermission");
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmailTem__3214EC07F76C4063");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<Enquiry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enquiry__3214EC07A04CE267");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Ipaddress)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);
        });

        modelBuilder.Entity<FlagMaster>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FlagColor)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.FlagName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.IsHidden)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LeadCategoryMaster>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LeadComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadComm__3214EC07D574C019");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.LeadComment)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<LeadConversation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadConv__3214EC076824A4FA");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.LeadConversation)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<LeadEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadEven__3214EC074AA76B8C");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.Note).IsRequired();

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LeadEventCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LeadEvent__Creat__100C566E");

            entity.HasOne(d => d.User).WithMany(p => p.LeadEventUser)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LeadEvent__UserI__0F183235");
        });

        modelBuilder.Entity<LeadFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadFile__3214EC07F8284F53");

            entity.Property(e => e.FileExt).HasMaxLength(50);
            entity.Property(e => e.FileType).HasMaxLength(200);

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.LeadFile)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<LeadNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadNote__3214EC0781F49184");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.LeadNote)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Lead).WithMany(p => p.LeadNote)
                .HasForeignKey(d => d.LeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadNote_Leads");
        });

        modelBuilder.Entity<LeadQualityMaster>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LeadSourceMaster>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<LeadStoreCart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadStor__3214EC07782B12B3");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NumberOfLeads).HasColumnName("NumberOfLeads ");
        });

        modelBuilder.Entity<LeadStoreFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadStor__3214EC07DF6A314D");

            entity.HasOne(d => d.LeadType).WithMany(p => p.LeadStoreFilter).HasForeignKey(d => d.LeadTypeId);
        });

        modelBuilder.Entity<LeadStoreLeadTypes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadStor__3214EC07E34DFAB9");

            entity.Property(e => e.LeadDescription)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<LeadStoreLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadStor__3214EC07841DB80E");

            entity.Property(e => e.FileName).HasMaxLength(100);

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.LeadStoreLog)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<LeadStoreOrderDetails>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadStor__3214EC0719F50B6E");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.OrderNumber).HasMaxLength(12);
            entity.Property(e => e.UserName).HasMaxLength(200);

            entity.HasOne(d => d.Cart).WithMany(p => p.LeadStoreOrderDetails).HasForeignKey(d => d.CartId);
        });

        modelBuilder.Entity<Leads>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadStor__3214EC07BAAD59DD");

            entity.Property(e => e.Crmtype).HasColumnName("CRMType");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.EmailOtp)
                .HasMaxLength(10)
                .HasColumnName("EmailOTP");
            entity.Property(e => e.EmailOtptime)
                .HasColumnType("datetime")
                .HasColumnName("EmailOTPTime");
            entity.Property(e => e.FirstName).HasMaxLength(400);
            entity.Property(e => e.IsSold).HasColumnName("isSold");
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.LeadAssignedDate).HasColumnType("datetime");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.MobileOtp)
                .HasMaxLength(10)
                .HasColumnName("MobileOTP");
            entity.Property(e => e.MobileOtptime)
                .HasColumnType("datetime")
                .HasColumnName("MobileOTPTime");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.TempEmailOtp)
                .HasMaxLength(10)
                .HasColumnName("TempEmailOTP");
            entity.Property(e => e.TempMobileOtp)
                .HasMaxLength(10)
                .HasColumnName("TempMobileOTP");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.ZipCode).HasMaxLength(20);

            entity.HasOne(d => d.City).WithMany(p => p.Leads)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_Leads_CityMaster");

            entity.HasOne(d => d.Country).WithMany(p => p.Leads)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Leads_CountryMaster");

            entity.HasOne(d => d.Flag).WithMany(p => p.Leads)
                .HasForeignKey(d => d.FlagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Leads_FlagMaster");

            entity.HasOne(d => d.LeadCategory).WithMany(p => p.Leads)
                .HasForeignKey(d => d.LeadCategoryId)
                .HasConstraintName("FK__Leads__LeadCateg__51A50FA1");

            entity.HasOne(d => d.LeadQuality).WithMany(p => p.Leads)
                .HasForeignKey(d => d.LeadQualityId)
                .HasConstraintName("FK__Leads__LeadQuali__529933DA");

            entity.HasOne(d => d.LeadSource).WithMany(p => p.Leads)
                .HasForeignKey(d => d.LeadSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Leads_LeadSourceMaster");

            entity.HasOne(d => d.Log).WithMany(p => p.Leads)
                .HasForeignKey(d => d.LogId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Leads_LeadsLog_LogId");

            entity.HasOne(d => d.Priority).WithMany(p => p.Leads)
                .HasForeignKey(d => d.PriorityId)
                .HasConstraintName("FK_Leads_PriorityMaster");

            entity.HasOne(d => d.State).WithMany(p => p.Leads).HasForeignKey(d => d.StateId);

            entity.HasOne(d => d.User).WithMany(p => p.Leads)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Leads_UserLogin");
        });

        modelBuilder.Entity<LeadsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeadStor__3214EC07893EBD7C");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LeadsLogCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadsLog_UserLogin");

            entity.HasOne(d => d.Flag).WithMany(p => p.LeadsLog)
                .HasForeignKey(d => d.FlagId)
                .HasConstraintName("FK__LeadsLog__FlagId__416EA7D8");

            entity.HasOne(d => d.Lead).WithMany(p => p.LeadsLog)
                .HasForeignKey(d => d.LeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadsLog_Leads");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.LeadsLogModifiedByNavigation)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadsLog_UserLogin1");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Menu__3214EC07B3F86410");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Url).HasMaxLength(150);
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MenuItems");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MenuIcon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MenuName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MenuUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SubMenuIcon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plan__3214EC07531D2761");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Product).WithMany(p => p.Plan)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PriorityMaster>(entity =>
        {
            entity.Property(e => e.Color)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC07769913E7");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Carrier).WithMany(p => p.Product)
                .HasForeignKey(d => d.CarrierId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Country).WithMany(p => p.StateMaster)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_StateMaster_CountryMaster");
        });

        modelBuilder.Entity<StatePlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatePla__3214EC071C84F4FA");

            entity.HasOne(d => d.Plan).WithMany(p => p.StatePlan)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State).WithMany(p => p.StatePlan)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<StatusUpdateMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusUp__3214EC07AFE3B139");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusUpdateRecords).IsRequired();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Flag).WithMany(p => p.StatusUpdateMaster)
                .HasForeignKey(d => d.FlagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StatusUpd__FlagI__679450C0");

            entity.HasOne(d => d.Lead).WithMany(p => p.StatusUpdateMaster)
                .HasForeignKey(d => d.LeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StatusUpd__LeadI__66A02C87");
        });

        modelBuilder.Entity<UserCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCal__3214EC079BE6D23D");

            entity.Property(e => e.Description).HasMaxLength(3000);
            entity.Property(e => e.Location).HasMaxLength(2000);
            entity.Property(e => e.Title).HasMaxLength(1000);

            entity.HasOne(d => d.User).WithMany(p => p.UserCalendar)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserCarrier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCar__3214EC07A2C78AB2");

            entity.Property(e => e.CarrierUserId).HasMaxLength(100);

            entity.HasOne(d => d.Carrier).WithMany(p => p.UserCarrier)
                .HasForeignKey(d => d.CarrierId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserCarrier)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ForgetPasswordExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.ForgetPasswordLink).HasMaxLength(256);
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangeDate).HasColumnType("datetime");
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.PasswordSalt)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(300);

            entity.HasOne(d => d.RoleTypeNavigation).WithMany(p => p.UserLogin)
                .HasForeignKey(d => d.RoleType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserLogin_Role");
        });

        modelBuilder.Entity<UserOpportunity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserOpp__3214EC07C44A62BC");

            entity.Property(e => e.Address1).HasMaxLength(1500);
            entity.Property(e => e.Address2).HasMaxLength(1500);
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.DriverLicenseNumber).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(400);
            entity.Property(e => e.Height).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.MiddleName).HasMaxLength(200);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.MotherMaidenName).HasMaxLength(400);
            entity.Property(e => e.Occupation).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(2000);
            entity.Property(e => e.Weight).HasMaxLength(50);
            entity.Property(e => e.ZipCode).HasMaxLength(20);

            entity.HasOne(d => d.State).WithMany(p => p.UserOpportunity).HasForeignKey(d => d.StateId);

            entity.HasOne(d => d.User).WithMany(p => p.UserOpportunity)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserPro__3214EC070E320F34");

            entity.HasOne(d => d.Carrier).WithMany(p => p.UserProduct)
                .HasForeignKey(d => d.CarrierId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Product).WithMany(p => p.UserProduct)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProduct_Product");

            entity.HasOne(d => d.User).WithMany(p => p.UserProduct)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserTimeZones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TimeZone__3214EC071A1AFF4D");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.TimeZone)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC079F6CC205");

            entity.Property(e => e.BodyBackGroundColor).HasMaxLength(50);
            entity.Property(e => e.Colour).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.FacebookLink).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.FooterBackGroundColor).HasMaxLength(50);
            entity.Property(e => e.FooterTextColorH).HasMaxLength(50);
            entity.Property(e => e.FooterTitleColor).HasMaxLength(50);
            entity.Property(e => e.FooterTitleTextSize).HasMaxLength(50);
            entity.Property(e => e.GooglePlusLink).HasMaxLength(200);
            entity.Property(e => e.HeaderBackGroundColor).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.LinkedInLink).HasMaxLength(200);
            entity.Property(e => e.Logo).HasMaxLength(500);
            entity.Property(e => e.Mobile)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NavigationBackGroundColor).HasMaxLength(50);
            entity.Property(e => e.NavigationtextColor).HasMaxLength(50);
            entity.Property(e => e.NavigationtextSize).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProfilePic).HasMaxLength(500);
            entity.Property(e => e.ShortUrl)
                .HasMaxLength(300)
                .HasColumnName("Short_Url");
            entity.Property(e => e.SubNavigationBgcolor)
                .HasMaxLength(50)
                .HasColumnName("SubNavigationBGColor");
            entity.Property(e => e.TwitterLink).HasMaxLength(200);
            entity.Property(e => e.ZipCode).HasMaxLength(20);

            entity.HasOne(d => d.City).WithMany(p => p.Users)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_Users_CityMaster");

            entity.HasOne(d => d.Country).WithMany(p => p.Users)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Users_Country");

            entity.HasOne(d => d.Designation).WithMany(p => p.Users)
                .HasForeignKey(d => d.DesignationId)
                .HasConstraintName("FK_Users_DesignationMaster");

            entity.HasOne(d => d.Parent).WithMany(p => p.UsersParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Users_UserLogin");

            entity.HasOne(d => d.State).WithMany(p => p.Users).HasForeignKey(d => d.StateId);

            entity.HasOne(d => d.UserLogin).WithMany(p => p.UsersUserLogin)
                .HasForeignKey(d => d.UserLoginId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
