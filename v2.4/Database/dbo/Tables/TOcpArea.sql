CREATE TABLE [dbo].[TOcpArea]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpAreaId]	BIGINT			NOT NULL,
	[Name]		NVARCHAR(MAX)	NOT NULL,
	[Number]	NVARCHAR(MAX)	NOT NULL,
	[Zip]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOcpAreaId] PRIMARY KEY CLUSTERED ([TOcpAreaId] ASC)
);
