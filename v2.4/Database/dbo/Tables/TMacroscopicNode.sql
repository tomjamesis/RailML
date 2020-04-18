CREATE TABLE [dbo].[TMacroscopicNode]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMacroscopicNodeId]	BIGINT			NOT NULL,
	[OcpRef]			NVARCHAR(MAX)	NOT NULL,
	[FlowDirection]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TMacroscopicNodeId] PRIMARY KEY CLUSTERED ([TMacroscopicNodeId] ASC)
);
