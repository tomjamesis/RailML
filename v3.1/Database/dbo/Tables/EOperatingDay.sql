CREATE TABLE [dbo].[EOperatingDay]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOperatingDayId]		SMALLINT		NOT NULL,
	[OperatingDayDeviance]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EOperatingDayId] PRIMARY KEY CLUSTERED ([EOperatingDayId] ASC),
	CONSTRAINT [FK_EOperatingDay_TOperatingDayDeviance] FOREIGN KEY ([OperatingDayDeviance]) REFERENCES [dbo].[TOperatingDayDeviance] ([TOperatingDayDevianceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
