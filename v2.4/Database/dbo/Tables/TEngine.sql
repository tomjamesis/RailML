CREATE TABLE [dbo].[TEngine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TEngineId]				BIGINT			NOT NULL,
	[AxleDriveType]			NVARCHAR(MAX)	NOT NULL,
	[HaulageLoadValue]			DECIMAL(18, 6)	NOT NULL,
	[HaulageLoadValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TEngineId] PRIMARY KEY CLUSTERED ([TEngineId] ASC)
);
