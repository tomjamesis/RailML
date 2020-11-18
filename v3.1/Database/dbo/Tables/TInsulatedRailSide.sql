CREATE TABLE [dbo].[TInsulatedRailSide]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TInsulatedRailSideId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(5)	NOT NULL,

	CONSTRAINT [PK_TInsulatedRailSideId] PRIMARY KEY CLUSTERED ([TInsulatedRailSideId] ASC)
);
