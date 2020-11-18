CREATE TABLE [dbo].[TOwner]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOwnerId]					BIGINT			NOT NULL,
	[OwnerName]				NVARCHAR(MAX)	NOT NULL,
	[Uic_No]					NVARCHAR(MAX)	NOT NULL,
	[InfrastructureManagerRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOwnerId] PRIMARY KEY CLUSTERED ([TOwnerId] ASC)
);
