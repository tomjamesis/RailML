CREATE TABLE [dbo].[TOcpAdditionalName]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpAdditionalNameId]	BIGINT			NOT NULL,
	[Value]				NVARCHAR(MAX)	NOT NULL,
	[Type]					NVARCHAR(MAX)	NOT NULL,
	[Lang]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOcpAdditionalNameId] PRIMARY KEY CLUSTERED ([TOcpAdditionalNameId] ASC)
);
