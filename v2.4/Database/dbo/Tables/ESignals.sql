CREATE TABLE [dbo].[ESignals]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESignalsId]	BIGINT		NOT NULL,
	[Signal]		SMALLINT		NOT NULL,
	[SignalGroups]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ESignalsId] PRIMARY KEY CLUSTERED ([ESignalsId] ASC),
	CONSTRAINT [FK_ESignals_TSignal] FOREIGN KEY ([Signal]) REFERENCES [dbo].[TSignal] ([TSignalId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ESignals_ESignalGroups] FOREIGN KEY ([SignalGroups]) REFERENCES [dbo].[ESignalGroups] ([ESignalGroupsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
