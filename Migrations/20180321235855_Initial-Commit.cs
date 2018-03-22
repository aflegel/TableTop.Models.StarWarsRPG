using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsRPG.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "vehicle");

            migrationBuilder.EnsureSchema(
                name: "gear");

            migrationBuilder.EnsureSchema(
                name: "reference");

            migrationBuilder.EnsureSchema(
                name: "character");

            migrationBuilder.CreateTable(
                name: "background",
                schema: "character",
                columns: table => new
                {
                    backgroundId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    bookId = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_background", x => x.backgroundId);
                });

            migrationBuilder.CreateTable(
                name: "career",
                schema: "character",
                columns: table => new
                {
                    careerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    bookId = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_career", x => x.careerId);
                });

            migrationBuilder.CreateTable(
                name: "characteristicType",
                schema: "character",
                columns: table => new
                {
                    characteristicTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characteristicType", x => x.characteristicTypeId);
                });

            migrationBuilder.CreateTable(
                name: "motivation",
                schema: "character",
                columns: table => new
                {
                    motivationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motivation", x => x.motivationId);
                });

            migrationBuilder.CreateTable(
                name: "obligationType",
                schema: "character",
                columns: table => new
                {
                    obligationTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_obligationType", x => x.obligationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "skillType",
                schema: "character",
                columns: table => new
                {
                    skillTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skillType", x => x.skillTypeId);
                });

            migrationBuilder.CreateTable(
                name: "specialAbility",
                schema: "character",
                columns: table => new
                {
                    specialAbilityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialAbility", x => x.specialAbilityId);
                });

            migrationBuilder.CreateTable(
                name: "species",
                schema: "character",
                columns: table => new
                {
                    speciesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    brawn = table.Column<int>(nullable: true),
                    agility = table.Column<int>(nullable: true),
                    intellect = table.Column<int>(nullable: true),
                    cunning = table.Column<int>(nullable: true),
                    willpower = table.Column<int>(nullable: true),
                    presence = table.Column<int>(nullable: true),
                    woundThreshold = table.Column<int>(nullable: true),
                    experience = table.Column<int>(nullable: true),
                    strainThreshold = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_species", x => x.speciesId);
                });

            migrationBuilder.CreateTable(
                name: "speciesAbility",
                schema: "character",
                columns: table => new
                {
                    speciesId = table.Column<int>(nullable: false),
                    specialAbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciesAbility", x => new { x.speciesId, x.specialAbilityId });
                });

            migrationBuilder.CreateTable(
                name: "talent",
                schema: "character",
                columns: table => new
                {
                    talentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    passive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talent", x => x.talentId);
                });

            migrationBuilder.CreateTable(
                name: "armor",
                schema: "gear",
                columns: table => new
                {
                    armorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    defense = table.Column<int>(nullable: true),
                    soak = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: true),
                    encumberance = table.Column<int>(nullable: true),
                    hardPoints = table.Column<int>(nullable: true),
                    rarityID = table.Column<int>(nullable: true),
                    armorTypeId = table.Column<int>(nullable: true),
                    restricted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armor", x => x.armorId);
                });

            migrationBuilder.CreateTable(
                name: "armorType",
                schema: "gear",
                columns: table => new
                {
                    armorTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armorType", x => x.armorTypeId);
                });

            migrationBuilder.CreateTable(
                name: "attachment",
                schema: "gear",
                columns: table => new
                {
                    gearAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    gearAttachmentTypeId = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: true),
                    encumberance = table.Column<int>(nullable: true),
                    hardPointRequirement = table.Column<int>(nullable: true),
                    rarityId = table.Column<int>(nullable: true),
                    restricted = table.Column<bool>(nullable: true),
                    minimumProfileId = table.Column<int>(nullable: true),
                    maximumProfileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachment", x => x.gearAttachmentId);
                });

            migrationBuilder.CreateTable(
                name: "attachmentType",
                schema: "gear",
                columns: table => new
                {
                    gearAttachmentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachmentType", x => x.gearAttachmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "gear",
                schema: "gear",
                columns: table => new
                {
                    gearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: true),
                    encumberance = table.Column<int>(nullable: true),
                    rarityId = table.Column<int>(nullable: true),
                    restricted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gear", x => x.gearId);
                });

            migrationBuilder.CreateTable(
                name: "gearType",
                schema: "gear",
                columns: table => new
                {
                    gearTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gearType", x => x.gearTypeId);
                });

            migrationBuilder.CreateTable(
                name: "quality",
                schema: "gear",
                columns: table => new
                {
                    qualityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    passive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quality", x => x.qualityId);
                });

            migrationBuilder.CreateTable(
                name: "range",
                schema: "gear",
                columns: table => new
                {
                    rangeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_range", x => x.rangeId);
                });

            migrationBuilder.CreateTable(
                name: "rarity",
                schema: "gear",
                columns: table => new
                {
                    rarityId = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    costMultiplier = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rarity", x => x.rarityId);
                });

            migrationBuilder.CreateTable(
                name: "weapon",
                schema: "gear",
                columns: table => new
                {
                    weaponId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    weaponTypeID = table.Column<int>(nullable: true),
                    skillId = table.Column<int>(nullable: true),
                    weaponRangeId = table.Column<int>(nullable: true),
                    encumberance = table.Column<int>(nullable: true),
                    hardPoints = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: true),
                    rarityId = table.Column<int>(nullable: true),
                    criticalRating = table.Column<int>(nullable: true),
                    damage = table.Column<int>(nullable: true),
                    restricted = table.Column<bool>(nullable: true),
                    minimumProfileId = table.Column<int>(nullable: true),
                    maximumProfileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weapon", x => x.weaponId);
                });

            migrationBuilder.CreateTable(
                name: "weaponQualities",
                schema: "gear",
                columns: table => new
                {
                    weaponId = table.Column<int>(nullable: false),
                    qualityId = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponQualities", x => new { x.weaponId, x.qualityId });
                });

            migrationBuilder.CreateTable(
                name: "weaponType",
                schema: "gear",
                columns: table => new
                {
                    weaponTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponType", x => x.weaponTypeId);
                });

            migrationBuilder.CreateTable(
                name: "attachmentReference",
                schema: "reference",
                columns: table => new
                {
                    attachmentId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachmentReference", x => new { x.attachmentId, x.bookId });
                });

            migrationBuilder.CreateTable(
                name: "book",
                schema: "reference",
                columns: table => new
                {
                    bookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.bookId);
                });

            migrationBuilder.CreateTable(
                name: "skillReference",
                schema: "reference",
                columns: table => new
                {
                    skillId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skillReference", x => new { x.skillId, x.bookId });
                });

            migrationBuilder.CreateTable(
                name: "talentReference",
                schema: "reference",
                columns: table => new
                {
                    talentReferenceId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talentReference", x => new { x.talentReferenceId, x.bookId });
                });

            migrationBuilder.CreateTable(
                name: "arcType",
                schema: "vehicle",
                columns: table => new
                {
                    arcTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arcType", x => x.arcTypeId);
                });

            migrationBuilder.CreateTable(
                name: "crew",
                schema: "vehicle",
                columns: table => new
                {
                    vehicleCrewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crew", x => x.vehicleCrewId);
                });

            migrationBuilder.CreateTable(
                name: "hyperdrive",
                schema: "vehicle",
                columns: table => new
                {
                    hyperdriveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hyperdrive", x => x.hyperdriveID);
                });

            migrationBuilder.CreateTable(
                name: "sensorType",
                schema: "vehicle",
                columns: table => new
                {
                    vehicleSensorTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sensorType", x => x.vehicleSensorTypeId);
                });

            migrationBuilder.CreateTable(
                name: "vehicle",
                schema: "vehicle",
                columns: table => new
                {
                    vehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    vehicleTypeId = table.Column<int>(nullable: true),
                    encumberance = table.Column<decimal>(type: "decimal(18, 1)", nullable: true),
                    sensorTypeId = table.Column<int>(nullable: true),
                    altitudeLimit = table.Column<int>(nullable: true),
                    passengerCapacity = table.Column<int>(nullable: true),
                    cost = table.Column<int>(nullable: true),
                    rarityId = table.Column<int>(nullable: true),
                    hardPoints = table.Column<int>(nullable: true),
                    silhouette = table.Column<int>(nullable: true),
                    speed = table.Column<int>(nullable: true),
                    handling = table.Column<int>(nullable: true),
                    defenseBow = table.Column<int>(nullable: true),
                    defenseAft = table.Column<int>(nullable: true),
                    defensePort = table.Column<int>(nullable: true),
                    defenseStarport = table.Column<int>(nullable: true),
                    armor = table.Column<int>(nullable: true),
                    traumaThreshold = table.Column<int>(nullable: true),
                    strainThreshold = table.Column<int>(nullable: true),
                    navicomputer = table.Column<bool>(nullable: true),
                    consumables = table.Column<string>(maxLength: 50, nullable: true),
                    hyperdrivePrimaryId = table.Column<int>(nullable: true),
                    hyperdriveBackupId = table.Column<int>(nullable: true),
                    restricted = table.Column<bool>(nullable: true),
                    hullType = table.Column<string>(maxLength: 50, nullable: true),
                    @class = table.Column<string>(name: "class", maxLength: 50, nullable: true),
                    manufacturerId = table.Column<int>(nullable: true),
                    droidSocket = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle", x => x.vehicleId);
                });

            migrationBuilder.CreateTable(
                name: "vehicleCrews",
                schema: "vehicle",
                columns: table => new
                {
                    vehicleId = table.Column<int>(nullable: false),
                    crewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleCrews", x => new { x.vehicleId, x.crewId });
                });

            migrationBuilder.CreateTable(
                name: "vehicleDocks",
                schema: "vehicle",
                columns: table => new
                {
                    vehicleId = table.Column<int>(nullable: false),
                    vehicleDockId = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleDocks", x => new { x.vehicleId, x.vehicleDockId });
                });

            migrationBuilder.CreateTable(
                name: "vehicleType",
                schema: "vehicle",
                columns: table => new
                {
                    vehicleTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleType", x => x.vehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "vehicleWeapons",
                schema: "vehicle",
                columns: table => new
                {
                    vehicleId = table.Column<int>(nullable: false),
                    weaponId = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: true),
                    arcTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleWeapons", x => new { x.vehicleId, x.weaponId });
                });

            migrationBuilder.CreateTable(
                name: "careerSpecialization",
                schema: "character",
                columns: table => new
                {
                    careerSpecializationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    careerId = table.Column<int>(nullable: true),
                    bookId = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_careerSpecialization", x => x.careerSpecializationId);
                    table.ForeignKey(
                        name: "FK_careerSpecialization_career",
                        column: x => x.careerId,
                        principalSchema: "character",
                        principalTable: "career",
                        principalColumn: "careerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "characteristic",
                schema: "character",
                columns: table => new
                {
                    characteristicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    characteristicTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characteristic", x => x.characteristicId);
                    table.ForeignKey(
                        name: "FK_characteristic_characteristicType",
                        column: x => x.characteristicTypeId,
                        principalSchema: "character",
                        principalTable: "characteristicType",
                        principalColumn: "characteristicTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "obligation",
                schema: "character",
                columns: table => new
                {
                    obligationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    obligationTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_obligation", x => x.obligationId);
                    table.ForeignKey(
                        name: "FK_obligation_obligationType",
                        column: x => x.obligationTypeId,
                        principalSchema: "character",
                        principalTable: "obligationType",
                        principalColumn: "obligationTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "attachmentModification",
                schema: "gear",
                columns: table => new
                {
                    attachmentModificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    attachmentId = table.Column<int>(nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachmentModification", x => x.attachmentModificationId);
                    table.ForeignKey(
                        name: "FK_attachmentModification_attachment",
                        column: x => x.attachmentId,
                        principalSchema: "gear",
                        principalTable: "attachment",
                        principalColumn: "gearAttachmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "armorReference",
                schema: "reference",
                columns: table => new
                {
                    armorId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armorReference", x => new { x.armorId, x.bookId });
                    table.ForeignKey(
                        name: "FK_armorReference_book",
                        column: x => x.bookId,
                        principalSchema: "reference",
                        principalTable: "book",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gearAttachmentReference",
                schema: "reference",
                columns: table => new
                {
                    gearAttachmentId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gearAttachmentReference", x => new { x.gearAttachmentId, x.bookId });
                    table.ForeignKey(
                        name: "FK_gearAttachmentReference_book",
                        column: x => x.bookId,
                        principalSchema: "reference",
                        principalTable: "book",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gearQualityReference",
                schema: "reference",
                columns: table => new
                {
                    gearQualityId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gearQualityReference", x => new { x.gearQualityId, x.bookId });
                    table.ForeignKey(
                        name: "FK_gearQualityReference_book",
                        column: x => x.bookId,
                        principalSchema: "reference",
                        principalTable: "book",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gearReference",
                schema: "reference",
                columns: table => new
                {
                    gearId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gearReference", x => new { x.gearId, x.bookId });
                    table.ForeignKey(
                        name: "FK_gearReference_book",
                        column: x => x.bookId,
                        principalSchema: "reference",
                        principalTable: "book",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "speciesReference",
                schema: "reference",
                columns: table => new
                {
                    speciesId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciesReference", x => new { x.speciesId, x.bookId });
                    table.ForeignKey(
                        name: "FK_speciesReference_book",
                        column: x => x.bookId,
                        principalSchema: "reference",
                        principalTable: "book",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehicleReferences",
                schema: "reference",
                columns: table => new
                {
                    vehicleId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleReferences", x => new { x.vehicleId, x.bookId });
                    table.ForeignKey(
                        name: "FK_vehicleReferences_book",
                        column: x => x.bookId,
                        principalSchema: "reference",
                        principalTable: "book",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weaponReferences",
                schema: "reference",
                columns: table => new
                {
                    weaponId = table.Column<int>(nullable: false),
                    bookId = table.Column<int>(nullable: false),
                    page = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponReferences", x => new { x.weaponId, x.bookId });
                    table.ForeignKey(
                        name: "FK_weaponReferences_book",
                        column: x => x.bookId,
                        principalSchema: "reference",
                        principalTable: "book",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "careerSpecializtionTalent",
                schema: "character",
                columns: table => new
                {
                    careerTalentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    careerSpecializationId = table.Column<int>(nullable: true),
                    cost = table.Column<int>(nullable: true),
                    talentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_careerSpecializtionTalent", x => x.careerTalentId);
                    table.ForeignKey(
                        name: "FK_talent_careerSpecialization",
                        column: x => x.careerSpecializationId,
                        principalSchema: "character",
                        principalTable: "careerSpecialization",
                        principalColumn: "careerSpecializationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                schema: "character",
                columns: table => new
                {
                    skillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(nullable: true),
                    characteristicId = table.Column<int>(nullable: true),
                    skillTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.skillId);
                    table.ForeignKey(
                        name: "FK_skill_characteristic",
                        column: x => x.characteristicId,
                        principalSchema: "character",
                        principalTable: "characteristic",
                        principalColumn: "characteristicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "careerSpecializtionTalentGraph",
                schema: "character",
                columns: table => new
                {
                    parentTalentId = table.Column<int>(nullable: false),
                    childTalentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_careerSpecializtionTalentGraph", x => new { x.parentTalentId, x.childTalentId });
                    table.ForeignKey(
                        name: "FK_talentGraph_talent",
                        column: x => x.childTalentId,
                        principalSchema: "character",
                        principalTable: "careerSpecializtionTalent",
                        principalColumn: "careerTalentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_talentGraph_talent1",
                        column: x => x.parentTalentId,
                        principalSchema: "character",
                        principalTable: "careerSpecializtionTalent",
                        principalColumn: "careerTalentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_careerSpecialization_careerId",
                schema: "character",
                table: "careerSpecialization",
                column: "careerId");

            migrationBuilder.CreateIndex(
                name: "IX_careerSpecializtionTalent_careerSpecializationId",
                schema: "character",
                table: "careerSpecializtionTalent",
                column: "careerSpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_careerSpecializtionTalentGraph_childTalentId",
                schema: "character",
                table: "careerSpecializtionTalentGraph",
                column: "childTalentId");

            migrationBuilder.CreateIndex(
                name: "IX_characteristic_characteristicTypeId",
                schema: "character",
                table: "characteristic",
                column: "characteristicTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_obligation_obligationTypeId",
                schema: "character",
                table: "obligation",
                column: "obligationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_skill_characteristicId",
                schema: "character",
                table: "skill",
                column: "characteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_attachmentModification_attachmentId",
                schema: "gear",
                table: "attachmentModification",
                column: "attachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_armorReference_bookId",
                schema: "reference",
                table: "armorReference",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_gearAttachmentReference_bookId",
                schema: "reference",
                table: "gearAttachmentReference",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_gearQualityReference_bookId",
                schema: "reference",
                table: "gearQualityReference",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_gearReference_bookId",
                schema: "reference",
                table: "gearReference",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_speciesReference_bookId",
                schema: "reference",
                table: "speciesReference",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleReferences_bookId",
                schema: "reference",
                table: "vehicleReferences",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_weaponReferences_bookId",
                schema: "reference",
                table: "weaponReferences",
                column: "bookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "background",
                schema: "character");

            migrationBuilder.DropTable(
                name: "careerSpecializtionTalentGraph",
                schema: "character");

            migrationBuilder.DropTable(
                name: "motivation",
                schema: "character");

            migrationBuilder.DropTable(
                name: "obligation",
                schema: "character");

            migrationBuilder.DropTable(
                name: "skill",
                schema: "character");

            migrationBuilder.DropTable(
                name: "skillType",
                schema: "character");

            migrationBuilder.DropTable(
                name: "specialAbility",
                schema: "character");

            migrationBuilder.DropTable(
                name: "species",
                schema: "character");

            migrationBuilder.DropTable(
                name: "speciesAbility",
                schema: "character");

            migrationBuilder.DropTable(
                name: "talent",
                schema: "character");

            migrationBuilder.DropTable(
                name: "armor",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "armorType",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "attachmentModification",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "attachmentType",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "gear",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "gearType",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "quality",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "range",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "rarity",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "weapon",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "weaponQualities",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "weaponType",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "armorReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "attachmentReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "gearAttachmentReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "gearQualityReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "gearReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "skillReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "speciesReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "talentReference",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "vehicleReferences",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "weaponReferences",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "arcType",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "crew",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "hyperdrive",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "sensorType",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "vehicle",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "vehicleCrews",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "vehicleDocks",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "vehicleType",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "vehicleWeapons",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "careerSpecializtionTalent",
                schema: "character");

            migrationBuilder.DropTable(
                name: "obligationType",
                schema: "character");

            migrationBuilder.DropTable(
                name: "characteristic",
                schema: "character");

            migrationBuilder.DropTable(
                name: "attachment",
                schema: "gear");

            migrationBuilder.DropTable(
                name: "book",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "careerSpecialization",
                schema: "character");

            migrationBuilder.DropTable(
                name: "characteristicType",
                schema: "character");

            migrationBuilder.DropTable(
                name: "career",
                schema: "character");
        }
    }
}
