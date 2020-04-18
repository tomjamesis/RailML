CREATE TABLE [dbo].[EConnections]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EConnectionsId]	BIGINT		NOT NULL,
	[Switch]		SMALLINT		NOT NULL,
	[Crossing]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EConnectionsId] PRIMARY KEY CLUSTERED ([EConnectionsId] ASC),
	CONSTRAINT [FK_EConnections_ESwitch] FOREIGN KEY ([Switch]) REFERENCES [dbo].[ESwitch] ([ESwitchId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EConnections_ECrossing] FOREIGN KEY ([Crossing]) REFERENCES [dbo].[ECrossing] ([ECrossingId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
