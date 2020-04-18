CREATE TABLE [dbo].[TBaseServiceSection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBaseServiceSectionId]	SMALLINT			NOT NULL,
	[HeightValue]			DECIMAL(18, 6)	NOT NULL,
	[HeightValueSpecified]	BIT				NOT NULL,
	[SideValue]			TINYINT			NOT NULL,
	[SideValueSpecified]	BIT				NOT NULL,
	[OcpRef]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBaseServiceSectionId] PRIMARY KEY CLUSTERED ([TBaseServiceSectionId] ASC),
	CONSTRAINT [FK_TBaseServiceSection_TSide] FOREIGN KEY ([SideValue]) REFERENCES [dbo].[TSide] ([TSideId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
