CREATE TABLE [dbo].[TOcpTsi]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpTsiId]	BIGINT			NOT NULL,
	[Country]	NVARCHAR(MAX)	NOT NULL,
	[Location]	NVARCHAR(MAX)	NOT NULL,
	[Check]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOcpTsiId] PRIMARY KEY CLUSTERED ([TOcpTsiId] ASC)
);
