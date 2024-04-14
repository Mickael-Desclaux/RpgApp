CREATE TABLE [PlayerCharacter] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [ClassId] integer,
  [RaceId] integer,
  [RaceTraitId] integer,
  [CharacterDescriptionId] integer,
  [PlayerCharacterSpellId] integer,
  [PlayerCharacterEquipmentId] integer,
  [PlayerCharacterFeatId] integer,
  [BackgroundId] integer,
  [AlignmentId] integer,
  [RoleplayId] integer,
  [ImageId] integer,
  [CroppedImageId] integer,
  [PlayerName] nvarchar(30),
  [CharacterName] nvarchar(30),
  [BackStory] nvarchar(max),
  [Gold] integer,
  [Notes] nvarchar(max)
)
GO

CREATE TABLE [DiceType] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Sides] integer
)
GO

CREATE TABLE [PlayerStat] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [PlayerId] integer,
  [DiceTypeId] integer,
  [BaseStatId] integer,
  [SavingStatId] integer,
  [SkillStatId] integer,
  [Level] integer,
  [MaxHp] integer,
  [CurrentHp] integer,
  [ArmorClass] integer,
  [Initiative] integer
)
GO

CREATE TABLE [NonPlayerCharacter] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [ChapterId] integer,
  [Name] nvarchar(50),
  [ImageId] integer,
  [CharacterDescription] nvarchar(max),
  [Note] nvarchar(max)
)
GO

CREATE TABLE [Monster] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [RaceId] integer,
  [AlignmentId] integer,
  [BaseStatId] integer,
  [SavingStatId] integer,
  [SkillStatId] integer,
  [PassiveSkillId] integer,
  [MonsterActionId] integer,
  [Name] nvarchar(50),
  [MaxHp] integer,
  [CurrentHp] integer,
  [ArmorClass] integer,
  [Initiative] integer,
  [Note] nvarchar(max)
)
GO

CREATE TABLE [MonsterResistance] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [MonsterId] integer,
  [ResistanceId] integer
)
GO

CREATE TABLE [MonsterImmunity] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [MonsterId] integer,
  [ImmunityId] integer
)
GO

CREATE TABLE [MonsterLanguage] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [MonsterId] integer,
  [LanguageId] integer
)
GO

CREATE TABLE [PlayerCharacterSpell] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [SpellId] integer
)
GO

CREATE TABLE [Spell] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Level] integer,
  [Name] nvarchar(100),
  [Description] nvarchar(max)
)
GO

CREATE TABLE [Image] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50),
  [Image] varbinary(max)
)
GO

CREATE TABLE [Class] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50),
  [ImageId] integer
)
GO

CREATE TABLE [ClassSkill] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [PlayerId] integer,
  [Name] nvarchar(50),
  [Description] nvarchar(max)
)
GO

CREATE TABLE [Race] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50)
)
GO

CREATE TABLE [RaceTrait] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50),
  [Description] nvarchar(max)
)
GO

CREATE TABLE [PlayerCharacterFeat] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [FeatId] integer
)
GO

CREATE TABLE [Feat] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50),
  [Description] nvarchar(max)
)
GO

CREATE TABLE [PlayerCharacterLanguage] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [PlayerId] integer,
  [LanguageId] integer
)
GO

CREATE TABLE [Language] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50)
)
GO

CREATE TABLE [Background] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50),
  [Description] nvarchar(max)
)
GO

CREATE TABLE [Alignment] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Morality] nvarchar(50),
  [Attitude] nvarchar(50)
)
GO

CREATE TABLE [BaseStat] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Strength] integer,
  [Dexterity] integer,
  [Constitution] integer,
  [Intelligence] integer,
  [Wisdom] integer,
  [Charisma] integer,
  [PassivePerception] integer
)
GO

CREATE TABLE [SavingStat] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Strength] integer,
  [Dexterity] integer,
  [Constitution] integer,
  [Intelligence] integer,
  [Wisdom] integer,
  [Charisma] integer
)
GO

