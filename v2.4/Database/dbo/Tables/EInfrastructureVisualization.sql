CREATE TABLE [dbo].[EInfrastructureVisualization]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EInfrastructureVisualizationId]	SMALLINT		NOT NULL,
	[LineVis]						SMALLINT		NOT NULL,
	[OcpVis]						SMALLINT		NOT NULL,

	CONSTRAINT [PK_EInfrastructureVisualizationId] PRIMARY KEY CLUSTERED ([EInfrastructureVisualizationId] ASC),
	CONSTRAINT [FK_EInfrastructureVisualization_ELineVis] FOREIGN KEY ([LineVis]) REFERENCES [dbo].[ELineVis] ([ELineVisId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfrastructureVisualization_EOcpVis] FOREIGN KEY ([OcpVis]) REFERENCES [dbo].[EOcpVis] ([EOcpVisId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
