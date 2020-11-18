CREATE TABLE [dbo].[TTrainProtectionElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainProtectionElementId]	SMALLINT			NOT NULL,
	[MediumValue]				TINYINT			NOT NULL,
	[MediumValueSpecified]		BIT				NOT NULL,
	[System]					NVARCHAR(MAX)	NOT NULL,
	[TrainProtectionSystem]	NVARCHAR(MAX)	NOT NULL,
	[Model]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrainProtectionElementId] PRIMARY KEY CLUSTERED ([TTrainProtectionElementId] ASC),
	CONSTRAINT [FK_TTrainProtectionElement_TTrainProtectionMedium] FOREIGN KEY ([MediumValue]) REFERENCES [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
