CREATE TABLE [dbo].[EAxleWeightChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EAxleWeightChangesId]	BIGINT		NOT NULL,
	[AxleWeightChange]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EAxleWeightChangesId] PRIMARY KEY CLUSTERED ([EAxleWeightChangesId] ASC),
	CONSTRAINT [FK_EAxleWeightChanges_TAxleWeightChange] FOREIGN KEY ([AxleWeightChange]) REFERENCES [dbo].[TAxleWeightChange] ([TAxleWeightChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
