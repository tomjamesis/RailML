CREATE TABLE [dbo].[TCurrentLimitation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCurrentLimitationId]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_TCurrentLimitationId] PRIMARY KEY CLUSTERED ([TCurrentLimitationId] ASC)
);
