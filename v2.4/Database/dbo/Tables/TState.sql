CREATE TABLE [dbo].[TState]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStateId]				BIGINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,
	[Disabled]				BIT				NOT NULL,
	[Status]				NVARCHAR(MAX)	NOT NULL,
	[OperatingPeriodRef]	NVARCHAR(MAX)	NOT NULL,
	[StartTimeValue]		DATETIME			NOT NULL,
	[StartTimeValueSpecified]	BIT				NOT NULL,
	[EndTimeValue]			DATETIME			NOT NULL,
	[EndTimeValueSpecified]BIT				NOT NULL,
	[EndDayOffset]			NVARCHAR(MAX)	NOT NULL,
	[Remarks]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStateId] PRIMARY KEY CLUSTERED ([TStateId] ASC)
);
