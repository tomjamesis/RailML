CREATE TABLE [dbo].[TOcpTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpTTId]					BIGINT			NOT NULL,
	[Sequence]					NVARCHAR(MAX)	NOT NULL,
	[OcpRef]					NVARCHAR(MAX)	NOT NULL,
	[TrackRef]					NVARCHAR(MAX)	NOT NULL,
	[TrackInfo]				NVARCHAR(MAX)	NOT NULL,
	[OcpTypeValue]				TINYINT			NOT NULL,
	[OcpTypeValueSpecified]	BIT				NOT NULL,
	[Remarks]					NVARCHAR(MAX)	NOT NULL,
	[TrainReverseValue]		BIT				NOT NULL,
	[TrainReverseValueSpecified]	BIT				NOT NULL,
	[AlignmentValue]			TINYINT			NOT NULL,
	[AlignmentValueSpecified]	BIT				NOT NULL,
	[OffsetValue]				DECIMAL(18, 6)	NOT NULL,
	[OffsetValueSpecified]		BIT				NOT NULL,
	[ShuntingTime]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOcpTTId] PRIMARY KEY CLUSTERED ([TOcpTTId] ASC),
	CONSTRAINT [FK_TOcpTT_TOcpTTType] FOREIGN KEY ([OcpTypeValue]) REFERENCES [dbo].[TOcpTTType] ([TOcpTTTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOcpTT_TTrainAlignment] FOREIGN KEY ([AlignmentValue]) REFERENCES [dbo].[TTrainAlignment] ([TTrainAlignmentId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