CREATE TABLE [SkillStat] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Acrobatics] integer,
  [AnimalHandling] integer,
  [Arcana] integer,
  [Athletics] integer,
  [Deception] integer,
  [History] integer,
  [Insight] integer,
  [Intimidation] integer,
  [Investigation] integer,
  [Medicine] integer,
  [Nature] integer,
  [Perception] integer,
  [Performance] integer,
  [Persuasion] integer,
  [Religion] integer,
  [SleightOfHands] integer,
  [Stealth] integer,
  [Survival] integer
)
GO

CREATE TABLE [PlayerCharacterResistance] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [PlayerId] integer,
  [ResistanceId] integer
)
GO

CREATE TABLE [Resistance] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50)
)
GO

CREATE TABLE [PlayerCharacterImmunity] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [PlayerId] integer,
  [ImmunityId] integer
)
GO

CREATE TABLE [Immunity] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50)
)
GO

CREATE TABLE [MonsterPassiveSkill] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50),
  [Description] nvarchar(max)
)
GO

CREATE TABLE [MonsterAction] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50),
  [Description] nvarchar(max)
)
GO

CREATE TABLE [Roleplay] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [PersonalityTrait] nvarchar(255),
  [Ideal] nvarchar(255),
  [Bond] nvarchar(255),
  [Flaw] nvarchar(255)
)
GO

CREATE TABLE [PlayerCharacterEquipment] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [EquipmentId] integer
)
GO

CREATE TABLE [Equipment] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [TypeId] integer,
  [Name] nvarchar(50),
  [Description] nvarchar(max),
  [ImageId] integer
)
GO

CREATE TABLE [EquipmentType] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(50)
)
GO

CREATE TABLE [CharacterDescription] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Age] integer,
  [Height] decimal,
  [Weight] integer,
  [EyesColor] nvarchar(50),
  [SkinColor] nvarchar(50),
  [HairColor] nvarchar(50)
)
GO

CREATE TABLE [Chapter] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [Name] nvarchar(255)
)
GO

CREATE TABLE [GameMasterNote] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [ChapterId] integer,
  [Title] nvarchar(255),
  [Content] nvarchar(max),
  [ImageId] integer
)
GO

CREATE TABLE [Map] (
  [Id] integer IDENTITY(1,1) PRIMARY KEY,
  [ChapterId] integer,
  [Title] nvarchar(255),
  [Description] nvarchar(max),
  [ImageId] integer
)
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([ClassId]) REFERENCES [Class] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([RaceId]) REFERENCES [Race] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([CharacterDescriptionId]) REFERENCES [CharacterDescription] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([BackgroundId]) REFERENCES [Background] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([AlignmentId]) REFERENCES [Alignment] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([RoleplayId]) REFERENCES [Roleplay] ([Id])
GO

ALTER TABLE [PlayerCharacterResistance] ADD FOREIGN KEY ([PlayerId]) REFERENCES [PlayerCharacter] ([Id])
GO

ALTER TABLE [PlayerCharacterSpell] ADD FOREIGN KEY ([SpellId]) REFERENCES [Spell] ([Id])
GO

ALTER TABLE [PlayerCharacterResistance] ADD FOREIGN KEY ([ResistanceId]) REFERENCES [Resistance] ([Id])
GO

ALTER TABLE [PlayerCharacterFeat] ADD FOREIGN KEY ([FeatId]) REFERENCES [Feat] ([Id])
GO

ALTER TABLE [PlayerCharacterImmunity] ADD FOREIGN KEY ([PlayerId]) REFERENCES [PlayerCharacter] ([Id])
GO

ALTER TABLE [PlayerCharacterImmunity] ADD FOREIGN KEY ([ImmunityId]) REFERENCES [Immunity] ([Id])
GO

ALTER TABLE [PlayerCharacterEquipment] ADD FOREIGN KEY ([EquipmentId]) REFERENCES [Equipment] ([Id])
GO

ALTER TABLE [PlayerCharacterLanguage] ADD FOREIGN KEY ([PlayerId]) REFERENCES [PlayerCharacter] ([Id])
GO

ALTER TABLE [PlayerCharacterLanguage] ADD FOREIGN KEY ([LanguageId]) REFERENCES [Language] ([Id])
GO

ALTER TABLE [PlayerStat] ADD FOREIGN KEY ([PlayerId]) REFERENCES [PlayerCharacter] ([Id])
GO

