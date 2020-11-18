CREATE TABLE [dbo].[TOperator]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperatorId]			BIGINT			NOT NULL,
	[OperatorName]			NVARCHAR(MAX)	NOT NULL,
	[VehicleOperatorRef]	NVARCHAR(MAX)	NOT NULL,
	[OperatorClass]		NVARCHAR(MAX)	NOT NULL,
	[StartDateValue]		DATETIME			NOT NULL,
	[StartDateValueSpecified]	BIT				NOT NULL,
	[EndDateValue]			DATETIME			NOT NULL,
	[EndDateValueSpecified]BIT				NOT NULL,

	CONSTRAINT [PK_TOperatorId] PRIMARY KEY CLUSTERED ([TOperatorId] ASC)
);
