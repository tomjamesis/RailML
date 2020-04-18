CREATE TABLE [dbo].[EBridge]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBridgeId]	SMALLINT		NOT NULL,
	[CrossedElements]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EBridgeId] PRIMARY KEY CLUSTERED ([EBridgeId] ASC),
	CONSTRAINT [FK_EBridge_ECrossedElements] FOREIGN KEY ([CrossedElements]) REFERENCES [dbo].[ECrossedElements] ([ECrossedElementsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