ALTER TABLE [ClassSkill] ADD FOREIGN KEY ([PlayerId]) REFERENCES [PlayerCharacter] ([Id])
GO

ALTER TABLE [GameMasterNote] ADD FOREIGN KEY ([ChapterId]) REFERENCES [Chapter] ([Id])
GO

ALTER TABLE [Map] ADD FOREIGN KEY ([ChapterId]) REFERENCES [Chapter] ([Id])
GO

ALTER TABLE [NonPlayerCharacter] ADD FOREIGN KEY ([ChapterId]) REFERENCES [Chapter] ([Id])
GO

ALTER TABLE [Monster] ADD FOREIGN KEY ([AlignmentId]) REFERENCES [Alignment] ([Id])
GO

ALTER TABLE [Monster] ADD FOREIGN KEY ([RaceId]) REFERENCES [Race] ([Id])
GO

ALTER TABLE [Monster] ADD FOREIGN KEY ([PassiveSkillId]) REFERENCES [MonsterPassiveSkill] ([Id])
GO

ALTER TABLE [PlayerStat] ADD FOREIGN KEY ([BaseStatId]) REFERENCES [BaseStat] ([Id])
GO

ALTER TABLE [PlayerStat] ADD FOREIGN KEY ([SavingStatId]) REFERENCES [SavingStat] ([Id])
GO

ALTER TABLE [PlayerStat] ADD FOREIGN KEY ([SkillStatId]) REFERENCES [SkillStat] ([Id])
GO

ALTER TABLE [Monster] ADD FOREIGN KEY ([SavingStatId]) REFERENCES [SavingStat] ([Id])
GO

ALTER TABLE [Monster] ADD FOREIGN KEY ([SkillStatId]) REFERENCES [SkillStat] ([Id])
GO

ALTER TABLE [Monster] ADD FOREIGN KEY ([BaseStatId]) REFERENCES [BaseStat] ([Id])
GO

ALTER TABLE [MonsterImmunity] ADD FOREIGN KEY ([MonsterId]) REFERENCES [Monster] ([Id])
GO

ALTER TABLE [MonsterResistance] ADD FOREIGN KEY ([MonsterId]) REFERENCES [Monster] ([Id])
GO

ALTER TABLE [MonsterLanguage] ADD FOREIGN KEY ([MonsterId]) REFERENCES [Monster] ([Id])
GO

ALTER TABLE [MonsterLanguage] ADD FOREIGN KEY ([LanguageId]) REFERENCES [Language] ([Id])
GO

ALTER TABLE [MonsterImmunity] ADD FOREIGN KEY ([ImmunityId]) REFERENCES [Immunity] ([Id])
GO

ALTER TABLE [MonsterResistance] ADD FOREIGN KEY ([ResistanceId]) REFERENCES [Resistance] ([Id])
GO

ALTER TABLE [Equipment] ADD FOREIGN KEY ([TypeId]) REFERENCES [EquipmentType] ([Id])
GO

ALTER TABLE [PlayerStat] ADD FOREIGN KEY ([DiceTypeId]) REFERENCES [DiceType] ([Id])
GO

ALTER TABLE [Monster] ADD FOREIGN KEY ([MonsterActionId]) REFERENCES [MonsterAction] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([RaceTraitId]) REFERENCES [RaceTrait] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([PlayerCharacterSpellId]) REFERENCES [PlayerCharacterSpell] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([PlayerCharacterEquipmentId]) REFERENCES [PlayerCharacterEquipment] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([PlayerCharacterFeatId]) REFERENCES [PlayerCharacterFeat] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([ImageId]) REFERENCES [Image] ([Id])
GO

ALTER TABLE [PlayerCharacter] ADD FOREIGN KEY ([CroppedImageId]) REFERENCES [Image] ([Id])
GO

ALTER TABLE [GameMasterNote] ADD FOREIGN KEY ([ImageId]) REFERENCES [Image] ([Id])
GO

ALTER TABLE [Map] ADD FOREIGN KEY ([ImageId]) REFERENCES [Image] ([Id])
GO

ALTER TABLE [NonPlayerCharacter] ADD FOREIGN KEY ([ImageId]) REFERENCES [Image] ([Id])
GO