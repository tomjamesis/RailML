CREATE TABLE [dbo].[TRunTimes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRunTimesId]		BIGINT			NOT NULL,
	[MinimalTime]		NVARCHAR(MAX)	NOT NULL,
	[OperationalReserve]	NVARCHAR(MAX)	NOT NULL,
	[AdditionalReserve]NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TRunTimesId] PRIMARY KEY CLUSTERED ([TRunTimesId] ASC)
);
