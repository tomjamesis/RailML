CREATE TABLE [dbo].[ETrainParts]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainPartsId]	BIGINT		NOT NULL,
	[TrainPart]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainPartsId] PRIMARY KEY CLUSTERED ([ETrainPartsId] ASC),
	CONSTRAINT [FK_ETrainParts_ETrainPart] FOREIGN KEY ([TrainPart]) REFERENCES [dbo].[ETrainPart] ([ETrainPartId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
