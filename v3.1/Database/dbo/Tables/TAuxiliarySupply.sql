CREATE TABLE [dbo].[TAuxiliarySupply]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAuxiliarySupplyId]			BIGINT		NOT NULL,
	[Power]						DECIMAL(18, 6)	NOT NULL,
	[PowerPhiValue]				DECIMAL(18, 6)	NOT NULL,
	[PowerPhiValueSpecified]		BIT			NOT NULL,
	[ResistanceValue]				DECIMAL(18, 6)	NOT NULL,
	[ResistanceValueSpecified]		BIT			NOT NULL,
	[PowerBrakingValue]			DECIMAL(18, 6)	NOT NULL,
	[PowerBrakingValueSpecified]	BIT			NOT NULL,
	[PowerPhiBrakingValue]			DECIMAL(18, 6)	NOT NULL,
	[PowerPhiBrakingValueSpecified]BIT			NOT NULL,
	[ResistanceBrakingValue]		DECIMAL(18, 6)	NOT NULL,
	[ResistanceBrakingValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TAuxiliarySupplyId] PRIMARY KEY CLUSTERED ([TAuxiliarySupplyId] ASC)
);
