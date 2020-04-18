CREATE TABLE [dbo].[TLoadLimitType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLoadLimitTypeId]	BIGINT		NOT NULL,
	[MaxSpeed]			DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TLoadLimitTypeId] PRIMARY KEY CLUSTERED ([TLoadLimitTypeId] ASC)
);
