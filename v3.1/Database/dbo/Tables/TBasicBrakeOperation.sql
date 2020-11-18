CREATE TABLE [dbo].[TBasicBrakeOperation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBasicBrakeOperationId]		BIGINT			NOT NULL,
	[DecelerationTable]			SMALLINT			NOT NULL,
	[BrakeSupervision]				NVARCHAR(MAX)	NOT NULL,
	[DecelerationDelay]			NVARCHAR(MAX)	NOT NULL,
	[ReleaseSpeedValue]			DECIMAL(18, 6)	NOT NULL,
	[ReleaseSpeedValueSpecified]	BIT				NOT NULL,
	[MeanDecelerationValue]		DECIMAL(18, 6)	NOT NULL,
	[MeanDecelerationValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TBasicBrakeOperationId] PRIMARY KEY CLUSTERED ([TBasicBrakeOperationId] ASC),
	CONSTRAINT [FK_TBasicBrakeOperation_TDecelerationCurve] FOREIGN KEY ([DecelerationTable]) REFERENCES [dbo].[TDecelerationCurve] ([TDecelerationCurveId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
