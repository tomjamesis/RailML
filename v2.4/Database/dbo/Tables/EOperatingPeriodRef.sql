CREATE TABLE [dbo].[EOperatingPeriodRef]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOperatingPeriodRefId]	SMALLINT		NOT NULL,
	[SpecialService]		BIGINT		NOT NULL,

	CONSTRAINT [PK_EOperatingPeriodRefId] PRIMARY KEY CLUSTERED ([EOperatingPeriodRefId] ASC),
	CONSTRAINT [FK_EOperatingPeriodRef_TSpecialService] FOREIGN KEY ([SpecialService]) REFERENCES [dbo].[TSpecialService] ([TSpecialServiceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
