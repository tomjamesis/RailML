CREATE TABLE [dbo].[TInfrastructureVisualization]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[Version]						NVARCHAR(MAX)	NOT NULL,
	[InfrastructureRef]			NVARCHAR(MAX)	NOT NULL,
	[TInfrastructureVisualizationId]	NVARCHAR(255)	NOT NULL,

	CONSTRAINT [PK_TInfrastructureVisualizationId] PRIMARY KEY CLUSTERED ([TInfrastructureVisualizationId] ASC)
);
