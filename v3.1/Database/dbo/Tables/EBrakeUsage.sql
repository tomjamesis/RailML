CREATE TABLE [dbo].[EBrakeUsage]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBrakeUsageId]			SMALLINT			NOT NULL,
	[Any]						VARCHAR(MAX)		NOT NULL,
	[BrakePercentage]			NVARCHAR(MAX)	NOT NULL,
	[RegularBrakePercentage]	NVARCHAR(MAX)	NOT NULL,
	[EmergencyBrakePercentage]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_EBrakeUsageId] PRIMARY KEY CLUSTERED ([EBrakeUsageId] ASC)
);
