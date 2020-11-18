CREATE TABLE [dbo].[EServiceSections]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EServiceSectionsId]	BIGINT		NOT NULL,
	[ServiceSection]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EServiceSectionsId] PRIMARY KEY CLUSTERED ([EServiceSectionsId] ASC),
	CONSTRAINT [FK_EServiceSections_TServiceSection] FOREIGN KEY ([ServiceSection]) REFERENCES [dbo].[TServiceSection] ([TServiceSectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
