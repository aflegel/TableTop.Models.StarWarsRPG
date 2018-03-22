using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StarWarsRPG.Models;

namespace StarWarsRPG.Data
{
    public partial class StarWarsRPGCharacterBuilderContext : DbContext
    {
        public virtual DbSet<ArcType> ArcType { get; set; }
        public virtual DbSet<Armor> Armor { get; set; }
        public virtual DbSet<ArmorReference> ArmorReference { get; set; }
        public virtual DbSet<ArmorType> ArmorType { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AttachmentModification> AttachmentModification { get; set; }
        public virtual DbSet<AttachmentReference> AttachmentReference { get; set; }
        public virtual DbSet<AttachmentType> AttachmentType { get; set; }
        public virtual DbSet<Background> Background { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Career> Career { get; set; }
        public virtual DbSet<CareerSpecialization> CareerSpecialization { get; set; }
        public virtual DbSet<CareerSpecializtionTalent> CareerSpecializtionTalent { get; set; }
        public virtual DbSet<CareerSpecializtionTalentGraph> CareerSpecializtionTalentGraph { get; set; }
        public virtual DbSet<Characteristic> Characteristic { get; set; }
        public virtual DbSet<CharacteristicType> CharacteristicType { get; set; }
        public virtual DbSet<Crew> Crew { get; set; }
        public virtual DbSet<Gear> Gear { get; set; }
        public virtual DbSet<GearAttachmentReference> GearAttachmentReference { get; set; }
        public virtual DbSet<GearQualityReference> GearQualityReference { get; set; }
        public virtual DbSet<GearReference> GearReference { get; set; }
        public virtual DbSet<GearType> GearType { get; set; }
        public virtual DbSet<Hyperdrive> Hyperdrive { get; set; }
        public virtual DbSet<Motivation> Motivation { get; set; }
        public virtual DbSet<Obligation> Obligation { get; set; }
        public virtual DbSet<ObligationType> ObligationType { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<Range> Range { get; set; }
        public virtual DbSet<Rarity> Rarity { get; set; }
        public virtual DbSet<SensorType> SensorType { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SkillReference> SkillReference { get; set; }
        public virtual DbSet<SkillType> SkillType { get; set; }
        public virtual DbSet<SpecialAbility> SpecialAbility { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<SpeciesAbility> SpeciesAbility { get; set; }
        public virtual DbSet<SpeciesReference> SpeciesReference { get; set; }
        public virtual DbSet<Talent> Talent { get; set; }
        public virtual DbSet<TalentReference> TalentReference { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleCrews> VehicleCrews { get; set; }
        public virtual DbSet<VehicleDocks> VehicleDocks { get; set; }
        public virtual DbSet<VehicleReferences> VehicleReferences { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<VehicleWeapons> VehicleWeapons { get; set; }
        public virtual DbSet<Weapon> Weapon { get; set; }
        public virtual DbSet<WeaponQualities> WeaponQualities { get; set; }
        public virtual DbSet<WeaponReferences> WeaponReferences { get; set; }
        public virtual DbSet<WeaponType> WeaponType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=Alex-Desktop;Database=StarWarsRPGCharacterBuilder;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArcType>(entity =>
            {
                entity.ToTable("arcType", "vehicle");

                entity.Property(e => e.ArcTypeId).HasColumnName("arcTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Armor>(entity =>
            {
                entity.ToTable("armor", "gear");

                entity.Property(e => e.ArmorId).HasColumnName("armorId");

                entity.Property(e => e.ArmorTypeId).HasColumnName("armorTypeId");

                entity.Property(e => e.Defense).HasColumnName("defense");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Encumberance).HasColumnName("encumberance");

                entity.Property(e => e.HardPoints).HasColumnName("hardPoints");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RarityId).HasColumnName("rarityID");

                entity.Property(e => e.Restricted).HasColumnName("restricted");

                entity.Property(e => e.Soak).HasColumnName("soak");
            });

            modelBuilder.Entity<ArmorReference>(entity =>
            {
                entity.HasKey(e => new { e.ArmorId, e.BookId });

                entity.ToTable("armorReference", "reference");

                entity.Property(e => e.ArmorId).HasColumnName("armorId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ArmorReference)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_armorReference_book");
            });

            modelBuilder.Entity<ArmorType>(entity =>
            {
                entity.ToTable("armorType", "gear");

                entity.Property(e => e.ArmorTypeId).HasColumnName("armorTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.HasKey(e => e.GearAttachmentId);

                entity.ToTable("attachment", "gear");

                entity.Property(e => e.GearAttachmentId).HasColumnName("gearAttachmentId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Encumberance).HasColumnName("encumberance");

                entity.Property(e => e.GearAttachmentTypeId).HasColumnName("gearAttachmentTypeId");

                entity.Property(e => e.HardPointRequirement).HasColumnName("hardPointRequirement");

                entity.Property(e => e.MaximumProfileId).HasColumnName("maximumProfileId");

                entity.Property(e => e.MinimumProfileId).HasColumnName("minimumProfileId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RarityId).HasColumnName("rarityId");

                entity.Property(e => e.Restricted).HasColumnName("restricted");
            });

            modelBuilder.Entity<AttachmentModification>(entity =>
            {
                entity.ToTable("attachmentModification", "gear");

                entity.Property(e => e.AttachmentModificationId).HasColumnName("attachmentModificationId");

                entity.Property(e => e.AttachmentId).HasColumnName("attachmentId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.AttachmentModification)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("FK_attachmentModification_attachment");
            });

            modelBuilder.Entity<AttachmentReference>(entity =>
            {
                entity.HasKey(e => new { e.AttachmentId, e.BookId });

                entity.ToTable("attachmentReference", "reference");

                entity.Property(e => e.AttachmentId).HasColumnName("attachmentId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.HasKey(e => e.GearAttachmentTypeId);

                entity.ToTable("attachmentType", "gear");

                entity.Property(e => e.GearAttachmentTypeId).HasColumnName("gearAttachmentTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Background>(entity =>
            {
                entity.ToTable("background", "character");

                entity.Property(e => e.BackgroundId).HasColumnName("backgroundId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book", "reference");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Career>(entity =>
            {
                entity.ToTable("career", "character");

                entity.Property(e => e.CareerId).HasColumnName("careerId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<CareerSpecialization>(entity =>
            {
                entity.ToTable("careerSpecialization", "character");

                entity.Property(e => e.CareerSpecializationId).HasColumnName("careerSpecializationId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.CareerId).HasColumnName("careerId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.CareerSpecialization)
                    .HasForeignKey(d => d.CareerId)
                    .HasConstraintName("FK_careerSpecialization_career");
            });

            modelBuilder.Entity<CareerSpecializtionTalent>(entity =>
            {
                entity.HasKey(e => e.CareerTalentId);

                entity.ToTable("careerSpecializtionTalent", "character");

                entity.Property(e => e.CareerTalentId).HasColumnName("careerTalentId");

                entity.Property(e => e.CareerSpecializationId).HasColumnName("careerSpecializationId");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.TalentId).HasColumnName("talentId");

                entity.HasOne(d => d.CareerSpecialization)
                    .WithMany(p => p.CareerSpecializtionTalent)
                    .HasForeignKey(d => d.CareerSpecializationId)
                    .HasConstraintName("FK_talent_careerSpecialization");
            });

            modelBuilder.Entity<CareerSpecializtionTalentGraph>(entity =>
            {
                entity.HasKey(e => new { e.ParentTalentId, e.ChildTalentId });

                entity.ToTable("careerSpecializtionTalentGraph", "character");

                entity.Property(e => e.ParentTalentId).HasColumnName("parentTalentId");

                entity.Property(e => e.ChildTalentId).HasColumnName("childTalentId");

                entity.HasOne(d => d.ChildTalent)
                    .WithMany(p => p.CareerSpecializtionTalentGraphChildTalent)
                    .HasForeignKey(d => d.ChildTalentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_talentGraph_talent");

                entity.HasOne(d => d.ParentTalent)
                    .WithMany(p => p.CareerSpecializtionTalentGraphParentTalent)
                    .HasForeignKey(d => d.ParentTalentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_talentGraph_talent1");
            });

            modelBuilder.Entity<Characteristic>(entity =>
            {
                entity.ToTable("characteristic", "character");

                entity.Property(e => e.CharacteristicId).HasColumnName("characteristicId");

                entity.Property(e => e.CharacteristicTypeId).HasColumnName("characteristicTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CharacteristicType)
                    .WithMany(p => p.Characteristic)
                    .HasForeignKey(d => d.CharacteristicTypeId)
                    .HasConstraintName("FK_characteristic_characteristicType");
            });

            modelBuilder.Entity<CharacteristicType>(entity =>
            {
                entity.ToTable("characteristicType", "character");

                entity.Property(e => e.CharacteristicTypeId).HasColumnName("characteristicTypeId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Crew>(entity =>
            {
                entity.HasKey(e => e.VehicleCrewId);

                entity.ToTable("crew", "vehicle");

                entity.Property(e => e.VehicleCrewId).HasColumnName("vehicleCrewId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Gear>(entity =>
            {
                entity.ToTable("gear", "gear");

                entity.Property(e => e.GearId).HasColumnName("gearId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Encumberance).HasColumnName("encumberance");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RarityId).HasColumnName("rarityId");

                entity.Property(e => e.Restricted).HasColumnName("restricted");
            });

            modelBuilder.Entity<GearAttachmentReference>(entity =>
            {
                entity.HasKey(e => new { e.GearAttachmentId, e.BookId });

                entity.ToTable("gearAttachmentReference", "reference");

                entity.Property(e => e.GearAttachmentId).HasColumnName("gearAttachmentId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.GearAttachmentReference)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gearAttachmentReference_book");
            });

            modelBuilder.Entity<GearQualityReference>(entity =>
            {
                entity.HasKey(e => new { e.GearQualityId, e.BookId });

                entity.ToTable("gearQualityReference", "reference");

                entity.Property(e => e.GearQualityId).HasColumnName("gearQualityId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.GearQualityReference)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gearQualityReference_book");
            });

            modelBuilder.Entity<GearReference>(entity =>
            {
                entity.HasKey(e => new { e.GearId, e.BookId });

                entity.ToTable("gearReference", "reference");

                entity.Property(e => e.GearId).HasColumnName("gearId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.GearReference)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gearReference_book");
            });

            modelBuilder.Entity<GearType>(entity =>
            {
                entity.ToTable("gearType", "gear");

                entity.Property(e => e.GearTypeId).HasColumnName("gearTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hyperdrive>(entity =>
            {
                entity.ToTable("hyperdrive", "vehicle");

                entity.Property(e => e.HyperdriveId).HasColumnName("hyperdriveID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Motivation>(entity =>
            {
                entity.ToTable("motivation", "character");

                entity.Property(e => e.MotivationId).HasColumnName("motivationId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Obligation>(entity =>
            {
                entity.ToTable("obligation", "character");

                entity.Property(e => e.ObligationId).HasColumnName("obligationId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ObligationTypeId).HasColumnName("obligationTypeId");

                entity.HasOne(d => d.ObligationType)
                    .WithMany(p => p.Obligation)
                    .HasForeignKey(d => d.ObligationTypeId)
                    .HasConstraintName("FK_obligation_obligationType");
            });

            modelBuilder.Entity<ObligationType>(entity =>
            {
                entity.ToTable("obligationType", "character");

                entity.Property(e => e.ObligationTypeId).HasColumnName("obligationTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Quality>(entity =>
            {
                entity.ToTable("quality", "gear");

                entity.Property(e => e.QualityId).HasColumnName("qualityId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Passive).HasColumnName("passive");
            });

            modelBuilder.Entity<Range>(entity =>
            {
                entity.ToTable("range", "gear");

                entity.Property(e => e.RangeId).HasColumnName("rangeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Rarity>(entity =>
            {
                entity.ToTable("rarity", "gear");

                entity.Property(e => e.RarityId)
                    .HasColumnName("rarityId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CostMultiplier).HasColumnName("costMultiplier");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SensorType>(entity =>
            {
                entity.HasKey(e => e.VehicleSensorTypeId);

                entity.ToTable("sensorType", "vehicle");

                entity.Property(e => e.VehicleSensorTypeId).HasColumnName("vehicleSensorTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skill", "character");

                entity.Property(e => e.SkillId).HasColumnName("skillId");

                entity.Property(e => e.CharacteristicId).HasColumnName("characteristicId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.SkillTypeId).HasColumnName("skillTypeId");

                entity.HasOne(d => d.Characteristic)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.CharacteristicId)
                    .HasConstraintName("FK_skill_characteristic");
            });

            modelBuilder.Entity<SkillReference>(entity =>
            {
                entity.HasKey(e => new { e.SkillId, e.BookId });

                entity.ToTable("skillReference", "reference");

                entity.Property(e => e.SkillId).HasColumnName("skillId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<SkillType>(entity =>
            {
                entity.ToTable("skillType", "character");

                entity.Property(e => e.SkillTypeId).HasColumnName("skillTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SpecialAbility>(entity =>
            {
                entity.ToTable("specialAbility", "character");

                entity.Property(e => e.SpecialAbilityId).HasColumnName("specialAbilityId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.ToTable("species", "character");

                entity.Property(e => e.SpeciesId).HasColumnName("speciesId");

                entity.Property(e => e.Agility).HasColumnName("agility");

                entity.Property(e => e.Brawn).HasColumnName("brawn");

                entity.Property(e => e.Cunning).HasColumnName("cunning");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Intellect).HasColumnName("intellect");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Presence).HasColumnName("presence");

                entity.Property(e => e.StrainThreshold).HasColumnName("strainThreshold");

                entity.Property(e => e.Willpower).HasColumnName("willpower");

                entity.Property(e => e.WoundThreshold).HasColumnName("woundThreshold");
            });

            modelBuilder.Entity<SpeciesAbility>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.SpecialAbilityId });

                entity.ToTable("speciesAbility", "character");

                entity.Property(e => e.SpeciesId).HasColumnName("speciesId");

                entity.Property(e => e.SpecialAbilityId).HasColumnName("specialAbilityId");
            });

            modelBuilder.Entity<SpeciesReference>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.BookId });

                entity.ToTable("speciesReference", "reference");

                entity.Property(e => e.SpeciesId).HasColumnName("speciesId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.SpeciesReference)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_speciesReference_book");
            });

            modelBuilder.Entity<Talent>(entity =>
            {
                entity.ToTable("talent", "character");

                entity.Property(e => e.TalentId).HasColumnName("talentId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Passive).HasColumnName("passive");
            });

            modelBuilder.Entity<TalentReference>(entity =>
            {
                entity.HasKey(e => new { e.TalentReferenceId, e.BookId });

                entity.ToTable("talentReference", "reference");

                entity.Property(e => e.TalentReferenceId).HasColumnName("talentReferenceId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("vehicle", "vehicle");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.Property(e => e.AltitudeLimit).HasColumnName("altitudeLimit");

                entity.Property(e => e.Armor).HasColumnName("armor");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(50);

                entity.Property(e => e.Consumables)
                    .HasColumnName("consumables")
                    .HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.DefenseAft).HasColumnName("defenseAft");

                entity.Property(e => e.DefenseBow).HasColumnName("defenseBow");

                entity.Property(e => e.DefensePort).HasColumnName("defensePort");

                entity.Property(e => e.DefenseStarport).HasColumnName("defenseStarport");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DroidSocket).HasColumnName("droidSocket");

                entity.Property(e => e.Encumberance)
                    .HasColumnName("encumberance")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Handling).HasColumnName("handling");

                entity.Property(e => e.HardPoints).HasColumnName("hardPoints");

                entity.Property(e => e.HullType)
                    .HasColumnName("hullType")
                    .HasMaxLength(50);

                entity.Property(e => e.HyperdriveBackupId).HasColumnName("hyperdriveBackupId");

                entity.Property(e => e.HyperdrivePrimaryId).HasColumnName("hyperdrivePrimaryId");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturerId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Navicomputer).HasColumnName("navicomputer");

                entity.Property(e => e.PassengerCapacity).HasColumnName("passengerCapacity");

                entity.Property(e => e.RarityId).HasColumnName("rarityId");

                entity.Property(e => e.Restricted).HasColumnName("restricted");

                entity.Property(e => e.SensorTypeId).HasColumnName("sensorTypeId");

                entity.Property(e => e.Silhouette).HasColumnName("silhouette");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.StrainThreshold).HasColumnName("strainThreshold");

                entity.Property(e => e.TraumaThreshold).HasColumnName("traumaThreshold");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");
            });

            modelBuilder.Entity<VehicleCrews>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.CrewId });

                entity.ToTable("vehicleCrews", "vehicle");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.Property(e => e.CrewId).HasColumnName("crewId");
            });

            modelBuilder.Entity<VehicleDocks>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.VehicleDockId });

                entity.ToTable("vehicleDocks", "vehicle");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.Property(e => e.VehicleDockId).HasColumnName("vehicleDockId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<VehicleReferences>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.BookId });

                entity.ToTable("vehicleReferences", "reference");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.VehicleReferences)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_vehicleReferences_book");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("vehicleType", "vehicle");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleWeapons>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.WeaponId });

                entity.ToTable("vehicleWeapons", "vehicle");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.Property(e => e.WeaponId).HasColumnName("weaponId");

                entity.Property(e => e.ArcTypeId).HasColumnName("arcTypeId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Weapon>(entity =>
            {
                entity.ToTable("weapon", "gear");

                entity.Property(e => e.WeaponId).HasColumnName("weaponId");

                entity.Property(e => e.CriticalRating).HasColumnName("criticalRating");

                entity.Property(e => e.Damage).HasColumnName("damage");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Encumberance).HasColumnName("encumberance");

                entity.Property(e => e.HardPoints).HasColumnName("hardPoints");

                entity.Property(e => e.MaximumProfileId).HasColumnName("maximumProfileId");

                entity.Property(e => e.MinimumProfileId).HasColumnName("minimumProfileId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RarityId).HasColumnName("rarityId");

                entity.Property(e => e.Restricted).HasColumnName("restricted");

                entity.Property(e => e.SkillId).HasColumnName("skillId");

                entity.Property(e => e.WeaponRangeId).HasColumnName("weaponRangeId");

                entity.Property(e => e.WeaponTypeId).HasColumnName("weaponTypeID");
            });

            modelBuilder.Entity<WeaponQualities>(entity =>
            {
                entity.HasKey(e => new { e.WeaponId, e.QualityId });

                entity.ToTable("weaponQualities", "gear");

                entity.Property(e => e.WeaponId).HasColumnName("weaponId");

                entity.Property(e => e.QualityId).HasColumnName("qualityId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<WeaponReferences>(entity =>
            {
                entity.HasKey(e => new { e.WeaponId, e.BookId });

                entity.ToTable("weaponReferences", "reference");

                entity.Property(e => e.WeaponId).HasColumnName("weaponId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.WeaponReferences)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_weaponReferences_book");
            });

            modelBuilder.Entity<WeaponType>(entity =>
            {
                entity.ToTable("weaponType", "gear");

                entity.Property(e => e.WeaponTypeId).HasColumnName("weaponTypeId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });
        }
    }
}
