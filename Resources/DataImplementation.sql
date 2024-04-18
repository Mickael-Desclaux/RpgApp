INSERT INTO [DiceType] (Sides)
VALUES (4), (6), (8), (10), (12), (20), (100);

INSERT INTO [Language] (Name)
VALUES ('Commun'), ('Elfe'), ('Géant'), ('Gnome'), ('Gobelin'), ('Halfelin'), ('Nain'), ('Orc'), ('Abyssal'), ('Céleste'),
       ('Commun des profondeurs'), ('Draconique'), ('Infernal'), ('Primordial'), ('Profond'), ('Sylvain');

INSERT INTO [Alignment] (Morality, Attitude)
VALUES ('Loyal', 'Bon'), ('Neutre', 'Bon'), ('Chaotique', 'Bon'), ('Loyal', 'Neutre'), ('Neutre', 'Neutre'), ('Chaotique', 'Neutre'),
       ('Loyal', 'Mauvais'), ('Neutre', 'Mauvais'), ('Chaotique', 'Mauvais');

INSERT INTO [Resistance] (Name)
VALUES ('Acide'), ('Contandant'), ('Feu'), ('Force'), ('Foudre'), ('Froid'), ('Nécrotique'), ('Perforant'), ('Poison'),
       ('Psychique'), ('Radiant'), ('Tonerre'), ('Tranchant');

INSERT INTO [Immunity] (Name)
VALUES ('Acide'), ('Contandant'), ('Feu'), ('Force'), ('Foudre'), ('Froid'), ('Nécrotique'), ('Perforant'), ('Poison'),
       ('Psychique'), ('Radiant'), ('Tonerre'), ('Tranchant');

INSERT INTO [EquipmentType] (Name)
VALUES ('Armure légère'), ('Armure moyenne'), ('Armure lourde'), ('Bouclier'), ('Arme de corps à corps'), ('Arme à distance'),
       ('Arme magique'), ('Consommable'), ('Arme de jet'), ('Outils'), ('Instrument de musique'), ('Vêtements'), ('Autre')