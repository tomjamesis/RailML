CREATE TABLE [dbo].[Infrastructure]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[InfrastructureId]		SMALLINT		NOT NULL,
	[InfraAttrGroups]		BIGINT		NOT NULL,
	[Tracks]				BIGINT		NOT NULL,
	[TrackGroups]			BIGINT		NOT NULL,
	[OperationControlPoints]	BIGINT		NOT NULL,
	[Controllers]			BIGINT		NOT NULL,
	[SpeedProfiles]		BIGINT		NOT NULL,
	[States]				BIGINT		NOT NULL,

	CONSTRAINT [PK_InfrastructureId] PRIMARY KEY CLUSTERED ([InfrastructureId] ASC),
	CONSTRAINT [FK_Infrastructure_EInfraAttrGroup] FOREIGN KEY ([InfraAttrGroups]) REFERENCES [dbo].[EInfraAttrGroup] ([EInfraAttrGroupId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Infrastructure_ETracks] FOREIGN KEY ([Tracks]) REFERENCES [dbo].[ETracks] ([ETracksId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Infrastructure_ETrackGroups] FOREIGN KEY ([TrackGroups]) REFERENCES [dbo].[ETrackGroups] ([ETrackGroupsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Infrastructure_EOperationControlPoints] FOREIGN KEY ([OperationControlPoints]) REFERENCES [dbo].[EOperationControlPoints] ([EOperationControlPointsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Infrastructure_EControllers] FOREIGN KEY ([Controllers]) REFERENCES [dbo].[EControllers] ([EControllersId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Infrastructure_ESpeedProfiles] FOREIGN KEY ([SpeedProfiles]) REFERENCES [dbo].[ESpeedProfiles] ([ESpeedProfilesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Infrastructure_TStates] FOREIGN KEY ([States]) REFERENCES [dbo].[TStates] ([TStatesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
