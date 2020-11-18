CREATE TABLE [dbo].[EBridges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBridgesId]	BIGINT		NOT NULL,
	[Brigde]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EBridgesId] PRIMARY KEY CLUSTERED ([EBridgesId] ASC),
	CONSTRAINT [FK_EBridges_EBridge] FOREIGN KEY ([Brigde]) REFERENCES [dbo].[EBridge] ([EBridgeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
