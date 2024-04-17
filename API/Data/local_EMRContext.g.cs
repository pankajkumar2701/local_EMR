using Microsoft.EntityFrameworkCore;
using local_EMR.Entities;

namespace local_EMR.Data
{
    public class local_EMRContext : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GFUVFUP;Initial Catalog=T754323_local_EMR;Persist Security Info=True;user id=pankazz;password=123456;Integrated Security=false;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(a => a.Id);
            modelBuilder.Entity<UserToken>().HasKey(a => a.Id);
            modelBuilder.Entity<RoleEntitlement>().HasKey(a => a.Id);
            modelBuilder.Entity<Entity>().HasKey(a => a.Id);
            modelBuilder.Entity<Tenant>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<Role>().HasKey(a => a.Id);
            modelBuilder.Entity<Patient>().HasKey(a => a.Id);
            modelBuilder.Entity<Doctor>().HasKey(a => a.Id);
            modelBuilder.Entity<Appointment>().HasKey(a => a.Id);
            modelBuilder.Entity<Visit>().HasKey(a => a.Id);
            modelBuilder.Entity<DayVisit>().HasKey(a => a.Id);
            modelBuilder.Entity<Diagnosis>().HasKey(a => a.Id);
            modelBuilder.Entity<Dispense>().HasKey(a => a.Id);
            modelBuilder.Entity<BloodGroup>().HasKey(a => a.Id);
            modelBuilder.Entity<PregnancyHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientNotes>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientAllergy>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientLifeStyle>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientEnrollmentLink>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientHospitalisationHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientMedicalHistoryNote>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientPregnancy>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientStatistics>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientComorbidity>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientPayor>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitMedicalCertificate>().HasKey(a => a.Id);
            modelBuilder.Entity<DispenseActivityHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<DispenseItem>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientPharmacyQueue>().HasKey(a => a.Id);
            modelBuilder.Entity<Medication>().HasKey(a => a.Id);
            modelBuilder.Entity<DrugListItems>().HasKey(a => a.Id);
            modelBuilder.Entity<DoctorFavouriteMedication>().HasKey(a => a.Id);
            modelBuilder.Entity<MedicationComposition>().HasKey(a => a.Id);
            modelBuilder.Entity<DispenseItemDosage>().HasKey(a => a.Id);
            modelBuilder.Entity<MedicationDosage>().HasKey(a => a.Id);
            modelBuilder.Entity<DoctorInvestigation>().HasKey(a => a.Id);
            modelBuilder.Entity<Investigation>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitGuideline>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitDiagnosis>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitType>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitMode>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitChiefComplaint>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentGateway>().HasKey(a => a.Id);
            modelBuilder.Entity<Notification>().HasKey(a => a.Id);
            modelBuilder.Entity<AppointmentReminderLog>().HasKey(a => a.Id);
            modelBuilder.Entity<AccountSettlement>().HasKey(a => a.Id);
            modelBuilder.Entity<AppointmentService>().HasKey(a => a.Id);
            modelBuilder.Entity<Payment>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentMode>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitInvestigation>().HasKey(a => a.Id);
            modelBuilder.Entity<Product>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductBatch>().HasKey(a => a.Id);
            modelBuilder.Entity<FinanceSetting>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductUom>().HasKey(a => a.Id);
            modelBuilder.Entity<GstSettings>().HasKey(a => a.Id);
            modelBuilder.Entity<Invoice>().HasKey(a => a.Id);
            modelBuilder.Entity<InvoiceLine>().HasKey(a => a.Id);
            modelBuilder.Entity<InvoiceFile>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductClassification>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductManufacture>().HasKey(a => a.Id);
            modelBuilder.Entity<Formulation>().HasKey(a => a.Id);
            modelBuilder.Entity<Generic>().HasKey(a => a.Id);
            modelBuilder.Entity<RouteInfo>().HasKey(a => a.Id);
            modelBuilder.Entity<Procedure>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<ChiefComplaint>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<ClinicalParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<ClinicalParameterValue>().HasKey(a => a.Id);
            modelBuilder.Entity<Uom>().HasKey(a => a.Id);
            modelBuilder.Entity<TokenManagement>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceipt>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptPurchaseOrderRelation>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptFile>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptActivityHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptItem>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReturn>().HasKey(a => a.Id);
            modelBuilder.Entity<SubReason>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReturnItem>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReturnFile>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceList>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceListVersion>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceListItem>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceListComponent>().HasKey(a => a.Id);
            modelBuilder.Entity<PurchaseOrder>().HasKey(a => a.Id);
            modelBuilder.Entity<PurchaseOrderLine>().HasKey(a => a.Id);
            modelBuilder.Entity<PurchaseOrderFile>().HasKey(a => a.Id);
            modelBuilder.Entity<Requisition>().HasKey(a => a.Id);
            modelBuilder.Entity<RequisitionLine>().HasKey(a => a.Id);
            modelBuilder.Entity<RequisitionFile>().HasKey(a => a.Id);
            modelBuilder.Entity<StockAdjustment>().HasKey(a => a.Id);
            modelBuilder.Entity<StockAdjustmentItem>().HasKey(a => a.Id);
            modelBuilder.Entity<StockAdjustmentFile>().HasKey(a => a.Id);
            modelBuilder.Entity<State>().HasKey(a => a.Id);
            modelBuilder.Entity<City>().HasKey(a => a.Id);
            modelBuilder.Entity<Specialisation>().HasKey(a => a.Id);
            modelBuilder.Entity<Qualification>().HasKey(a => a.Id);
            modelBuilder.Entity<Comorbidity>().HasKey(a => a.Id);
            modelBuilder.Entity<ContactMember>().HasKey(a => a.Id);
            modelBuilder.Entity<Gender>().HasKey(a => a.Id);
            modelBuilder.Entity<Title>().HasKey(a => a.Id);
            modelBuilder.Entity<Address>().HasKey(a => a.Id);
            modelBuilder.Entity<Country>().HasKey(a => a.Id);
            modelBuilder.Entity<Language>().HasKey(a => a.Id);
            modelBuilder.Entity<Currency>().HasKey(a => a.Id);
            modelBuilder.Entity<Location>().HasKey(a => a.Id);
            modelBuilder.Entity<Membership>().HasKey(a => a.Id);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<UserToken>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserToken>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.EntityId_Entity).WithMany().HasForeignKey(c => c.EntityId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Entity>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<User>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Role>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Patient>().HasOne(a => a.TitleId_Title).WithMany().HasForeignKey(c => c.TitleId);
            modelBuilder.Entity<Patient>().HasOne(a => a.GenderId_Gender).WithMany().HasForeignKey(c => c.GenderId);
            modelBuilder.Entity<Patient>().HasOne(a => a.AddressId_Address).WithMany().HasForeignKey(c => c.AddressId);
            modelBuilder.Entity<Patient>().HasOne(a => a.BloodGroup_BloodGroup).WithMany().HasForeignKey(c => c.BloodGroup);
            modelBuilder.Entity<Patient>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientNotes_PatientNotes).WithMany().HasForeignKey(c => c.PatientNotes);
            modelBuilder.Entity<Patient>().HasOne(a => a.MembershipId_Membership).WithMany().HasForeignKey(c => c.MembershipId);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientAllergy_PatientAllergy).WithMany().HasForeignKey(c => c.PatientAllergy);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientStatistics_PatientStatistics).WithMany().HasForeignKey(c => c.PatientStatistics);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientCategories_PatientCategory).WithMany().HasForeignKey(c => c.PatientCategories);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientComorbidities_PatientComorbidity).WithMany().HasForeignKey(c => c.PatientComorbidities);
            modelBuilder.Entity<Patient>().HasOne(a => a.ContactMembers_ContactMember).WithMany().HasForeignKey(c => c.ContactMembers);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientPayors_PatientPayor).WithMany().HasForeignKey(c => c.PatientPayors);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientLifeStyle_PatientLifeStyle).WithMany().HasForeignKey(c => c.PatientLifeStyle);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientEnrollmentLinks_PatientEnrollmentLink).WithMany().HasForeignKey(c => c.PatientEnrollmentLinks);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientHospitalisationHistories_PatientHospitalisationHistory).WithMany().HasForeignKey(c => c.PatientHospitalisationHistories);
            modelBuilder.Entity<Patient>().HasOne(a => a.PregnancyHistories_PregnancyHistory).WithMany().HasForeignKey(c => c.PregnancyHistories);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientMedicalHistoryNotes_PatientMedicalHistoryNote).WithMany().HasForeignKey(c => c.PatientMedicalHistoryNotes);
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientPregnancies_PatientPregnancy).WithMany().HasForeignKey(c => c.PatientPregnancies);
            modelBuilder.Entity<Patient>().HasOne(a => a.StateId_State).WithMany().HasForeignKey(c => c.StateId);
            modelBuilder.Entity<Patient>().HasOne(a => a.CityId_City).WithMany().HasForeignKey(c => c.CityId);
            modelBuilder.Entity<Patient>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.TitleId_Title).WithMany().HasForeignKey(c => c.TitleId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.OfficialAddressId_Address).WithMany().HasForeignKey(c => c.OfficialAddressId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.LanguageId_Language).WithMany().HasForeignKey(c => c.LanguageId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.GenderId_Gender).WithMany().HasForeignKey(c => c.GenderId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.StateId_State).WithMany().HasForeignKey(c => c.StateId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.CityId_City).WithMany().HasForeignKey(c => c.CityId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.AppointmentServices_AppointmentService).WithMany().HasForeignKey(c => c.AppointmentServices);
            modelBuilder.Entity<Appointment>().HasOne(a => a.AccountSettlements_AccountSettlement).WithMany().HasForeignKey(c => c.AccountSettlements);
            modelBuilder.Entity<Appointment>().HasOne(a => a.AppointmentReminderLogs_AppointmentReminderLog).WithMany().HasForeignKey(c => c.AppointmentReminderLogs);
            modelBuilder.Entity<Appointment>().HasOne(a => a.DayVisits_DayVisit).WithMany().HasForeignKey(c => c.DayVisits);
            modelBuilder.Entity<Appointment>().HasOne(a => a.Notifications_Notification).WithMany().HasForeignKey(c => c.Notifications);
            modelBuilder.Entity<Appointment>().HasOne(a => a.PaymentGateways_PaymentGateway).WithMany().HasForeignKey(c => c.PaymentGateways);
            modelBuilder.Entity<Appointment>().HasOne(a => a.TokenManagement_TokenManagement).WithMany().HasForeignKey(c => c.TokenManagement);
            modelBuilder.Entity<Visit>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Visit>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitType_VisitType).WithMany().HasForeignKey(c => c.VisitType);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitMode_VisitMode).WithMany().HasForeignKey(c => c.VisitMode);
            modelBuilder.Entity<Visit>().HasOne(a => a.Doctor_Doctor).WithMany().HasForeignKey(c => c.Doctor);
            modelBuilder.Entity<Visit>().HasOne(a => a.Contact_Address).WithMany().HasForeignKey(c => c.Contact);
            modelBuilder.Entity<Visit>().HasOne(a => a.Appointment_Appointment).WithMany().HasForeignKey(c => c.Appointment);
            modelBuilder.Entity<Visit>().HasOne(a => a.DayVisit_DayVisit).WithMany().HasForeignKey(c => c.DayVisit);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitChiefComplaint_VisitChiefComplaint).WithMany().HasForeignKey(c => c.VisitChiefComplaint);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitDiagnosis_VisitDiagnosis).WithMany().HasForeignKey(c => c.VisitDiagnosis);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitGuideline_VisitGuideline).WithMany().HasForeignKey(c => c.VisitGuideline);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitVitalTemplateParameter_VisitVitalTemplateParameter).WithMany().HasForeignKey(c => c.VisitVitalTemplateParameter);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitInvestigation_VisitInvestigation).WithMany().HasForeignKey(c => c.VisitInvestigation);
            modelBuilder.Entity<Visit>().HasOne(a => a.Invoice_Invoice).WithMany().HasForeignKey(c => c.Invoice);
            modelBuilder.Entity<Visit>().HasOne(a => a.Dispenses_Dispense).WithMany().HasForeignKey(c => c.Dispenses);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitMedicalCertificates_VisitMedicalCertificate).WithMany().HasForeignKey(c => c.VisitMedicalCertificates);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.DispenseActivityHistory_DispenseActivityHistory).WithMany().HasForeignKey(c => c.DispenseActivityHistory);
            modelBuilder.Entity<Dispense>().HasOne(a => a.DispenseItems_DispenseItem).WithMany().HasForeignKey(c => c.DispenseItems);
            modelBuilder.Entity<Dispense>().HasOne(a => a.PatientPharmacyQueues_PatientPharmacyQueue).WithMany().HasForeignKey(c => c.PatientPharmacyQueues);
            modelBuilder.Entity<PregnancyHistory>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientNotes>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientAllergy>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientLifeStyle>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientEnrollmentLink>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientHospitalisationHistory>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientMedicalHistoryNote>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPregnancy>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientStatistics>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientCategory>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientComorbidity>().HasOne(a => a.ComorbidityId_Comorbidity).WithMany().HasForeignKey(c => c.ComorbidityId);
            modelBuilder.Entity<PatientComorbidity>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPayor>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPayor>().HasOne(a => a.ContactMemberId_ContactMember).WithMany().HasForeignKey(c => c.ContactMemberId);
            modelBuilder.Entity<VisitMedicalCertificate>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<VisitMedicalCertificate>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitMedicalCertificate>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<VisitMedicalCertificate>().HasOne(a => a.InvoiceLineId_InvoiceLine).WithMany().HasForeignKey(c => c.InvoiceLineId);
            modelBuilder.Entity<DispenseActivityHistory>().HasOne(a => a.DispenseId_Dispense).WithMany().HasForeignKey(c => c.DispenseId);
            modelBuilder.Entity<DispenseItem>().HasOne(a => a.DispenseId_Dispense).WithMany().HasForeignKey(c => c.DispenseId);
            modelBuilder.Entity<DispenseItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<DispenseItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<DispenseItem>().HasOne(a => a.DispenseItemDosage_DispenseItemDosage).WithMany().HasForeignKey(c => c.DispenseItemDosage);
            modelBuilder.Entity<PatientPharmacyQueue>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPharmacyQueue>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<PatientPharmacyQueue>().HasOne(a => a.DispenseId_Dispense).WithMany().HasForeignKey(c => c.DispenseId);
            modelBuilder.Entity<Medication>().HasOne(a => a.RouteId_RouteInfo).WithMany().HasForeignKey(c => c.RouteId);
            modelBuilder.Entity<Medication>().HasOne(a => a.MedicationDosages_MedicationDosage).WithMany().HasForeignKey(c => c.MedicationDosages);
            modelBuilder.Entity<Medication>().HasOne(a => a.MedicationCompositions_MedicationComposition).WithMany().HasForeignKey(c => c.MedicationCompositions);
            modelBuilder.Entity<Medication>().HasOne(a => a.DoctorFavouriteMedication_DoctorFavouriteMedication).WithMany().HasForeignKey(c => c.DoctorFavouriteMedication);
            modelBuilder.Entity<Medication>().HasOne(a => a.Product_Product).WithMany().HasForeignKey(c => c.Product);
            modelBuilder.Entity<Medication>().HasOne(a => a.DrugListItems_DrugListItems).WithMany().HasForeignKey(c => c.DrugListItems);
            modelBuilder.Entity<DrugListItems>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<DoctorFavouriteMedication>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<DoctorFavouriteMedication>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<MedicationComposition>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<MedicationComposition>().HasOne(a => a.GenericId_Generic).WithMany().HasForeignKey(c => c.GenericId);
            modelBuilder.Entity<MedicationComposition>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<DispenseItemDosage>().HasOne(a => a.DispenseItemId_DispenseItem).WithMany().HasForeignKey(c => c.DispenseItemId);
            modelBuilder.Entity<DispenseItemDosage>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<MedicationDosage>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<MedicationDosage>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<DoctorInvestigation>().HasOne(a => a.InvestigationId_Investigation).WithMany().HasForeignKey(c => c.InvestigationId);
            modelBuilder.Entity<DoctorInvestigation>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<Investigation>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.ClinicalParameterId_ClinicalParameter).WithMany().HasForeignKey(c => c.ClinicalParameterId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.ClinicalParameterValueId_ClinicalParameterValue).WithMany().HasForeignKey(c => c.ClinicalParameterValueId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<VisitGuideline>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitGuideline>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<VisitDiagnosis>().HasOne(a => a.DiagnosisId_Diagnosis).WithMany().HasForeignKey(c => c.DiagnosisId);
            modelBuilder.Entity<VisitDiagnosis>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitDiagnosis>().HasOne(a => a.VisitDiagnosisParameter_VisitDiagnosisParameter).WithMany().HasForeignKey(c => c.VisitDiagnosisParameter);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.VisitDiagnosisId_VisitDiagnosis).WithMany().HasForeignKey(c => c.VisitDiagnosisId);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.ClinicalParameterId_ClinicalParameter).WithMany().HasForeignKey(c => c.ClinicalParameterId);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.ClinicalParameterValueId_ClinicalParameterValue).WithMany().HasForeignKey(c => c.ClinicalParameterValueId);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<VisitChiefComplaint>().HasOne(a => a.ChiefComplaintId_ChiefComplaint).WithMany().HasForeignKey(c => c.ChiefComplaintId);
            modelBuilder.Entity<VisitChiefComplaint>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Notification>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AppointmentReminderLog>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AccountSettlement>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AccountSettlement>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<AccountSettlement>().HasOne(a => a.Currency_Currency).WithMany().HasForeignKey(c => c.Currency);
            modelBuilder.Entity<AppointmentService>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AppointmentService>().HasOne(a => a.Service_Product).WithMany().HasForeignKey(c => c.Service);
            modelBuilder.Entity<Payment>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Payment>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Payment>().HasOne(a => a.PaymentModeId_PaymentMode).WithMany().HasForeignKey(c => c.PaymentModeId);
            modelBuilder.Entity<Payment>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.DoctorInvestigationId_DoctorInvestigation).WithMany().HasForeignKey(c => c.DoctorInvestigationId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.InvoiceLineId_InvoiceLine).WithMany().HasForeignKey(c => c.InvoiceLineId);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductCategoryId_ProductCategory).WithMany().HasForeignKey(c => c.ProductCategoryId);
            modelBuilder.Entity<Product>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<Product>().HasOne(a => a.Investigation_Investigation).WithMany().HasForeignKey(c => c.Investigation);
            modelBuilder.Entity<Product>().HasOne(a => a.Procedure_Procedure).WithMany().HasForeignKey(c => c.Procedure);
            modelBuilder.Entity<Product>().HasOne(a => a.Contact_Address).WithMany().HasForeignKey(c => c.Contact);
            modelBuilder.Entity<Product>().HasOne(a => a.Formulation_Formulation).WithMany().HasForeignKey(c => c.Formulation);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductManufacture_ProductManufacture).WithMany().HasForeignKey(c => c.ProductManufacture);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductClassification_ProductClassification).WithMany().HasForeignKey(c => c.ProductClassification);
            modelBuilder.Entity<Product>().HasOne(a => a.Uom_Uom).WithMany().HasForeignKey(c => c.Uom);
            modelBuilder.Entity<Product>().HasOne(a => a.GstSettings_GstSettings).WithMany().HasForeignKey(c => c.GstSettings);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductUoms_ProductUom).WithMany().HasForeignKey(c => c.ProductUoms);
            modelBuilder.Entity<Product>().HasOne(a => a.FinanceSettings_FinanceSetting).WithMany().HasForeignKey(c => c.FinanceSettings);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductBatch_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatch);
            modelBuilder.Entity<ProductBatch>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<ProductBatch>().HasOne(a => a.Location_Location).WithMany().HasForeignKey(c => c.Location);
            modelBuilder.Entity<ProductBatch>().HasOne(a => a.Product_Product).WithMany().HasForeignKey(c => c.Product);
            modelBuilder.Entity<ProductBatch>().HasOne(a => a.InvoiceLineId_InvoiceLine).WithMany().HasForeignKey(c => c.InvoiceLineId);
            modelBuilder.Entity<FinanceSetting>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<ProductUom>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<ProductUom>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.Payment_Payment).WithMany().HasForeignKey(c => c.Payment);
            modelBuilder.Entity<Invoice>().HasOne(a => a.Appointment_Appointment).WithMany().HasForeignKey(c => c.Appointment);
            modelBuilder.Entity<Invoice>().HasOne(a => a.DayVisit_DayVisit).WithMany().HasForeignKey(c => c.DayVisit);
            modelBuilder.Entity<Invoice>().HasOne(a => a.ReferredById_Address).WithMany().HasForeignKey(c => c.ReferredById);
            modelBuilder.Entity<Invoice>().HasOne(a => a.InvoiceFiles_InvoiceFile).WithMany().HasForeignKey(c => c.InvoiceFiles);
            modelBuilder.Entity<Invoice>().HasOne(a => a.PayorId_Address).WithMany().HasForeignKey(c => c.PayorId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.InvoiceLineId_InvoiceLine).WithMany().HasForeignKey(c => c.InvoiceLineId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.Dispense_Dispense).WithMany().HasForeignKey(c => c.Dispense);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.GstSettingsId_GstSettings).WithMany().HasForeignKey(c => c.GstSettingsId);
            modelBuilder.Entity<InvoiceFile>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<ProductClassification>().HasOne(a => a.Products_Product).WithMany().HasForeignKey(c => c.Products);
            modelBuilder.Entity<ProductManufacture>().HasOne(a => a.Products_Product).WithMany().HasForeignKey(c => c.Products);
            modelBuilder.Entity<Procedure>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasOne(a => a.ClinicalParameterId_ClinicalParameter).WithMany().HasForeignKey(c => c.ClinicalParameterId);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasOne(a => a.ClinicalParameterValueId_ClinicalParameterValue).WithMany().HasForeignKey(c => c.ClinicalParameterValueId);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<ClinicalParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.DayVisitId_DayVisit).WithMany().HasForeignKey(c => c.DayVisitId);
            modelBuilder.Entity<GoodsReceipt>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<GoodsReceipt>().HasOne(a => a.GoodsReceiptItem_GoodsReceiptItem).WithMany().HasForeignKey(c => c.GoodsReceiptItem);
            modelBuilder.Entity<GoodsReceipt>().HasOne(a => a.GoodsReturns_GoodsReturn).WithMany().HasForeignKey(c => c.GoodsReturns);
            modelBuilder.Entity<GoodsReceipt>().HasOne(a => a.GoodsReceiptActivityHistory_GoodsReceiptActivityHistory).WithMany().HasForeignKey(c => c.GoodsReceiptActivityHistory);
            modelBuilder.Entity<GoodsReceipt>().HasOne(a => a.GoodsReceiptFile_GoodsReceiptFile).WithMany().HasForeignKey(c => c.GoodsReceiptFile);
            modelBuilder.Entity<GoodsReceipt>().HasOne(a => a.GoodsReceiptPurchaseOrderRelation_GoodsReceiptPurchaseOrderRelation).WithMany().HasForeignKey(c => c.GoodsReceiptPurchaseOrderRelation);
            modelBuilder.Entity<GoodsReceiptPurchaseOrderRelation>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptPurchaseOrderRelation>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<GoodsReceiptFile>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptActivityHistory>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.PurchaseOrderLineId_PurchaseOrderLine).WithMany().HasForeignKey(c => c.PurchaseOrderLineId);
            modelBuilder.Entity<GoodsReturn>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReturn>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<GoodsReturn>().HasOne(a => a.GoodsReturnFile_GoodsReturnFile).WithMany().HasForeignKey(c => c.GoodsReturnFile);
            modelBuilder.Entity<GoodsReturn>().HasOne(a => a.GoodsReturnItem_GoodsReturnItem).WithMany().HasForeignKey(c => c.GoodsReturnItem);
            modelBuilder.Entity<GoodsReturn>().HasOne(a => a.SubReason_SubReason).WithMany().HasForeignKey(c => c.SubReason);
            modelBuilder.Entity<SubReason>().HasOne(a => a.GoodsReturns_GoodsReturn).WithMany().HasForeignKey(c => c.GoodsReturns);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.GoodsReturnId_GoodsReturn).WithMany().HasForeignKey(c => c.GoodsReturnId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.GoodsReceiptItemId_GoodsReceiptItem).WithMany().HasForeignKey(c => c.GoodsReceiptItemId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.ProductUom_ProductUom).WithMany().HasForeignKey(c => c.ProductUom);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.SubReason_SubReason).WithMany().HasForeignKey(c => c.SubReason);
            modelBuilder.Entity<GoodsReturnFile>().HasOne(a => a.GoodsReturnId_GoodsReturn).WithMany().HasForeignKey(c => c.GoodsReturnId);
            modelBuilder.Entity<PriceList>().HasOne(a => a.PriceListComponents_PriceListComponent).WithMany().HasForeignKey(c => c.PriceListComponents);
            modelBuilder.Entity<PriceList>().HasOne(a => a.PriceListItems_PriceListItem).WithMany().HasForeignKey(c => c.PriceListItems);
            modelBuilder.Entity<PriceList>().HasOne(a => a.PriceListVersions_PriceListVersion).WithMany().HasForeignKey(c => c.PriceListVersions);
            modelBuilder.Entity<PriceListVersion>().HasOne(a => a.PriceListId_PriceList).WithMany().HasForeignKey(c => c.PriceListId);
            modelBuilder.Entity<PriceListItem>().HasOne(a => a.PriceListId_PriceList).WithMany().HasForeignKey(c => c.PriceListId);
            modelBuilder.Entity<PriceListItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<PriceListItem>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<PriceListComponent>().HasOne(a => a.PriceListId_PriceList).WithMany().HasForeignKey(c => c.PriceListId);
            modelBuilder.Entity<PriceListComponent>().HasOne(a => a.Location_Location).WithMany().HasForeignKey(c => c.Location);
            modelBuilder.Entity<PriceListComponent>().HasOne(a => a.MembershipId_Membership).WithMany().HasForeignKey(c => c.MembershipId);
            modelBuilder.Entity<PurchaseOrder>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<PurchaseOrder>().HasOne(a => a.PurchaseOrderFile_PurchaseOrderFile).WithMany().HasForeignKey(c => c.PurchaseOrderFile);
            modelBuilder.Entity<PurchaseOrder>().HasOne(a => a.Requisition_Requisition).WithMany().HasForeignKey(c => c.Requisition);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.RequisitionId_Requisition).WithMany().HasForeignKey(c => c.RequisitionId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.RequisitionLineId_RequisitionLine).WithMany().HasForeignKey(c => c.RequisitionLineId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<PurchaseOrderFile>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<Requisition>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Requisition>().HasOne(a => a.RequisitionFile_RequisitionFile).WithMany().HasForeignKey(c => c.RequisitionFile);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.RequisitionId_Requisition).WithMany().HasForeignKey(c => c.RequisitionId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.PurchaseOrderLineId_PurchaseOrderLine).WithMany().HasForeignKey(c => c.PurchaseOrderLineId);
            modelBuilder.Entity<RequisitionFile>().HasOne(a => a.RequisitionId_Requisition).WithMany().HasForeignKey(c => c.RequisitionId);
            modelBuilder.Entity<StockAdjustment>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<StockAdjustment>().HasOne(a => a.StockAdjustmentItem_StockAdjustmentItem).WithMany().HasForeignKey(c => c.StockAdjustmentItem);
            modelBuilder.Entity<StockAdjustment>().HasOne(a => a.StockAdjustmentFile_StockAdjustmentFile).WithMany().HasForeignKey(c => c.StockAdjustmentFile);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.StockAdjustmentId_StockAdjustment).WithMany().HasForeignKey(c => c.StockAdjustmentId);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<StockAdjustmentFile>().HasOne(a => a.StockAdjustmentId_StockAdjustment).WithMany().HasForeignKey(c => c.StockAdjustmentId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.TitleId_Title).WithMany().HasForeignKey(c => c.TitleId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.GenderId_Gender).WithMany().HasForeignKey(c => c.GenderId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Address>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<Country>().HasOne(a => a.CurrencyId_Currency).WithMany().HasForeignKey(c => c.CurrencyId);
            modelBuilder.Entity<Country>().HasOne(a => a.LanguageId_Language).WithMany().HasForeignKey(c => c.LanguageId);
            modelBuilder.Entity<Location>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
        }

        public DbSet<UserInRole> UserInRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<RoleEntitlement> RoleEntitlement { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<DayVisit> DayVisit { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Dispense> Dispense { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<PregnancyHistory> PregnancyHistory { get; set; }
        public DbSet<PatientNotes> PatientNotes { get; set; }
        public DbSet<PatientAllergy> PatientAllergy { get; set; }
        public DbSet<PatientLifeStyle> PatientLifeStyle { get; set; }
        public DbSet<PatientEnrollmentLink> PatientEnrollmentLink { get; set; }
        public DbSet<PatientHospitalisationHistory> PatientHospitalisationHistory { get; set; }
        public DbSet<PatientMedicalHistoryNote> PatientMedicalHistoryNote { get; set; }
        public DbSet<PatientPregnancy> PatientPregnancy { get; set; }
        public DbSet<PatientStatistics> PatientStatistics { get; set; }
        public DbSet<PatientCategory> PatientCategory { get; set; }
        public DbSet<PatientComorbidity> PatientComorbidity { get; set; }
        public DbSet<PatientPayor> PatientPayor { get; set; }
        public DbSet<VisitMedicalCertificate> VisitMedicalCertificate { get; set; }
        public DbSet<DispenseActivityHistory> DispenseActivityHistory { get; set; }
        public DbSet<DispenseItem> DispenseItem { get; set; }
        public DbSet<PatientPharmacyQueue> PatientPharmacyQueue { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<DrugListItems> DrugListItems { get; set; }
        public DbSet<DoctorFavouriteMedication> DoctorFavouriteMedication { get; set; }
        public DbSet<MedicationComposition> MedicationComposition { get; set; }
        public DbSet<DispenseItemDosage> DispenseItemDosage { get; set; }
        public DbSet<MedicationDosage> MedicationDosage { get; set; }
        public DbSet<DoctorInvestigation> DoctorInvestigation { get; set; }
        public DbSet<Investigation> Investigation { get; set; }
        public DbSet<VisitVitalTemplateParameter> VisitVitalTemplateParameter { get; set; }
        public DbSet<VisitGuideline> VisitGuideline { get; set; }
        public DbSet<VisitDiagnosis> VisitDiagnosis { get; set; }
        public DbSet<VisitDiagnosisParameter> VisitDiagnosisParameter { get; set; }
        public DbSet<VisitType> VisitType { get; set; }
        public DbSet<VisitMode> VisitMode { get; set; }
        public DbSet<VisitChiefComplaint> VisitChiefComplaint { get; set; }
        public DbSet<PaymentGateway> PaymentGateway { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<AppointmentReminderLog> AppointmentReminderLog { get; set; }
        public DbSet<AccountSettlement> AccountSettlement { get; set; }
        public DbSet<AppointmentService> AppointmentService { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentMode> PaymentMode { get; set; }
        public DbSet<VisitInvestigation> VisitInvestigation { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductBatch> ProductBatch { get; set; }
        public DbSet<FinanceSetting> FinanceSetting { get; set; }
        public DbSet<ProductUom> ProductUom { get; set; }
        public DbSet<GstSettings> GstSettings { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceLine> InvoiceLine { get; set; }
        public DbSet<InvoiceFile> InvoiceFile { get; set; }
        public DbSet<ProductClassification> ProductClassification { get; set; }
        public DbSet<ProductManufacture> ProductManufacture { get; set; }
        public DbSet<Formulation> Formulation { get; set; }
        public DbSet<Generic> Generic { get; set; }
        public DbSet<RouteInfo> RouteInfo { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ChiefComplaint> ChiefComplaint { get; set; }
        public DbSet<VisitChiefComplaintParameter> VisitChiefComplaintParameter { get; set; }
        public DbSet<ClinicalParameter> ClinicalParameter { get; set; }
        public DbSet<ClinicalParameterValue> ClinicalParameterValue { get; set; }
        public DbSet<Uom> Uom { get; set; }
        public DbSet<TokenManagement> TokenManagement { get; set; }
        public DbSet<GoodsReceipt> GoodsReceipt { get; set; }
        public DbSet<GoodsReceiptPurchaseOrderRelation> GoodsReceiptPurchaseOrderRelation { get; set; }
        public DbSet<GoodsReceiptFile> GoodsReceiptFile { get; set; }
        public DbSet<GoodsReceiptActivityHistory> GoodsReceiptActivityHistory { get; set; }
        public DbSet<GoodsReceiptItem> GoodsReceiptItem { get; set; }
        public DbSet<GoodsReturn> GoodsReturn { get; set; }
        public DbSet<SubReason> SubReason { get; set; }
        public DbSet<GoodsReturnItem> GoodsReturnItem { get; set; }
        public DbSet<GoodsReturnFile> GoodsReturnFile { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<PriceListVersion> PriceListVersion { get; set; }
        public DbSet<PriceListItem> PriceListItem { get; set; }
        public DbSet<PriceListComponent> PriceListComponent { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLine { get; set; }
        public DbSet<PurchaseOrderFile> PurchaseOrderFile { get; set; }
        public DbSet<Requisition> Requisition { get; set; }
        public DbSet<RequisitionLine> RequisitionLine { get; set; }
        public DbSet<RequisitionFile> RequisitionFile { get; set; }
        public DbSet<StockAdjustment> StockAdjustment { get; set; }
        public DbSet<StockAdjustmentItem> StockAdjustmentItem { get; set; }
        public DbSet<StockAdjustmentFile> StockAdjustmentFile { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Specialisation> Specialisation { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Comorbidity> Comorbidity { get; set; }
        public DbSet<ContactMember> ContactMember { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Membership> Membership { get; set; }
    }
}