CREATE TABLE [dbo].[TOcpUptime]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpUptimeId]	SMALLINT			NOT NULL,
	[Mode]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOcpUptimeId] PRIMARY KEY CLUSTERED ([TOcpUptimeId] ASC)
);
