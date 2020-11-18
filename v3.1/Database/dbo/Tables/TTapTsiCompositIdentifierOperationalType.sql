CREATE TABLE [dbo].[TTapTsiCompositIdentifierOperationalType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTapTsiCompositIdentifierOperationalTypeId]	BIGINT			NOT NULL,
	[ObjectType]								NVARCHAR(MAX)	NOT NULL,
	[CompanyCode]								NVARCHAR(MAX)	NOT NULL,
	[Core]										NVARCHAR(MAX)	NOT NULL,
	[Variant]									NVARCHAR(MAX)	NOT NULL,
	[TimetableYear]							NVARCHAR(MAX)	NOT NULL,
	[StartDateValue]							DATETIME			NOT NULL,
	[StartDateValueSpecified]					BIT				NOT NULL,

	CONSTRAINT [PK_TTapTsiCompositIdentifierOperationalTypeId] PRIMARY KEY CLUSTERED ([TTapTsiCompositIdentifierOperationalTypeId] ASC)
);
