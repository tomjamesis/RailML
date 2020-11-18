CREATE TABLE [dbo].[TStopPost]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStopPostId]				SMALLINT			NOT NULL,
	[ValidForMovements]		BIGINT			NOT NULL,
	[SignalRef]				BIGINT			NOT NULL,
	[TrainRelation]			NVARCHAR(MAX)	NOT NULL,
	[PlatformEdgeRef]			NVARCHAR(MAX)	NOT NULL,
	[TrainLengthValue]			DECIMAL(18, 6)	NOT NULL,
	[TrainLengthValueSpecified]	BIT				NOT NULL,
	[AxleCount]				NVARCHAR(MAX)	NOT NULL,
	[WagonCount]				NVARCHAR(MAX)	NOT NULL,
	[VerbalConstraints]		NVARCHAR(MAX)	NOT NULL,
	[VirtualValue]				BIT				NOT NULL,
	[VirtualValueSpecified]	BIT				NOT NULL,
	[OcpRef]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStopPostId] PRIMARY KEY CLUSTERED ([TStopPostId] ASC),
	CONSTRAINT [FK_TStopPost_TValidForMovements] FOREIGN KEY ([ValidForMovements]) REFERENCES [dbo].[TValidForMovements] ([TValidForMovementsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TStopPost_TElementWithReference] FOREIGN KEY ([SignalRef]) REFERENCES [dbo].[TElementWithReference] ([TElementWithReferenceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
