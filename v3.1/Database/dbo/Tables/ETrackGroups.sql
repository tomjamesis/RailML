CREATE TABLE [dbo].[ETrackGroups]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackGroupsId]		BIGINT			NOT NULL,
	[Line]					SMALLINT			NOT NULL,
	[LocallyControlledArea]	SMALLINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_ETrackGroupsId] PRIMARY KEY CLUSTERED ([ETrackGroupsId] ASC),
	CONSTRAINT [FK_ETrackGroups_ELine] FOREIGN KEY ([Line]) REFERENCES [dbo].[ELine] ([ELineId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackGroups_ELocallyControlledArea] FOREIGN KEY ([LocallyControlledArea]) REFERENCES [dbo].[ELocallyControlledArea] ([ELocallyControlledAreaId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
