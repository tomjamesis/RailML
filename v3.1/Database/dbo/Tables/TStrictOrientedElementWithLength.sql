CREATE TABLE [dbo].[TStrictOrientedElementWithLength]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStrictOrientedElementWithLengthId]	SMALLINT		NOT NULL,
	[DirValue]							TINYINT		NOT NULL,
	[DirValueSpecified]				BIT			NOT NULL,

	CONSTRAINT [PK_TStrictOrientedElementWithLengthId] PRIMARY KEY CLUSTERED ([TStrictOrientedElementWithLengthId] ASC),
	CONSTRAINT [FK_TStrictOrientedElementWithLength_TStrictDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TStrictDirection] ([TStrictDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
