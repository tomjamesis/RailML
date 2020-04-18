CREATE TABLE [dbo].[TTechnicalStopActivity]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTechnicalStopActivityId]	BIGINT			NOT NULL,
	[MinimumTime]				NVARCHAR(MAX)	NOT NULL,
	[Purpose]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTechnicalStopActivityId] PRIMARY KEY CLUSTERED ([TTechnicalStopActivityId] ASC)
);
