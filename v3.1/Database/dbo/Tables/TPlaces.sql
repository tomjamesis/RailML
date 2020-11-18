CREATE TABLE [dbo].[TPlaces]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPlacesId]		BIGINT			NOT NULL,
	[Category]			NVARCHAR(MAX)	NOT NULL,
	[TapTsiType9039Code]	NVARCHAR(MAX)	NOT NULL,
	[Count]			NVARCHAR(MAX)	NOT NULL,
	[Description]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TPlacesId] PRIMARY KEY CLUSTERED ([TPlacesId] ASC)
);
