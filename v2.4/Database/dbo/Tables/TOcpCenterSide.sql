CREATE TABLE [dbo].[TOcpCenterSide]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpCenterSideId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(6)	NOT NULL,

	CONSTRAINT [PK_TOcpCenterSideId] PRIMARY KEY CLUSTERED ([TOcpCenterSideId] ASC)
);
