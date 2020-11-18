CREATE TABLE [dbo].[TClearanceGaugeType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TClearanceGaugeTypeId]	BIGINT			NOT NULL,
	[Code]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TClearanceGaugeTypeId] PRIMARY KEY CLUSTERED ([TClearanceGaugeTypeId] ASC)
);
