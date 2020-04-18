CREATE TABLE [dbo].[TTrack]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrackId]				SMALLINT			NOT NULL,
	[States]				BIGINT			NOT NULL,
	[Type]					NVARCHAR(MAX)	NOT NULL,
	[MainDirValue]			TINYINT			NOT NULL,
	[MainDirValueSpecified]	BIT				NOT NULL,
	[InfraAttrGroupRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrackId] PRIMARY KEY CLUSTERED ([TTrackId] ASC),
	CONSTRAINT [FK_TTrack_TStatesWithLength] FOREIGN KEY ([States]) REFERENCES [dbo].[TStatesWithLength] ([TStatesWithLengthId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TTrack_TExtendedDirection] FOREIGN KEY ([MainDirValue]) REFERENCES [dbo].[TExtendedDirection] ([TExtendedDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
