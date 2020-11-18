CREATE TABLE [dbo].[InfrastructureVisualizations]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[InfrastructureVisualizationsId]	BIGINT			NOT NULL,
	[Visualization]				SMALLINT			NOT NULL,
	[Base]							NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_InfrastructureVisualizationsId] PRIMARY KEY CLUSTERED ([InfrastructureVisualizationsId] ASC),
	CONSTRAINT [FK_InfrastructureVisualizations_EInfrastructureVisualization] FOREIGN KEY ([Visualization]) REFERENCES [dbo].[EInfrastructureVisualization] ([EInfrastructureVisualizationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
