CREATE TABLE [dbo].[TOcpPropOther]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpPropOtherId]	BIGINT			NOT NULL,
	[Frontier]		BIT				NOT NULL,
	[ChargeFrontier]BIT				NOT NULL,
	[Status]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOcpPropOtherId] PRIMARY KEY CLUSTERED ([TOcpPropOtherId] ASC)
);
