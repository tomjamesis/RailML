CREATE TABLE [dbo].[TStrictOrientedElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStrictOrientedElementId]	SMALLINT		NOT NULL,
	[DirValue]					TINYINT		NOT NULL,
	[DirValueSpecified]		BIT			NOT NULL,

	CONSTRAINT [PK_TStrictOrientedElementId] PRIMARY KEY CLUSTERED ([TStrictOrientedElementId] ASC),
	CONSTRAINT [FK_TStrictOrientedElement_TStrictDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TStrictDirection] ([TStrictDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
