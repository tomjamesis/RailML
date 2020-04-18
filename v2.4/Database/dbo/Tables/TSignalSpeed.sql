CREATE TABLE [dbo].[TSignalSpeed]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalSpeedId]	SMALLINT			NOT NULL,
	[SpeedChangeRef]	BIGINT			NOT NULL,
	[Kind]			NVARCHAR(MAX)	NOT NULL,
	[TrainRelation]NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalSpeedId] PRIMARY KEY CLUSTERED ([TSignalSpeedId] ASC),
	CONSTRAINT [FK_TSignalSpeed_TElementWithReference] FOREIGN KEY ([SpeedChangeRef]) REFERENCES [dbo].[TElementWithReference] ([TElementWithReferenceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
