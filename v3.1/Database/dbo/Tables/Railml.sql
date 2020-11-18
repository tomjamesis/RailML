CREATE TABLE [dbo].[Railml]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[RailmlId]						BIGINT			NOT NULL,
	[Metadata]						SMALLINT			NOT NULL,
	[Infrastructure]				SMALLINT			NOT NULL,
	[InfrastructureVisualizations]	BIGINT			NOT NULL,
	[Rollingstock]					SMALLINT			NOT NULL,
	[Timetable]					SMALLINT			NOT NULL,
	[Version]						NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_RailmlId] PRIMARY KEY CLUSTERED ([RailmlId] ASC),
	CONSTRAINT [FK_Railml_TMetadata] FOREIGN KEY ([Metadata]) REFERENCES [dbo].[TMetadata] ([TMetadataId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Railml_Infrastructure] FOREIGN KEY ([Infrastructure]) REFERENCES [dbo].[Infrastructure] ([InfrastructureId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Railml_InfrastructureVisualizations] FOREIGN KEY ([InfrastructureVisualizations]) REFERENCES [dbo].[InfrastructureVisualizations] ([InfrastructureVisualizationsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Railml_Rollingstock] FOREIGN KEY ([Rollingstock]) REFERENCES [dbo].[Rollingstock] ([RollingstockId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Railml_Timetable] FOREIGN KEY ([Timetable]) REFERENCES [dbo].[Timetable] ([TimetableId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
