CREATE TABLE [dbo].[TTrainProtectionElementGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainProtectionElementGroupId]	SMALLINT		NOT NULL,
	[TrainProtectionElementRef]	BIGINT		NOT NULL,

	CONSTRAINT [PK_TTrainProtectionElementGroupId] PRIMARY KEY CLUSTERED ([TTrainProtectionElementGroupId] ASC),
	CONSTRAINT [FK_TTrainProtectionElementGroup_TElementWithReference] FOREIGN KEY ([TrainProtectionElementRef]) REFERENCES [dbo].[TElementWithReference] ([TElementWithReferenceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
