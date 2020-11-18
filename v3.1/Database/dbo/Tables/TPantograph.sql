CREATE TABLE [dbo].[TPantograph]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPantographId]					BIGINT			NOT NULL,
	[OrderNumber]						NVARCHAR(MAX)	NOT NULL,
	[DesignType]						NVARCHAR(MAX)	NOT NULL,
	[PositionOnSection]				NVARCHAR(MAX)	NOT NULL,
	[FittedSection]					NVARCHAR(MAX)	NOT NULL,
	[ControlType]						NVARCHAR(MAX)	NOT NULL,
	[HeadWidthValue]					DECIMAL(18, 6)	NOT NULL,
	[HeadWidthValueSpecified]			BIT				NOT NULL,
	[MaxCurrentDrivingValue]			DECIMAL(18, 6)	NOT NULL,
	[MaxCurrentDrivingValueSpecified]	BIT				NOT NULL,
	[MaxCurrentStandstillValue]		DECIMAL(18, 6)	NOT NULL,
	[MaxCurrentStandstillValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TPantographId] PRIMARY KEY CLUSTERED ([TPantographId] ASC)
);
