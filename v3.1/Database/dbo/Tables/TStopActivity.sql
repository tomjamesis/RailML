CREATE TABLE [dbo].[TStopActivity]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStopActivityId]	BIGINT			NOT NULL,
	[Type]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStopActivityId] PRIMARY KEY CLUSTERED ([TStopActivityId] ASC)
);
