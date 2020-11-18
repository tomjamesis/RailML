CREATE TABLE [dbo].[TOcpTTType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpTTTypeId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(5)	NOT NULL,

	CONSTRAINT [PK_TOcpTTTypeId] PRIMARY KEY CLUSTERED ([TOcpTTTypeId] ASC)
);
