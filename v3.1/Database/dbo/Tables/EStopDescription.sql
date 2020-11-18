CREATE TABLE [dbo].[EStopDescription]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EStopDescriptionId]	SMALLINT		NOT NULL,
	[StopTimes]		BIGINT		NOT NULL,
	[StopActivities]	BIGINT		NOT NULL,
	[PlatformEdgeRef]	SMALLINT		NOT NULL,
	[ServiceSectionRef]SMALLINT		NOT NULL,
	[TrackInfo]		BIGINT		NOT NULL,
	[AnnotationRef]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EStopDescriptionId] PRIMARY KEY CLUSTERED ([EStopDescriptionId] ASC),
	CONSTRAINT [FK_EStopDescription_TPlatformEdgeRef] FOREIGN KEY ([PlatformEdgeRef]) REFERENCES [dbo].[TPlatformEdgeRef] ([TPlatformEdgeRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EStopDescription_TServiceSectionRef] FOREIGN KEY ([ServiceSectionRef]) REFERENCES [dbo].[TServiceSectionRef] ([TServiceSectionRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EStopDescription_TStationTrackInfo] FOREIGN KEY ([TrackInfo]) REFERENCES [dbo].[TStationTrackInfo] ([TStationTrackInfoId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EStopDescription_TAnnotationRef] FOREIGN KEY ([AnnotationRef]) REFERENCES [dbo].[TAnnotationRef] ([TAnnotationRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EStopDescription_TStopTimes] FOREIGN KEY ([StopTimes]) REFERENCES [dbo].[TStopTimes] ([TStopTimesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EStopDescription_EStopActivities] FOREIGN KEY ([StopActivities]) REFERENCES [dbo].[EStopActivities] ([EStopActivitiesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
