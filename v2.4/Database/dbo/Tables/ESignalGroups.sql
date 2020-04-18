CREATE TABLE [dbo].[ESignalGroups]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESignalGroupsId]	BIGINT		NOT NULL,
	[SignalGroup]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ESignalGroupsId] PRIMARY KEY CLUSTERED ([ESignalGroupsId] ASC),
	CONSTRAINT [FK_ESignalGroups_ESignalGroup] FOREIGN KEY ([SignalGroup]) REFERENCES [dbo].[ESignalGroup] ([ESignalGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
