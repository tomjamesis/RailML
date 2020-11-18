CREATE TABLE [dbo].[TLoadLimitMatrixType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLoadLimitMatrixTypeId]	BIGINT		NOT NULL,
	[ChassisSpeedValue]		DECIMAL(18, 6)	NOT NULL,
	[ChassisSpeedValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TLoadLimitMatrixTypeId] PRIMARY KEY CLUSTERED ([TLoadLimitMatrixTypeId] ASC)
);
