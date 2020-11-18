CREATE TABLE [dbo].[ETunnel]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETunnelId]	SMALLINT		NOT NULL,
	[CrossedElements]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ETunnelId] PRIMARY KEY CLUSTERED ([ETunnelId] ASC),
	CONSTRAINT [FK_ETunnel_ECrossedElements] FOREIGN KEY ([CrossedElements]) REFERENCES [dbo].[ECrossedElements] ([ECrossedElementsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
