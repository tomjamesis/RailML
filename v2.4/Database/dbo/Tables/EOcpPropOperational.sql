CREATE TABLE [dbo].[EOcpPropOperational]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOcpPropOperationalId]	SMALLINT		NOT NULL,
	[Uptime]				SMALLINT		NOT NULL,

	CONSTRAINT [PK_EOcpPropOperationalId] PRIMARY KEY CLUSTERED ([EOcpPropOperationalId] ASC),
	CONSTRAINT [FK_EOcpPropOperational_TOcpUptime] FOREIGN KEY ([Uptime]) REFERENCES [dbo].[TOcpUptime] ([TOcpUptimeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
