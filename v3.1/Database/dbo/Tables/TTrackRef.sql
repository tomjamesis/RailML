CREATE TABLE [dbo].[TTrackRef]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrackRefId]		SMALLINT		NOT NULL,
	[DirValue]			TINYINT		NOT NULL,
	[DirValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TTrackRefId] PRIMARY KEY CLUSTERED ([TTrackRefId] ASC),
	CONSTRAINT [FK_TTrackRef_TStrictDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TStrictDirection] ([TStrictDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
