CREATE TABLE [dbo].[ETunnels]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETunnelsId]	BIGINT		NOT NULL,
	[Tunnel]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETunnelsId] PRIMARY KEY CLUSTERED ([ETunnelsId] ASC),
	CONSTRAINT [FK_ETunnels_ETunnel] FOREIGN KEY ([Tunnel]) REFERENCES [dbo].[ETunnel] ([ETunnelId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
