CREATE TABLE [dbo].[EOcpPropOther]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOcpPropOtherId]	SMALLINT		NOT NULL,
	[AdditionalName]BIGINT		NOT NULL,
	[States]		BIGINT		NOT NULL,

	CONSTRAINT [PK_EOcpPropOtherId] PRIMARY KEY CLUSTERED ([EOcpPropOtherId] ASC),
	CONSTRAINT [FK_EOcpPropOther_TOcpAdditionalName] FOREIGN KEY ([AdditionalName]) REFERENCES [dbo].[TOcpAdditionalName] ([TOcpAdditionalNameId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcpPropOther_TStates] FOREIGN KEY ([States]) REFERENCES [dbo].[TStates] ([TStatesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
