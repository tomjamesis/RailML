CREATE TABLE [dbo].[TPlacesTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPlacesTTId]		BIGINT			NOT NULL,
	[Category]			NVARCHAR(MAX)	NOT NULL,
	[TapTsiType9039Code]	NVARCHAR(MAX)	NOT NULL,
	[Count]			NVARCHAR(MAX)	NOT NULL,
	[Description]		NVARCHAR(MAX)	NOT NULL,
	[Reservation]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TPlacesTTId] PRIMARY KEY CLUSTERED ([TPlacesTTId] ASC)
);
