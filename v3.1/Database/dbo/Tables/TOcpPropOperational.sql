CREATE TABLE [dbo].[TOcpPropOperational]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpPropOperationalId]	BIGINT			NOT NULL,
	[OperationalType]		NVARCHAR(MAX)	NOT NULL,
	[TrafficType]			NVARCHAR(MAX)	NOT NULL,
	[OrderChangeable]		BIT				NOT NULL,
	[EnsuresTrainSequence]	BIT				NOT NULL,

	CONSTRAINT [PK_TOcpPropOperationalId] PRIMARY KEY CLUSTERED ([TOcpPropOperationalId] ASC)
);
