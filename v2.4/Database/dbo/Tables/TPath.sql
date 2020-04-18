CREATE TABLE [dbo].[TPath]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPathId]	BIGINT		NOT NULL,
	[OcpRef]SMALLINT		NOT NULL,

	CONSTRAINT [PK_TPathId] PRIMARY KEY CLUSTERED ([TPathId] ASC),
	CONSTRAINT [FK_TPath_TOcpRefInGroup] FOREIGN KEY ([OcpRef]) REFERENCES [dbo].[TOcpRefInGroup] ([TOcpRefInGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
