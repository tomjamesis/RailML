CREATE TABLE [dbo].[TSpecialServiceType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpecialServiceTypeId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(7)	NOT NULL,

	CONSTRAINT [PK_TSpecialServiceTypeId] PRIMARY KEY CLUSTERED ([TSpecialServiceTypeId] ASC)
);
