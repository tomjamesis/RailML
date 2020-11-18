CREATE TABLE [dbo].[TMileageChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMileageChangeId]				SMALLINT		NOT NULL,
	[GeoCoord]						BIGINT		NOT NULL,
	[AbsPosIn]						DECIMAL(18, 6)	NOT NULL,
	[AbsPosInOffsetValue]			DECIMAL(18, 6)	NOT NULL,
	[AbsPosInOffsetValueSpecified]	BIT			NOT NULL,
	[Type]							SMALLINT		NOT NULL,
	[AbsPos]						DECIMAL(18, 6)	NOT NULL,
	[Pos]							DECIMAL(18, 6)	NOT NULL,
	[AbsDirValue]					TINYINT		NOT NULL,
	[AbsDirValueSpecified]			BIT			NOT NULL,
	[DirValue]						TINYINT		NOT NULL,
	[DirValueSpecified]			BIT			NOT NULL,

	CONSTRAINT [PK_TMileageChangeId] PRIMARY KEY CLUSTERED ([TMileageChangeId] ASC),
	CONSTRAINT [FK_TMileageChange_TGeoCoord] FOREIGN KEY ([GeoCoord]) REFERENCES [dbo].[TGeoCoord] ([TGeoCoordId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TMileageChange_Type] FOREIGN KEY ([Type]) REFERENCES [dbo].[Type] ([TypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TMileageChange_TMileageDirection] FOREIGN KEY ([AbsDirValue]) REFERENCES [dbo].[TMileageDirection] ([TMileageDirectionId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TMileageChange_TStrictDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TStrictDirection] ([TStrictDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
