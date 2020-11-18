CREATE TABLE [dbo].[ETrainRadio]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainRadioId]	SMALLINT			NOT NULL,
	[RadioSystem]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_ETrainRadioId] PRIMARY KEY CLUSTERED ([ETrainRadioId] ASC)
);
