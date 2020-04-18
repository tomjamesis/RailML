CREATE TABLE [dbo].[TCrossSection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCrossSectionId]			SMALLINT			NOT NULL,
	[Type]						NVARCHAR(MAX)	NOT NULL,
	[OcpRef]					NVARCHAR(MAX)	NOT NULL,
	[OcpTrackIDValue]			TINYINT			NOT NULL,
	[OcpTrackIDValueSpecified]	BIT				NOT NULL,
	[DirValue]					TINYINT			NOT NULL,
	[DirValueSpecified]		BIT				NOT NULL,
	[OcpCenterSideValue]		TINYINT			NOT NULL,
	[OcpCenterSideValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TCrossSectionId] PRIMARY KEY CLUSTERED ([TCrossSectionId] ASC),
	CONSTRAINT [FK_TCrossSection_TLaxDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TLaxDirection] ([TLaxDirectionId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TCrossSection_TOcpCenterSide] FOREIGN KEY ([OcpCenterSideValue]) REFERENCES [dbo].[TOcpCenterSide] ([TOcpCenterSideId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
