CREATE TABLE [dbo].[ESignalGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESignalGroupId]	SMALLINT		NOT NULL,
	[SignalRef]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ESignalGroupId] PRIMARY KEY CLUSTERED ([ESignalGroupId] ASC),
	CONSTRAINT [FK_ESignalGroup_TSignalRefInGroup] FOREIGN KEY ([SignalRef]) REFERENCES [dbo].[TSignalRefInGroup] ([TSignalRefInGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
