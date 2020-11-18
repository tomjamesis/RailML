CREATE TABLE [dbo].[TSignalBase]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalBaseId]			BIGINT		NOT NULL,
	[SwitchableValue]			BIT			NOT NULL,
	[SwitchableValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TSignalBaseId] PRIMARY KEY CLUSTERED ([TSignalBaseId] ASC)
);
